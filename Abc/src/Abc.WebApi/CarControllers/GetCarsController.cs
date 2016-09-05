using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.VersionAndMethod;

namespace Abc.WebApi.CarControllers
{
    public class GetCarsController : ApiController
    {
        [HttpGet]
        [GetCarsRoute(1)]
        public IHttpActionResult GetCars()
        {
            return Ok(CarPersistence.Cars);
        }
    }
}