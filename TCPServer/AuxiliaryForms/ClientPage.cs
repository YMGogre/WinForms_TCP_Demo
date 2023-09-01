using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace TCPServer
{
    public partial class ClientPage : Form
    {
        private readonly ClientStruct _clientStruct;
        public ClientStruct ClientStruct { get { return _clientStruct; } }
        public ClientPage(ClientStruct clientStruct)
        {
            InitializeComponent();
            _clientStruct = clientStruct;
        }

        /// <summary>
        /// 这是一个同步方法，调用该方法后当前线程会陷入死循环，以此不断地从特定的客户端（<see cref="ClientStruct"/>）接收消息。直至客户端主动断开连接退出或者出现异常
        /// </summary>
        internal void ReceiveUntilDisconnect()
        {
            try
            {
                //创建一个 64KB 的接收数据缓冲区
                byte[] receiveBuffer = new byte[65536];
                while (true)
                {
                    Thread.Sleep(150);
                    var dataLength = _clientStruct.Socket.Receive(receiveBuffer);
                    if (dataLength > 0)
                    {
                        var receivedStr = DataProcessing.DecodeUsingSpecificCodecPattern(receiveBuffer, dataLength, _clientStruct.Codec);
                        PrintMsg($"收到来自[{_clientStruct.Socket.RemoteEndPoint}]的消息：{receivedStr}");
                    }
                    //当客户端主动断开连接时，还会发送一个长度为 0 的消息，我们可以依据此判断客户端已主动断开连接
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在从客户端[{_clientStruct.Socket.RemoteEndPoint}]接收消息的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 将消息打印到消息栏
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

        private void btn_sendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = richTextBox_msgEditBox.Text;
                if (!msg.Any()) return;
                var buffer = DataProcessing.EncodeUsingSpecificCodecPattern(msg, _clientStruct.Codec);
                if (_clientStruct.Socket.Send(buffer) == buffer.Length)
                    PrintMsg($"向客户端[{_clientStruct.Socket.RemoteEndPoint}]发送消息：{msg}");
                this.Invoke(new Action(() =>
                {
                    richTextBox_msgEditBox.Clear();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在向客户端[{_clientStruct.Socket.RemoteEndPoint}]发送消息的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void OnQuickMsgAdded(object sender, QuickMsgAddedEventArgs e)
        {
            this.Invoke(new Action(() => { comboBox_quickMsg.Items.Add(e.QuickMsgName); }));
        }

        private void comboBox_quickMsg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //消息编辑栏显示当前所选择的快捷消息的消息内容
            this.Invoke(new Action(() => { richTextBox_msgEditBox.Text = TCPServer.quickMsgs[comboBox_quickMsg.SelectedIndex].Message; }));
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            foreach(var quickMsg in TCPServer.quickMsgs)
                comboBox_quickMsg.Items.Add(quickMsg.Name);
            this.Invoke(new Action(() =>
            {
                label_clientName.Text = _clientStruct.ClientName;
                label_clientIP.Text = ((IPEndPoint)_clientStruct.Socket.RemoteEndPoint).Address.ToString();
                label_clientPort.Text = ((IPEndPoint)_clientStruct.Socket.RemoteEndPoint).Port.ToString();
            }));
        }
    }
}
