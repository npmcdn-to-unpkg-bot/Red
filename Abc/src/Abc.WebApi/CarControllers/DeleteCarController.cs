using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.VersionAndMethod;

namespace Abc.WebApi.CarControllers
{
    public class DeleteCarController : ApiController
    {
        [HttpDelete]
        [DeleteCarRoute(1)]
        public IHttpActionResult DeleteCar([FromUri] string registrationNumber)
        {
            CarPersistence.Cars.Remove(registrationNumber);

            return Ok();
        }
    }
}