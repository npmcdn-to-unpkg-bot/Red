namespace Shlima.WebApi.Tests
{
    public class ShoppingListController : Controllers.ShoppingListController
    {
        public ShoppingListController() : base(new DataAccess.Context())
        {
        }
    }
}
