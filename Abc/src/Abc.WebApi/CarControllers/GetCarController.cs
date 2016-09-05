using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.VersionAndMethod;

namespace Abc.WebApi.CarControllers
{
    public class GetCarController : ApiController
    {
        [HttpGet]
        [GetCarRoute(1, Name = "GetCar")]
        public IHttpActionResult GetCar([FromUri] string registrationNumber)
        {
            return Ok(CarPersistence.Cars[registrationNumber]);
        }
    }
}