using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class CustomEventArgs
    {
    }

    /// <summary>
    /// "添加了快捷消息"事件参数
    /// </summary>
    public class QuickMsgAddedEventArgs : EventArgs
    {
        public string QuickMsgName { get; }
        /// <summary>
        /// 使用指定的快捷消息名实例化 <see cref="QuickMsgAddedEventArgs"/> 事件参数
        /// </summary>
        /// <param name="quickMsgName">快捷消息名</param>
        public QuickMsgAddedEventArgs(string quickMsgName) 
        {
            QuickMsgName = quickMsgName;
        }
    }
}
