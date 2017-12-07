# Demo.ServiceStack
C# 调用方式:
需要引用命名空间:using ServiceStack;
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
