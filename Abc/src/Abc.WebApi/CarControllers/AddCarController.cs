using System.Collections.Generic;
using System.Web.Http;
using Abc.WebApi.Models;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.VersionAndMethod;

namespace Abc.WebApi.CarControllers
{
    public class AddCarController : ApiController
    {
        [HttpPut]
        [AddCarRoute(1)]
        public IHttpActionResult AddCar([FromUri] string registrationNumber, [FromBody] CarModel car)
        {
            CarPersistence.Cars.Add(registrationNumber, car);

            return CreatedAtRoute("GetCar", new Dictionary<string, object> { { "registrationNumber", registrationNumber } }, car);
        }
    }
}