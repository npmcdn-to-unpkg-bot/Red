namespace Shlima.WebApi.Models.ShoppingList
{
    public class Details
    {
        public class ShoppingListClass
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public ShoppingListClass ShoppingList { get; set; }
    }
}
