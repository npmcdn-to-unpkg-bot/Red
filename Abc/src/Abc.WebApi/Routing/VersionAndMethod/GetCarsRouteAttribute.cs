using System.Net.Http;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class GetCarsRouteAttribute : RouteAttribute
    {
        public GetCarsRouteAttribute(int version) : base("cars", HttpMethod.Get, version)
        {
        }
    }
}