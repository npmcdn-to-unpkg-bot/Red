using System.Web.Http;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.Method;

namespace Abc.WebApi.BookControllers
{
    public class DeleteBooksController : ApiController
    {
        [HttpDelete]
        [DeleteRoute("books")]
        public IHttpActionResult DeleteBooks()
        {
            BookPersistence.Books.Clear();

            return Ok();
        }
    }
}