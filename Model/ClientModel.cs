using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClientModel
    {
    }

    public enum Codec
    {
        /// <summary>
        /// 默认编解码方式（数据包只有通信数据，采用 UTF-8 格式编解码字符串）
        /// </summary>
        none,
        /// <summary>
        /// 数据包包含一个 4 字节包头，用于存储包体的字节数
        /// </summary>
        lengthPacketHeader,
    }

    public struct ClientStruct
    {
        public System.Net.Sockets.Socket Socket { get; }
        public string ClientName { get; }
        public Codec Codec { get; }

        public ClientStruct(System.Net.Sockets.Socket socket, string clientName, Codec codec)
        {
            Socket = socket;
            ClientName = clientName;
            Codec = codec;
        }
    }
}
