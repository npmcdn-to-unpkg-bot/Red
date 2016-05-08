using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DefaultApiController : Controller
    { 

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Removes all data from an account. (Doesn&#39;t remove contact preferences).</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="204">Returns 204 No Content if the date was removed or if the data didn&#39;t exist.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpDelete]
        [Route("/{accountId}")]
        [SwaggerOperation("AccountIdDelete")]
        public void AccountIdDelete([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns all data from an account. (Doesn&#39;t return contact preferences).</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 200 OK if the account existed.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpGet]
        [Route("/{accountId}")]
        [SwaggerOperation("AccountIdGet")]
        [SwaggerResponse(200, type: typeof(AccountModel))]
        public IActionResult AccountIdGet([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AccountModel>(exampleJson)
            : default(AccountModel);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Sets the main person on an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="firstName">the person&#39;s first name</param>
        /// <param name="lastName">the person&#39;s last name</param>
        /// <param name="dateOfBirth">the person&#39;s date of birth</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 200 OK if the main person was set.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid or if the person&#39;s first name, last name or date of birth weren&#39;t valid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpPut]
        [Route("/{accountId}/main-person/{firstName}/{lastName}/{dateOfBirth}")]
        [SwaggerOperation("AccountIdMainPersonFirstNameLastNameDateOfBirthPut")]
        public void AccountIdMainPersonFirstNameLastNameDateOfBirthPut([FromRoute]string accountId, [FromRoute]string firstName, [FromRoute]string lastName, [FromRoute]DateTime? dateOfBirth, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Removes a person from an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="firstName">the person&#39;s first name</param>
        /// <param name="lastName">the person&#39;s last name</param>
        /// <param name="dateOfBirth">the person&#39;s date of birth</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="204">Returns 204 No Content if the person was removed or if the person didn&#39;t exist.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid or if the person&#39;s first name, last name or date of birth weren&#39;t valid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        [HttpDelete]
        [Route("/{accountId}/person/{firstName}/{lastName}/{dateOfBirth}")]
        [SwaggerOperation("AccountIdPersonFirstNameLastNameDateOfBirthDelete")]
        public void AccountIdPersonFirstNameLastNameDateOfBirthDelete([FromRoute]string accountId, [FromRoute]string firstName, [FromRoute]string lastName, [FromRoute]DateTime? dateOfBirth, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Updates a person on an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="firstName">the person&#39;s first name</param>
        /// <param name="lastName">the person&#39;s last name</param>
        /// <param name="dateOfBirth">the person&#39;s date of birth</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="person"></param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 200 OK if the person was updated.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid or if the person&#39;s first name, last name or date of birth weren&#39;t valid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpPut]
        [Route("/{accountId}/person/{firstName}/{lastName}/{dateOfBirth}")]
        [SwaggerOperation("AccountIdPersonFirstNameLastNameDateOfBirthPut")]
        public void AccountIdPersonFirstNameLastNameDateOfBirthPut([FromRoute]string accountId, [FromRoute]string firstName, [FromRoute]string lastName, [FromRoute]DateTime? dateOfBirth, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromBody]PersonModel person, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Adds a person to an account. Sets the person as the account&#39;s main person if the account didn&#39;t previously have a main person.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="person"></param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="201">Returns 201 Created if the person was created.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid or if the person wasn&#39;t valid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpPut]
        [Route("/{accountId}/person")]
        [SwaggerOperation("AccountIdPersonPut")]
        public void AccountIdPersonPut([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromBody]PersonModel person, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Removes contact preferences from an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 204 No Content if the contact perferences were removed or if the contact perferences didn&#39;t exist.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpDelete]
        [Route("/contact-preferences/{accountId}")]
        [SwaggerOperation("ContactPreferencesAccountIdDelete")]
        public void ContactPreferencesAccountIdDelete([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns contact preferences from an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 200 OK if the contact perferences existed.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpGet]
        [Route("/contact-preferences/{accountId}")]
        [SwaggerOperation("ContactPreferencesAccountIdGet")]
        [SwaggerResponse(200, type: typeof(ContactPreferencesModel))]
        public IActionResult ContactPreferencesAccountIdGet([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContactPreferencesModel>(exampleJson)
            : default(ContactPreferencesModel);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Adds/updates contact preferences to/on an account.</remarks>
        /// <param name="accountId">the account id</param>
        /// <param name="ctmSessionId">the session id</param>
        /// <param name="ctmVisitorId">the visitor id</param>
        /// <param name="authorization">the bearer token</param>
        /// <param name="contactPreferences"></param>
        /// <param name="ctmCorrelationId">a correlation id</param>
        /// <param name="ctmCausationId">a causation id</param>
        /// <response code="200">Returns 200 OK if the contact preferences were updated.</response>
        /// <response code="201">Returns 201 Created if the contact preferences were created.</response>
        /// <response code="400">Returns 400 Bad Request if the account id wasn&#39;t a guid or if the contact preferences weren&#39;t valid.</response>
        /// <response code="401">Returns 401 Unauthorised if the user wasn&#39;t authorised to access the account.</response>
        /// <response code="404">Returns 404 Not Found if the account didn&#39;t exist or has been closed.</response>
        [HttpPut]
        [Route("/contact-preferences/{accountId}")]
        [SwaggerOperation("ContactPreferencesAccountIdPut")]
        public void ContactPreferencesAccountIdPut([FromRoute]string accountId, [FromHeader]string ctmSessionId, [FromHeader]string ctmVisitorId, [FromHeader]string authorization, [FromBody]ContactPreferencesModel contactPreferences, [FromHeader]string ctmCorrelationId, [FromHeader]string ctmCausationId)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns a health check response detailing the state of the service and its dependencies.</remarks>
        /// <response code="200">Returns 200 OK.</response>
        [HttpGet]
        [Route("/health")]
        [SwaggerOperation("HealthGet")]
        [SwaggerResponse(200, type: typeof(HealthModel))]
        public IActionResult HealthGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<HealthModel>(exampleJson)
            : default(HealthModel);
            
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns a `pong` message for system health checking.</remarks>
        /// <response code="200">Returns 200 OK.</response>
        [HttpGet]
        [Route("/private/ping")]
        [SwaggerOperation("PrivatePingGet")]
        [SwaggerResponse(200, type: typeof(string))]
        public IActionResult PrivatePingGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            
            return new ObjectResult(example);
        }
    }
}
