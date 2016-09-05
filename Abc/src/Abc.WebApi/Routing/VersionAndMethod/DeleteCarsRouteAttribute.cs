using System.Net.Http;

namespace Abc.WebApi.Routing.VersionAndMethod
{
    public class DeleteCarsRouteAttribute : RouteAttribute
    {
        public DeleteCarsRouteAttribute(int version) : base("cars", HttpMethod.Delete, version)
        {
        }
    }
}