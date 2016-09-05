using System.Net.Http;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class GetCarRouteAttribute : RouteAttribute
    {
        public GetCarRouteAttribute(int version) : base("cars/{registrationNumber}", HttpMethod.Get, version)
        {
        }
    }
}