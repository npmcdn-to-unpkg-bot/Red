using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class RouteConstraint : IHttpRouteConstraint
    {
        private const int DefaultVersion = 1;

        private readonly HttpMethod _method;

        private readonly int _version;

        public RouteConstraint(HttpMethod method, int version)
        {
            _method = method;
            _version = version;
        }

        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            if (routeDirection == HttpRouteDirection.UriResolution)
            {
                int version = GetVersionFromHeader(request, parameterName) ?? DefaultVersion;
                return request.Method == _method && version == _version;
            }
            return true;
        }

        private int? GetVersionFromHeader(HttpRequestMessage request, string parameterName)
        {
            var httpHeaderValueCollection = request.Headers.Accept;
            foreach (var mediaTypeWithQualityHeaderValue in httpHeaderValueCollection)
            {
                if (mediaTypeWithQualityHeaderValue.MediaType == "application/json")
                {
                    var nameValueHeaderValue = mediaTypeWithQualityHeaderValue.Parameters.FirstOrDefault(v => v.Name.Equals(parameterName, StringComparison.OrdinalIgnoreCase));
                    if (nameValueHeaderValue != null)
                    {
                        int parsedVersion;
                        if (int.TryParse(nameValueHeaderValue.Value, out parsedVersion))
                            return parsedVersion;
                    }
                    return null;
                }
            }
            return null;
        }
    }
}
