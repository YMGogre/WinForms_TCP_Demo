using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class QuickMsgConfiguration : Form
    {
        private static string s_name;
        private static string s_message;

        public QuickMsgConfiguration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取快捷消息 <see cref="QuickMsg"/> 实例（包含快捷消息名称与快捷消息内容）
        /// </summary>
        /// <remarks>该方法会打开一个模式对话框，您需要指定该模式对话框所属的顶级窗口</remarks>
        /// <param name="owner">任何实现 <see cref="IWin32Window"/> (表示将拥有模式对话框的顶级窗口) 的对象</param>
        /// <returns><see cref="QuickMsg"/> 实例，如果取消/关闭了对话框，则返回 <see langword="null"/></returns>
        public static QuickMsg GetQuickMsg(IWin32Window owner)
        {
            var qmc = new QuickMsgConfiguration();
            if(qmc.ShowDialog(owner) == DialogResult.OK)
            {
                return new QuickMsg(s_name, s_message);
            }
            else return null;
        }

        private void watermarkTextBox_name_TextChanged(object sender, EventArgs e)
        {
            if(watermarkTextBox_name.Text.Any())
            {
                btn_OK.Enabled = true;
            }
            else { btn_OK.Enabled = false; }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            s_name = watermarkTextBox_name.Text;
            s_message = richTextBox_message.Text.Replace("\n","");
            using(StreamWriter streamWriter = File.AppendText("QuickMessage.json"))
            {
                Model.QuickMsg quickMsg = new Model.QuickMsg(s_name, s_message);
                streamWriter.WriteLine(quickMsg);
            }
            //参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.form.dialogresult?view=windowsdesktop-7.0#-->
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //参考：<https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.form.dialogresult?view=windowsdesktop-7.0#-->
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
