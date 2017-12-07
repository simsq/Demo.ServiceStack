using ServiceStack;
using Demo.ServiceStack.ServiceModel;

namespace Demo.ServiceStack.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Any(GetProductInfo demoPeoduct)
        {
            return new DefaultResponse() { RequestToken = demoPeoduct.Token, Message = "调用成功", Result = new Result() { ProductCode = demoPeoduct.ProductCode }, Sucess = true };
        }
        
    }
}