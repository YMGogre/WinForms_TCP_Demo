using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace TCPServer
{
    public partial class CommunicationConfiguration : Form
    {
        private static int s_clientCount = 0;
        private static string s_clientName;
        private static Codec s_codec;
        public CommunicationConfiguration()
        {
            InitializeComponent();
            s_clientCount++;
            s_clientName = s_clientCount.ToString() + "-";
            s_codec = Codec.none;
            this.comboBox_clientCodec.SelectedIndex = 0;
        }

        /// <summary>
        /// 有关构造函数链的使用请参考 <see href="https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/using-constructors">MSDN</see>
        /// </summary>
        /// <param name="socket">用于与远程主机通信的 <see cref="System.Net.Sockets.Socket"/></param>
        public CommunicationConfiguration(System.Net.Sockets.Socket socket) : this()
        {
            var remote = socket.RemoteEndPoint as IPEndPoint;
            this.label_clientIP.Text = remote.Address.ToString();
            this.label_clientPort.Text = remote.Port.ToString();
        }

        /// <summary>
        /// 获取 TCP 客户端结构体（包含用于与远程主机通信的 <see cref="System.Net.Sockets.Socket"/> 实例、由用户命名的客户端名称以及数据包的打/解包方式信息）
        /// </summary>
        /// <remarks>该方法会打开一个模式对话框，您需要指定该模式对话框所属的顶级窗口</remarks>
        /// <param name="socket">用于与远程主机通信的 <see cref="System.Net.Sockets.Socket"/></param>
        /// <param name="owner">任何实现 <see cref="IWin32Window"/> (表示将拥有模式对话框的顶级窗口) 的对象</param>
        /// <returns><see cref="ClientStruct"/> 实例</returns>
        internal static ClientStruct GetClientStruct(System.Net.Sockets.Socket socket, IWin32Window owner)
        {
            CommunicationConfiguration cc = new CommunicationConfiguration(socket);
            if (cc.ShowDialog(owner) == DialogResult.OK)
            {
                ClientStruct @struct = new ClientStruct(socket, s_clientName, s_codec);
                return @struct;
            }
            else
                return new ClientStruct(socket, s_clientName, s_codec);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            s_clientName += textBox_clientName.Text;
            s_codec = (Codec)comboBox_clientCodec.SelectedIndex;
            //参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.form.dialogresult?view=windowsdesktop-7.0#-->
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.form.dialogresult?view=windowsdesktop-7.0#-->
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox_clientName_TextChanged(object sender, EventArgs e)
        {
            if(textBox_clientName.Text.Any())
                btn_OK.Enabled = true;
            else
                btn_OK.Enabled = false;
        }
    }
}
