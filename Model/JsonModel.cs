using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    internal class JsonModel
    {
    }

    public class QuickMsg
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public QuickMsg() { }
        /// <summary>
        /// 使用指定的名称和消息内容实例化 <see cref="QuickMsg"/>
        /// </summary>
        /// <param name="name">快捷消息的名称</param>
        /// <param name="message">快捷消息内容</param>
        public QuickMsg(string name, string message)
        {
            Name = name;
            Message = message;
        }

        /// <summary>
        /// 重写 <see cref="object.ToString"/> 方法
        /// </summary>
        /// <returns>该对象序列化后的 Json 字符串</returns>
        public override string ToString()
        {
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }; 
            return JsonSerializer.Serialize(this, options);
        }
    }
}
