using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class DataProcessing
    {
        /// <summary>
        /// 将字节数组的前 <paramref name="validLength"/> 个字节按照指定的 <see cref="Codec"/> 模式进行解码获取字符串
        /// </summary>
        /// <param name="buffer">数据字节数组</param>
        /// <param name="validLength">有效数据字节数</param>
        /// <param name="codec">编解码器</param>
        /// <returns>解码后得到的字符串</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="codec"/> 提供的值不在 <see cref="Codec"/> 枚举范围内时抛出该异常</exception>
        /// <exception cref="CodecException">其他解码过程中出现的异常都会包装为 <see cref="CodecException"/> 再向上抛出，你可以通过 <see cref="CodecException.InnerException"/> 获取内部异常对象</exception>
        public static string DecodeUsingSpecificCodecPattern(byte[] buffer, int validLength, Codec codec)
        {
            string msg;
            switch (codec)
            {
                case Codec.none:
                    try { msg = Encoding.UTF8.GetString(buffer, 0, validLength); }
                    catch (Exception ex) { throw new CodecException($"在 Codec 为 none 时解码出现异常\n内部异常[{ex.GetType().Name}]信息：\n{ex.Message}", ex); }
                    break;
                case Codec.lengthPacketHeader:
                    try
                    {
                        var length = BitConverter.ToInt32(buffer, 0);
                        var data = new byte[length];
                        if (length == validLength - 4)
                        {
                            Array.ConstrainedCopy(buffer, 4, data, 0, length);
                            msg = System.Text.Encoding.UTF8.GetString(data);
                        }
                        else throw new ArgumentException("包体长度与包头标识的长度不一致");
                    }
                    catch (Exception ex)
                    {
                        throw new CodecException($"在 Codec 为 lengthPacketHeader 时解码出现异常\n内部异常[{ex.GetType().Name}]信息：\n{ex.Message}", ex);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(codec), "解码时提供的编解码器参数无效");
            }
            return msg;
        }

        /// <summary>
        /// 将字符串按照指定的 <see cref="Codec"/> 模式进行编码获取字节数组
        /// </summary>
        /// <param name="msg">要编码的字符串</param>
        /// <param name="codec">编解码器</param>
        /// <returns>编码后得到的字节数组</returns>
        /// <exception cref="CodecException">其他编码过程中出现的异常都会包装为 <see cref="CodecException"/> 再向上抛出，你可以通过 <see cref="CodecException.InnerException"/> 获取内部异常对象</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="codec"/> 提供的值不在 <see cref="Codec"/> 枚举范围内时抛出该异常</exception>
        public static byte[] EncodeUsingSpecificCodecPattern(string msg, Codec codec)
        {
            byte[] buffer;
            switch(codec)
            {
                case Codec.none:
                    try { buffer = Encoding.UTF8.GetBytes(msg); }
                    catch(Exception ex) { throw new CodecException($"在 Codec 为 none 时编码出现异常\n内部异常[{ex.GetType().Name}]信息：\n{ex.Message}", ex); }
                    break;
                case Codec.lengthPacketHeader:
                    try
                    {
                        var body = Encoding.UTF8.GetBytes(msg);
                        var header = BitConverter.GetBytes(body.Length);
                        buffer = header.Concat(body).ToArray();
                    }
                    catch (Exception ex)
                    {
                        throw new CodecException($"在 Codec 为 lengthPacketHeader 时编码出现异常\n内部异常[{ex.GetType().Name}]信息：\n{ex.Message}", ex);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(codec), "编码时提供的编解码器参数无效");
            }
            return buffer;
        }
    }
}
