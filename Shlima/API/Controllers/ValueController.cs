using System.Web.Http;
using Api.ApplicatiinServices;

namespace Api.Controllers
{
    public class ValueController : ApiController
    {
        private readonly IGetValues _dependency;

        public ValueController(IGetValues dependency)
        {
            _dependency = dependency;
        }

        public Values Get(int id)
        {
            var value = _dependency.GetAValue(id);
            return new Values { "value" + value };
        }
    }
}