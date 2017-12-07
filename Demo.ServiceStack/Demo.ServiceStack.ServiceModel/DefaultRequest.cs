using ServiceStack;
using System;

namespace Demo.ServiceStack.ServiceModel
{
    /// <summary>
    /// 请求鸡肋
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultRequest<T> : IReturn<T>
    {
        public DefaultRequest()
        {
            Token = Guid.NewGuid().ToString("D");
        }

        /// <summary>
        /// 签名
        /// </summary>
        public string Token { get; set; }
    }
}
