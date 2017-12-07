# Demo.ServiceStack
C# 调用方式:
需要引用命名空间:
        using ServiceStack;
       class Program
    {
        static void Main(string[] args)
        { 
            JsonServiceClient jsonclient = new JsonServiceClient("http://localhost:65022/");
            var result = jsonclient.Send<DefaultResponse>(new GetProductInfo() { ProductCode="孙强" });
            Debug.Write(message: JsonSerializer.SerializeToString(result));
            Console.ReadKey();

        }
        public class GetProductInfo
        {
            public string ProductCode { get; set; }
        }

    }

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
