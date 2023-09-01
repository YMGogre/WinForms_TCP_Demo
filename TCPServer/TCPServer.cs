using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace TCPServer
{
    public partial class TCPServer : Form
    {
        string hostIPStr = "127.0.0.1";
        IPAddress hostIP;
        int hostProt;
        /// <summary>
        /// 有关 <see cref="ConcurrentDictionary{TKey, TValue}"/> 的信息，请参考 <see href="https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.concurrent.concurrentdictionary-2?view=net-6.0">MSDN</see>
        /// </summary>
        private readonly ConcurrentDictionary<string, ClientStruct> clientMapper = new ConcurrentDictionary<string, ClientStruct>();
        /// <summary>
        /// 使用一个 <see cref="BindingList{T}"/> 作为 ListBox 的数据源，请参考 <see href="https://stackoverflow.com/questions/7860467/events-for-adding-removing-items-in-a-listbox-c-net">stack overflow</see>
        /// </summary>
        BindingList<string> clientsList = new BindingList<string>();
        /// <summary>
        /// 使用一个动态数组保存快捷消息
        /// </summary>
        public static readonly List<QuickMsg> quickMsgs = new List<QuickMsg>();
        /// <summary>
        /// 声明一个事件用于表示“当前新增了一项快捷消息”
        /// </summary>
        private event EventHandler<QuickMsgAddedEventArgs> quickMsgAdded;
        /// <summary>
        /// 定义引发事件的方法
        /// </summary>
        /// <param name="quickMsgName">快捷消息名</param>
        private void RaiseQuickMsgAdded(string quickMsgName) => quickMsgAdded?.Invoke(this, new QuickMsgAddedEventArgs(quickMsgName));

        public TCPServer()
        {
            InitializeComponent();
        }

        private void TcpListen()
        {
            try
            {
                //实例化监听者套接字，用于绑定本地终结点并接受客户端连接
                var listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //允许将套接字绑定到已使用中的地址
                listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                //初始化本地终结点实例
                var localEP = new IPEndPoint(hostIP, hostProt);
                //套接字关联本地终结点
                listenerSocket.Bind(localEP);
                //开启监听
                listenerSocket.Listen(10);      //最大连接数为 10
                PrintLog($"开始监听，主机 IP：{localEP.Address}；端口号：{localEP.Port}");
                //开始异步接受传入的连接尝试
                listenerSocket.BeginAccept(new AsyncCallback(OnConnectionRequest), listenerSocket);
                /** 
                 * BeginAccept 方法的第二个参数（object state）是一个用户定义的对象，它可以传递给回调函数，该参数可以用于在回调函数中传递额外的信息。
                 * 比如我们将监听 Socket 对象作为 state 参数传递给了 BeginAccept 方法，在 BeginAccept 方法中，它会使用监听 Socket 对象去初始化一个 IAsyncResult 对象并返回。
                 * IAsyncResult 对象包含了一个 AsyncState 属性，它的值就是传递给 BeginAccept 方法的第二个参数 state。这样，我们就能够在回调函数中使用该属性来获取监听 Socket 对象，以便继续监听客户端连接。
                 * 当然，可以根据需要传递任何类型的对象作为 state 参数。这个参数对于在回调函数中传递额外的信息非常有用。
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在开始监听的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 接受连接请求并开始接收消息
        /// </summary>
        /// <param name="ar">表示异步操作的状态</param>
        private void OnConnectionRequest(IAsyncResult ar)
        {
            try
            {
                //获取侦听的 Socket 以便继续监听客户端连接
                var listenerSocket = ar.AsyncState as Socket;
                ClientStruct clientStruct = new ClientStruct();
                //异步接受传入的连接尝试并创建处理远程主机通信的 Socket，由该 Socket 创建 TCP 客户端结构体
                this.Invoke(new Action(() => { clientStruct = CommunicationConfiguration.GetClientStruct(listenerSocket.EndAccept(ar), this); }));
                //客户端结构体保存到字典中
                if(clientMapper.TryAdd(clientStruct.ClientName, clientStruct))
                {
                    //客户端列表添加新增的客户端名称
                    clientsList.Add(clientStruct.ClientName);
                    //继续监听等待新的客户端连接
                    listenerSocket.BeginAccept(new AsyncCallback(OnConnectionRequest), listenerSocket);
                    //新增该客户端的选项卡页面
                    var clientPage = AddTabPage(clientStruct);
                    //绑定主页面的“新增了快捷消息事件”与客户端页面的相应处理函数
                    this.quickMsgAdded += clientPage.OnQuickMsgAdded;
                    //开始循环接收其消息
                    clientPage.ReceiveUntilDisconnect();
                    ///<see cref="ClientPage.ReceiveUntilDisconnect"/> 方法返回则说明客户端已断开连接
                    PrintLog($"客户端[{clientStruct.Socket.RemoteEndPoint}]已断开连接！");
                    //断开连接则取消事件的绑定
                    this.quickMsgAdded -= clientPage.OnQuickMsgAdded;
                    //移除 <string, ClientStruct> 对
                    clientMapper.TryRemove(clientStruct.ClientName, out clientStruct);
                    //客户端列表移除断开连接的客户端名称
                    clientsList.Remove(clientStruct.ClientName);
                    //移除该客户端的选项卡页面
                    this.Invoke(new Action(() => { tabControl.TabPages.RemoveByKey(clientStruct.ClientName); }));
                    ///针对 <see cref="ClientPage.ReceiveUntilDisconnect"/> 异常情况导致的接收消息的线程退出（不一定是连接异常），统一认为双方不再适合通信，故服务端主动关闭连接
                    clientStruct.Socket.Shutdown(SocketShutdown.Both);
                    clientStruct.Socket.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"连接后出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 当有客户端连接到服务端时，新增一个选项卡方法
        /// </summary>
        /// <param name="clientStruct"><see cref="ClientStruct"/> 实例</param>
        /// <returns>新增的选项卡 <see cref="ClientPage"/> 对象</returns>
        private ClientPage AddTabPage(ClientStruct clientStruct)
        {
            TabPage tabPage = new TabPage(clientStruct.ClientName)      //创建一个新的 TabPage 对象
            {
                //控件名称用于标识 TabPage 实例，当我们调用 TabControl.TabPages.RemoveByKey(string key) 方法时可以传递该控件名称以表明要移除哪个 TabPage
                Name = clientStruct.ClientName
            };
            ClientPage clientPage = new ClientPage(clientStruct);       //创建一个新的 ClientPage 对象
            clientPage.TopLevel = false;                                //设置为非顶层窗体
            this.Invoke(new Action(() =>
            {
                tabPage.Controls.Add(clientPage);                           //将 ClientPage 对象添加到 TabPage 对象的 Controls 集合中
                clientPage.Dock = DockStyle.Fill;                           //设置 ClientPage 的 Dock 属性为 Fill
                clientPage.Show();                                          //显示窗体
                tabControl.TabPages.Add(tabPage);                           //为 TabControl 添加新的选项卡
            }));
            return clientPage;
        }

        private void TCPServer_Load(object sender, EventArgs e)
        {
            maskedTextBox_hostIP.ValidatingType = typeof(System.Net.IPAddress);
            maskedTextBox_hostPort.ValidatingType = typeof(int);
            hostIP = System.Net.IPAddress.Parse(hostIPStr);
            hostProt = 54600;
            this.listBox_clients.DataSource = clientsList;
            if (File.Exists("QuickMessage.json"))
            {
                foreach(var str in File.ReadAllLines("QuickMessage.json"))
                {
                    quickMsgs.Add(JsonSerializer.Deserialize<QuickMsg>(str));
                    comboBox_quickMsg.Items.Add(quickMsgs.Last().Name);
                }
            }
        }

        private void maskedTextBox_port_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(maskedTextBox_hostPort.Text, out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("端口号必须在 1~65535 之间！");
                maskedTextBox_hostPort.SelectAll();
                e.Cancel = true;
            }
            else hostProt = port;
        }

        private void maskedTextBox_hostIP_Validating(object sender, CancelEventArgs e)
        {
            hostIPStr =  maskedTextBox_hostIP.Text.Replace(" ","");
            if (!System.Net.IPAddress.TryParse(hostIPStr, out hostIP))
            {
                MessageBox.Show("您需要输入有效的服务端 IP 地址！");
                maskedTextBox_hostIP.SelectAll();
                e.Cancel = true;
            }
        }

        private void btn_startListen_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadStart tcpListenDelegate = new ThreadStart(TcpListen);     //创建一个委托并将监听方法绑定到委托
                Thread delegateThread = new Thread(tcpListenDelegate);          //使用委托创建托管线程
                delegateThread.Start();                                         //执行托管线程
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在创建监听托管线程时出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 将日志消息打印到首页日志栏
        /// </summary>
        /// <param name="logMsg">要打印的消息</param>
        private void PrintLog(string logMsg)
        {
            /**
             * 通过 Invoke() 方法执行特定委托以避免“线程间操作无效”，请参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-8.0>
             * 有关 Action() 强类型委托的相关内容，请参考：<https://learn.microsoft.com/zh-cn/dotnet/csharp/delegates-strongly-typed>，
             * 有关 Lambda 表达式语法，请参考：<https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/lambda-expressions>
             */
            this.Invoke(new Action(() =>
            {
                //获取句柄再向下继续执行，以确保对象还未实例化时调用该方法不会出现问题（通常异常信息为：“未将对象引用设置到对象的实例”）
                IntPtr handlePtr = this.Handle;
                richTextBox_logBox.AppendText($"[{DateTime.Now}] {logMsg}{Environment.NewLine}");     //将消息附加到消息窗口
            }));
        }

        /// <summary>
        /// 将消息打印到首页消息栏
        /// </summary>
        /// <param name="msg">要打印的消息</param>
        private void PrintMsg(string msg)
        {
            /**
             * 通过 Invoke() 方法执行特定委托以避免“线程间操作无效”，请参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-8.0>
             * 有关 Action() 强类型委托的相关内容，请参考：<https://learn.microsoft.com/zh-cn/dotnet/csharp/delegates-strongly-typed>，
             * 有关 Lambda 表达式语法，请参考：<https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/lambda-expressions>
             */
            this.Invoke(new Action(() =>
            {
                //获取句柄再向下继续执行，以确保对象还未实例化时调用该方法不会出现问题（通常异常信息为：“未将对象引用设置到对象的实例”）
                IntPtr handlePtr = this.Handle;
                richTextBox_msgBox.AppendText($"[{DateTime.Now}] {msg}{Environment.NewLine}");     //将消息附加到消息窗口
            }));
        }

        private void btn_broadcastMsg_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = richTextBox_msgEditBox.Text;
                if (!msg.Any()) return;
                if (!clientMapper.Any()) MessageBox.Show("当前无任何客户端已连接", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var value in clientMapper.Values)
                {
                    var buffer = DataProcessing.EncodeUsingSpecificCodecPattern(msg, value.Codec);
                    if (value.Socket.Send(buffer) == buffer.Length)
                        PrintMsg($"向客户端[{value.Socket.RemoteEndPoint}]发送消息：{msg}");
                }
                this.Invoke(new Action(() =>
                {
                    richTextBox_msgEditBox.Clear();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在广播发送消息的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clearMsg_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                richTextBox_msgBox.Clear();
            }));
        }

        private void btn_addQuickMsg_MouseEnter(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                btn_addQuickMsg.Image = Properties.Resources._3_Add_DarkColor;
            }));
        }

        private void btn_addQuickMsg_MouseLeave(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                btn_addQuickMsg.Image = Properties.Resources._3_Add;
            }));
        }

        private void btn_addQuickMsg_Click(object sender, EventArgs e)
        {
            QuickMsg quickMsg = new QuickMsg();
            //获取用户添加的快捷消息
            this.Invoke((Action)(() => { quickMsg = QuickMsgConfiguration.GetQuickMsg(this); }));
            if (quickMsg != null)
            {
                quickMsgs.Add(quickMsg);
                comboBox_quickMsg.Items.Add(quickMsg.Name);
                Task.Run(new Action(() => RaiseQuickMsgAdded(quickMsg.Name)));
            }
        }

        private void comboBox_quickMsg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //消息编辑栏显示当前所选择的快捷消息的消息内容
            this.Invoke(new Action(() => { richTextBox_msgEditBox.Text = quickMsgs[comboBox_quickMsg.SelectedIndex].Message; }));
        }
    }
}

/**
 * 参考链接：
 *      <https://stackoverflow.com/questions/36059076/send-packet-from-server-to-a-specific-client-using-tcp-c-sharp>
 *      ListBox 项改变时触发事件方法：<https://stackoverflow.com/questions/7860467/events-for-adding-removing-items-in-a-listbox-c-net>
 *      MSDN Socket 参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.net.sockets?view=net-8.0>
 *      IP 地址输入控件的 TextBox 实现：<https://stackoverflow.com/questions/60765586/three-dots-in-textbox?noredirect=1&lq=1>
 *      IP 地址输入控件的 MaskedTextBox 实现：<https://stackoverflow.com/questions/7924000/ip-address-in-a-maskedtextbox>
 *      IP 地址输入控件的三方实现：<https://stackoverflow.com/questions/884857/need-a-net-winforms-ip-address-control>
 */
