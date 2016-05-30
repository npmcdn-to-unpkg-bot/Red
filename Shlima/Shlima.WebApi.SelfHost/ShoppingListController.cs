namespace Shlima.WebApi.SelfHost
{
    public class ShoppingListController : Controllers.ShoppingListController
    {
        public ShoppingListController()
            : base(new DataAccess.Context())
        {
        }
    }
}
