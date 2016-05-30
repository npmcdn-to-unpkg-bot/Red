using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ViewModel01.Users;
using WebApi01.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace WebApi01.Controllers
{
    public class UsersController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public List Get()
        {
            return new List()
            {
                Users = _context.Users.OrderBy(x => x.UserName).ToList().Select(x => new List.User_
                {
                    Id = x.Id,
                    Email = x.Email,
                    UserName = x.UserName,
                }).ToList()
            };
        }

        public Display Get(string id)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                throw new NotImplementedException();
            }
            return new Display()
            {
                User = new Display.User_()
                {
                    Id = user.Id,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    PasswordHash = user.PasswordHash,
                    SecurityStamp = user.SecurityStamp,
                    PhoneNumber = user.PhoneNumber,
                    PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                    TwoFactorEnabled = user.TwoFactorEnabled,
                    LockoutEndDateUtc = user.LockoutEndDateUtc,
                    LockoutEnabled = user.LockoutEnabled,
                    AccessFailedCount = user.AccessFailedCount,
                    UserName = user.UserName,
                },
            };
        }

        public void Put(string id, [FromBody] Put put)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindById(id);
            user.Email = put.User.Email;
            user.UserName = put.User.UserName;
            var result = userManager.Update(user);
            if (!result.Succeeded)
            {
                throw new NotImplementedException();
            }
        }

        public string Post([FromBody] Post post)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = new ApplicationUser()
            {
                UserName = post.User.UserName,
                Email = post.User.Email,
            };
            var result = userManager.Create(user, "Qwerty123$");
            if (!result.Succeeded)
            {
                throw new NotImplementedException();
            }
            return user.Id;
        }

        public void Delete(string id)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindById(id);
            var result = userManager.Delete(user);
            if (!result.Succeeded)
            {
                throw new NotImplementedException();
            }
        }
    }
}
