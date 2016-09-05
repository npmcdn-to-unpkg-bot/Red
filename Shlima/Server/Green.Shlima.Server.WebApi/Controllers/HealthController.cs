using System.Web.Http;

namespace Green.Shlima.Server.WebApi.Controllers
{
    public class HealthController : ApiController
    {
        [Route("health")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("OK!");
        }
    }
}
