using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.Method;

namespace Abc.WebApi.BookControllers
{
    public class GetBookController : ApiController
    {
        [HttpGet]
        [GetRoute("books/{isbn}", Name = "GetName")]
        public IHttpActionResult GetBook([FromUri]string isbn)
        {
            return Ok(BookPersistence.Books[isbn]);
        }
    }
}
