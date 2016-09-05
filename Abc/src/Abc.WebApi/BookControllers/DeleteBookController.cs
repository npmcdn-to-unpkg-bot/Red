using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.Method;

namespace Abc.WebApi.BookControllers
{
    public class DeleteBookController : ApiController
    {
        [HttpDelete]
        [DeleteRoute("books/{isbn}")]
        public IHttpActionResult DeleteBook([FromUri] string isbn)
        {
            BookPersistence.Books.Remove(isbn);

            return Ok();
        }
    }
}