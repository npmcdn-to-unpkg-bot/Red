using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BareBonesWebApi.WebApi
{
    public class StatusController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("OK!");
        }

        private static readonly Dictionary<Guid, string> Dependencies = new Dictionary<Guid, string>();

        [Route("dependencies/{name}")]
        [HttpPost]
        public IHttpActionResult Add(string name)
        {
            var id = Guid.NewGuid();
            Dependencies.Add(id, name);
            return Ok(id);
        }

        [Route("dependencies/{id}/{name}")]
        [HttpPut]
        public IHttpActionResult Update(Guid id, string name)
        {
            Dependencies.Remove(id);
            Dependencies.Add(id, name);
            return Ok();
        }

        [Route("dependencies/{id}")]
        [HttpDelete]
        public IHttpActionResult Remove(Guid id)
        {
            Dependencies.Remove(id);
            return Ok();
        }

        [Route("dependencies")]
        [HttpGet]
        public IHttpActionResult List()
        {
            return Ok(Dependencies.ToArray());
        }
    }
}
