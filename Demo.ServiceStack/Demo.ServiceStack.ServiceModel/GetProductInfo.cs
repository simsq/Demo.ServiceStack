using ServiceStack;

namespace Demo.ServiceStack.ServiceModel
{
    [Route("/GetProductInfo")]
    public class GetProductInfo : DefaultRequest<DefaultResponse>
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProductCode { get; set; }
    }

}
