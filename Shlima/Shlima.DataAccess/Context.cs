using System.Data.Entity;
using Shlima.DataAccess.Interfaces;
using Shlima.EntityModel;

namespace Shlima.DataAccess
{
    public class Context : Common.DataAccess.Context, IContext
    {
        public Context()
            : base("Shlima")
        {
        }

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
