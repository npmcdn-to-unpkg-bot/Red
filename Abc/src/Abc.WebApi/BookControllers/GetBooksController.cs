using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.Method;

namespace Abc.WebApi.BookControllers
{
    public class GetBooksController : ApiController
    {
        [HttpGet]
        [GetRoute("books")]
        public IHttpActionResult GetBooks()
        {
            return Ok(BookPersistence.Books);
        }
    }
}