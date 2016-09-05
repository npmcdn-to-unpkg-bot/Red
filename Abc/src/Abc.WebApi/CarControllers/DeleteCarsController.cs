using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.VersionAndMethod;

namespace Abc.WebApi.CarControllers
{
    public class DeleteCarsController : ApiController
    {
        [HttpDelete]
        [DeleteCarsRoute(1)]
        public IHttpActionResult DeleteCars()
        {
            CarPersistence.Cars.Clear();

            return Ok();
        }
    }
}