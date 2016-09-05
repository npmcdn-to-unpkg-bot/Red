using System.Web.Http;
using Abc.WebApi.Routing;

namespace Abc.WebApi.Controllers
{
    public class BooksWriteController : ApiController
    {
        [PostRoute("api/Books")]
        public void Post()
        {
            
        }
    }

    [RoutePrefix("api/books")]
    public class BooksReadController : ApiController
    {
        [GetRoute("")]
        public void Get()
        {
            
        }


        [GetRoute("{id:int}")]
        public void Get(int id)
        {
            
        }
    }
}
