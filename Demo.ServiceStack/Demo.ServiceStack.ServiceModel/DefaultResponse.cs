namespace Demo.ServiceStack.ServiceModel
{
    /// <summary>
    /// 默认返回结果
    /// </summary>
    public class DefaultResponse
    {
        /// <summary>
        /// 调用成功或者失败
        /// true:成功
        /// false:失败
        /// </summary>
        public bool Sucess { get; set; }

        /// <summary>
        /// 返回具体的结果
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string Message { get; set; }

        public string RequestToken { get; set; }
    }

    public class Result
    {
        public string ProductCode { get; set; }
      
    }
}
