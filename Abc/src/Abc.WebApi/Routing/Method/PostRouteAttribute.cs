using System.Net.Http;

namespace Abc.WebApi.Routing.Method
{
    public class PostRouteAttribute : RouteAttribute
    {
        public PostRouteAttribute(string template) : base(template, HttpMethod.Post) { }
    }
}