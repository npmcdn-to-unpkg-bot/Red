using System.ComponentModel.DataAnnotations;

namespace Shlima.WebMvc.Models.ShoppingList
{
    public class Create
    {
        public class ShoppingListClass
        {
            [Required]
            public string Name { get; set; }
        }

        public ShoppingListClass ShoppingList { get; set; }
    }
}