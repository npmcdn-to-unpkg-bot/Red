using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Abc.TestClient
{
    public class DoController : ApiController
    {
        [Route("do")]
        [HttpGet]
        public async Task<IHttpActionResult> Do()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");

                HttpResponseMessage response = await client.GetAsync("authorise");

                if (!response.IsSuccessStatusCode)
                    return BadRequest();

                return Ok();
            }
        }
    }
}