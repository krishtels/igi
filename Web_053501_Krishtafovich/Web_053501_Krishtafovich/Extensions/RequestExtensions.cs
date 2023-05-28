using Microsoft.AspNetCore.Http;

namespace Web_053501_Krishtafovich.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request.Headers["x-requested-with"].Equals("XMLHttpRequest");
        }
    }

}
