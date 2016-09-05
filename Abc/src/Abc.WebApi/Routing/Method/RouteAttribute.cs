using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Abc.WebApi.Routing.Method
{
    public abstract class RouteAttribute : RouteFactoryAttribute
    {
        private readonly HttpMethod _method;

        protected RouteAttribute(string template, HttpMethod method)
            : base(template)
        {
            _method = method;
        }


        public override IDictionary<string, object> Constraints => new HttpRouteValueDictionary
        {
            {
                "method", new RouteConstraint(_method)
            }
        };
    }
}
