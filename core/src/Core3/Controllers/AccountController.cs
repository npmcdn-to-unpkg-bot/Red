using System.Collections.Generic;
using Core3.Models;
using Microsoft.AspNet.Mvc;

namespace Core3.Controllers
{
    public class AccountController : Controller
    {
        public static readonly Dictionary<string, AccountModel> Data = new Dictionary<string, AccountModel>();

        [HttpGet]
        [Route("/{accountId}")]
        public IActionResult GetAccount([FromRoute] string accountId)
        {
            AccountModel account;
            if (!Data.TryGetValue(accountId, out account))
            {
                return HttpNotFound();
            }

            return Ok(account);
        }

        [HttpPut]
        [Route("/{accountId}/person")]
        public IActionResult PutPerson(
            [FromRoute]string accountId, 
            [FromBody]PersonModel person)
        {
            AccountModel account;
            if (!Data.TryGetValue(accountId, out account))
            {
                account = new AccountModel();
            }

            account.People = new List<PersonModel> {person};

            Data.Add(accountId, account);

            return Ok();
        }
    }
}
