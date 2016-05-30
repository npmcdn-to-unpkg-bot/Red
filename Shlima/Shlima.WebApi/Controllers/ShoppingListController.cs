using System.Linq;
using System.Web.Http;
using Shlima.DataAccess.Interfaces;
using Shlima.WebApi.ExceptionHandler;
using Shlima.WebApi.Helpers;
using Shlima.WebApi.Models.ShoppingList;

namespace Shlima.WebApi.Controllers
{
    public class ShoppingListController : ApiController
    {
        readonly IContext _context;

        public ShoppingListController(IContext context)
        {
            _context = context;
        }

        public IHttpActionResult Get()
        {
            return Ok(new List
            {
                ShoppingLists = _context.ShoppingLists
                    .Select(x => new List.ShoppingListClass
                    {
                        Id = x.Id,
                        Name = x.Name,
                    }).ToList(),
            });
        }

        public IHttpActionResult Get(int id)
        {
            var shoppingList = _context.ShoppingLists
                .FirstOrDefault(x => x.Id == id);
            if (shoppingList == null)
                return NotFound();
            return Ok(new Details
            {
                ShoppingList = new Details.ShoppingListClass
                {
                    Id = shoppingList.Id,
                    Name = shoppingList.Name,
                },
            });
        }

        public IHttpActionResult Post([FromBody]Create model)
        {
            if (ModelState.IsValid)
            {
                var shoppingList = new EntityModel.ShoppingList
                {
                    Name = model.ShoppingList.Name,
                };
                _context.ShoppingLists.Add(shoppingList);
                if (_context.SaveChanges(new DuplicateShoppingListName()))
                {
                    return Ok(shoppingList.Id);
                }
                ModelState.AddModelError(_context.Errors);
            }
            return BadRequest(ModelState);
        }

        public IHttpActionResult Put(int id, [FromBody]Edit model)
        {
            if (ModelState.IsValid)
            {
                var shoppingList = _context.ShoppingLists
                    .FirstOrDefault(x => x.Id == id);
                if (shoppingList == null)
                    return NotFound();
                shoppingList.Name = model.ShoppingList.Name;
                if (_context.SaveChanges(new DuplicateShoppingListName()))
                {
                    return Ok();
                }
                ModelState.AddModelError(_context.Errors);
            }
            return BadRequest(ModelState);
        }

        public IHttpActionResult Delete(int id)
        {
            var shoppingList = _context.ShoppingLists
                .FirstOrDefault(x => x.Id == id);
            if (shoppingList == null)
                return NotFound();
            _context.ShoppingLists.Remove(shoppingList);
            _context.SaveChanges();
            return Ok();
        }
    }
}
