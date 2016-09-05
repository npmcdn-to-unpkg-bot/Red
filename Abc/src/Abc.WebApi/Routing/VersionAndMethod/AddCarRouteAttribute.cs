using System.Net.Http;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class AddCarRouteAttribute : RouteAttribute
    {
        public AddCarRouteAttribute(int version) : base("cars/{registrationNumber}", HttpMethod.Put, version)
        {
        }
    }
}