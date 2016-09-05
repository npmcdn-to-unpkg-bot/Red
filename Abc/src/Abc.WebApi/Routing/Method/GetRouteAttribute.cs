using System.Net.Http;

namespace Abc.WebApi.Routing.Method
{
    public class GetRouteAttribute : RouteAttribute
    {
        public GetRouteAttribute(string template) : base(template, HttpMethod.Get) { }
    }
}