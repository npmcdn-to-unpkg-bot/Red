using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public abstract class RouteAttribute : RouteFactoryAttribute
    {
        private readonly HttpMethod _method;

        private readonly int _version;

        protected RouteAttribute(string template, HttpMethod method, int version) 
            : base(template)
        {
            _method = method;
            _version = version;
        }

        public override IDictionary<string, object> Constraints => new HttpRouteValueDictionary
        {
            {
                "version", new RouteConstraint(_method, _version)
            }
        };
    }
}