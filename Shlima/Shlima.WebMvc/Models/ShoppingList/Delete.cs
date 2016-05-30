namespace Shlima.WebMvc.Models.ShoppingList
{
    public class Delete
    {
        public class ShoppingListClass
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public ShoppingListClass ShoppingList { get; set; }
    }
}