using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Abc.WebApi.Routing.Method
{
    public class RouteConstraint : IHttpRouteConstraint
    {
        private readonly HttpMethod _method;

        public RouteConstraint(HttpMethod method)
        {
            _method = method;
        }

        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            if (routeDirection == HttpRouteDirection.UriResolution)
            {
                return request.Method == _method;
            }
            return true;
        }
    }
}
