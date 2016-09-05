using System.Web.Http;
using Abc.WebApi.Models;
using Abc.WebApi.Persistence;
using Abc.WebApi.Routing.Method;

namespace Abc.WebApi.BookControllers
{
    public class AddBookController : ApiController
    {
        [HttpPut]
        [PutRoute("books/{isbn}")]
        public IHttpActionResult AddBook([FromUri]string isbn, [FromBody]BookModel book)
        {
            BookPersistence.Books.Add(isbn, book);

            return CreatedAtRoute("GetName", new { isbn }, book);
        }
    }
}
