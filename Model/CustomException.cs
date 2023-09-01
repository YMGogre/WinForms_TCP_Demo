using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CodecException : Exception
    {
        /// <summary>
        /// 初始化 <see cref="CodecException"/> 类的新实例
        /// </summary>
        public CodecException() : base("默认编/解码异常") { }

        /// <summary>
        /// 用指定的错误消息初始化 <see cref="CodecException"/> 类的新实例
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        public CodecException(string message) : base(message) { }

        /// <summary>
        /// 使用指定的错误消息和对作为此异常原因的内部异常的引用来初始化 <see cref="CodecException"/> 类的新实例
        /// </summary>
        /// <param name="message">解释异常原因的错误消息</param>
        /// <param name="innerException">导致当前异常的异常。如果 <paramref name="innerException"/> 参数不是 <see langword="null"/> 引用，则在处理内部异常的 <c>catch</c> 块中引发当前异常</param>
        public CodecException(string message, Exception innerException) : base(message, innerException) { }
    }
}
