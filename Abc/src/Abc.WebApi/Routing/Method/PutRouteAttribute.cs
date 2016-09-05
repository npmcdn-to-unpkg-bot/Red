using System.Net.Http;

namespace Abc.WebApi.Routing.Method
{
    public class PutRouteAttribute : RouteAttribute
    {
        public PutRouteAttribute(string template) : base(template, HttpMethod.Put) { }
    }
}