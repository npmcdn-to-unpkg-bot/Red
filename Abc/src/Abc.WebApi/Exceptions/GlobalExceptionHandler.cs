using System.Net;
using System.Security;
using System.Web.Http.ExceptionHandling;

namespace Abc.WebApi.Exceptions
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new ExceptionResponse
            (
                context.Exception is SecurityException 
                    ? HttpStatusCode.Unauthorized 
                    : HttpStatusCode.InternalServerError,
                "Oops!",
                context.Request
            );
        }
    }
}