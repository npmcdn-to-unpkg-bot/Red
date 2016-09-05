using System.Net.Http;

namespace Abc.WebApi.Routing.Method
{
    public class DeleteRouteAttribute : RouteAttribute
    {
        public DeleteRouteAttribute(string template) : base(template, HttpMethod.Delete) { }
    }
}