﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace TCPClient
{
    public partial class TCPClient : Form
    {
        string hostIPStr = "127.0.0.1";
        IPAddress hostIP;
        int hostProt;
        private Socket _clientSocket;
        /// <summary>
        /// 接收消息的线程
        /// </summary>
        private Thread _receiveThread;
        /// <summary>
        /// 使用一个布尔成员变量监视当前的连接状态(默认未连接)
        /// </summary>
        private bool _isConnected = false;
        /// <summary>
        /// 当前连接状态属性
        /// </summary>
        bool IsConnected
        {
            get { return _isConnected; }
            set { _isConnected = value; UpdateUI(); }
        }
        /// <summary>
        /// 当前的编解码方式，参考 <see cref="Model.Codec"/>
        /// </summary>
        Codec Codec { get; set; }
        /// <summary>
        /// 使用一个动态数组保存快捷消息
        /// </summary>
        public static readonly List<QuickMsg> quickMsgs = new List<QuickMsg>();

        public TCPClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 连接到主机并在一个新的线程上开始循环从主机接收消息
        /// </summary>
        internal async void ConnectHost()
        {
            try
            {
                //实例化连接套接字
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //连接远程主机
                await _clientSocket.ConnectAsync(hostIP, hostProt);
                //打印连接成功消息
                PrintMsg($"成功连接至主机[{hostIP}:{hostProt}]");
                IsConnected = true;
                //在新的线程上循环接收消息
                ThreadStart threadStart = new ThreadStart(ReceiveUntilDisconnect);
                _receiveThread = new Thread(threadStart);
                _receiveThread.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"尝试连接至服务端出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 这是一个同步方法，调用该方法后当前线程会陷入死循环，以此不断地从服务端接收消息。直至主动断开连接退出或者出现异常
        /// </summary>
        internal void ReceiveUntilDisconnect()
        {
            try
            {
                //创建一个 64KB 的接收数据缓冲区
                byte[] receiveBuffer = new byte[65536];
                while (IsConnected)
                {
                    Thread.Sleep(150);
                    var dataLength = _clientSocket.Receive(receiveBuffer);
                    if (dataLength > 0)
                    {
                        var receivedStr = DataProcessing.DecodeUsingSpecificCodecPattern(receiveBuffer, dataLength, Codec);
                        PrintMsg($"收到来自服务端[{_clientSocket.RemoteEndPoint}]的消息：{receivedStr}");
                    }
                }
            }
            /// <see cref="ThreadAbortException"/> 异常是由关闭连接的线程调用了该线程的 <see cref="Thread.Abort()"/> 方法引发，既然连接都关闭了，那我们处理该异常的时候直接退出方法即可
            catch (ThreadAbortException) { return; }
            catch (Exception ex)
            {
                MessageBox.Show($"在从服务端接收消息的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //出现其他任何异常情况时，都直接关闭连接
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
               IsConnected = false;
            }
        }

        private void TCPClient_Load(object sender, EventArgs e)
        {
            maskedTextBox_hostIP.ValidatingType = typeof(System.Net.IPAddress);
            maskedTextBox_hostPort.ValidatingType = typeof(int);
            hostIP = System.Net.IPAddress.Parse(hostIPStr);
            hostProt = 54600;
            comboBox_codec.SelectedIndex = 0;
            if (File.Exists("QuickMessage.json"))
            {
                foreach (var str in File.ReadAllLines("QuickMessage.json"))
                {
                    quickMsgs.Add(JsonSerializer.Deserialize<QuickMsg>(str));
                    comboBox_quickMsg.Items.Add(quickMsgs.Last().Name);
                }
            }
        }

        private void maskedTextBox_hostIP_Validating(object sender, CancelEventArgs e)
        {
            hostIPStr = maskedTextBox_hostIP.Text.Replace(" ", "");
            if (!System.Net.IPAddress.TryParse(hostIPStr, out hostIP))
            {
                MessageBox.Show("您需要输入有效的服务端 IP 地址！");
                maskedTextBox_hostIP.SelectAll();
                e.Cancel = true;
            }
        }

        private void maskedTextBox_hostPort_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(maskedTextBox_hostPort.Text, out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("端口号必须在 1~65535 之间！");
                maskedTextBox_hostPort.SelectAll();
                e.Cancel = true;
            }
            else hostProt = port;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectHost();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
                _receiveThread.Abort();
                IsConnected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在从服务端断开连接的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally { 
            //}
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
            }
        }

        private void comboBox_quickMsg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //消息编辑栏显示当前所选择的快捷消息的消息内容
            this.Invoke(new Action(() => { richTextBox_msgEditBox.Text = quickMsgs[comboBox_quickMsg.SelectedIndex].Message; }));
        }

        private void comboBox_codec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //每当用户通过下拉框选择了项，更新当前的编解码方式
            this.Invoke(new Action(() => { Codec = (Codec)comboBox_codec.SelectedIndex; }));
        }

        private void btn_sendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = richTextBox_msgEditBox.Text;
                if (!msg.Any() || !IsConnected) return;
                var buffer = DataProcessing.EncodeUsingSpecificCodecPattern(msg, Codec);
                if (_clientSocket.Send(buffer) == buffer.Length)
                    PrintMsg($"向服务端[{_clientSocket.RemoteEndPoint}]发送消息：{msg}");
                if (tsmi_clearEditBoxAfterSend.Checked)
                {
                    this.Invoke(new Action(() => { richTextBox_msgEditBox.Clear(); }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在向服务端发送消息的过程中出现异常：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clearMsg_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => { richTextBox_msgBox.Clear(); }));
        }

        /// <summary>
        /// 根据连接状态更新 UI 界面方法
        /// </summary>
        private void UpdateUI()
        {
            this.Invoke(new Action(() =>
            {
                btn_connect.Enabled = !IsConnected;
                comboBox_codec.Enabled = !IsConnected;
                btn_disconnect.Enabled = IsConnected;
            }));
        }

        private void btn_openCurrDir_MouseEnter(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                btn_openCurrDir.Image = Properties.Resources._4_folder_DarkColor;
            }));
        }

        private void btn_openCurrDir_MouseLeave(object sender, EventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                btn_openCurrDir.Image = Properties.Resources._4_folder;
            }));
        }

        private void btn_openCurrDir_Click(object sender, EventArgs e)
        {
            var currentDirectory = Environment.CurrentDirectory;
            try
            {
                Process.Start("explorer.exe", currentDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开文件资源管理器：\n\t{ex.Message}\n调用堆栈：\n\t{ex.StackTrace}", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox_msgBox_TextChanged(object sender, EventArgs e)
        {
            if(tsmi_scrollToCaret.Checked)
                richTextBox_msgBox.ScrollToCaret();        
        }
    }
}