using System.Net.Http;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class DeleteCarRouteAttribute : RouteAttribute
    {
        public DeleteCarRouteAttribute(int version) : base("cars/{registrationNumber}", HttpMethod.Delete, version)
        {
        }
    }
}