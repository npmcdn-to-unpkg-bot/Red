using System.Data.Entity;
using Shlima.EntityModel;

namespace Shlima.DataAccess.Interfaces
{
    public interface IContext : Common.DataAccess.Interfaces.IContext
    {
        DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
