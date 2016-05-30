using System.ComponentModel.DataAnnotations;

namespace Shlima.WebMvc.Models.ShoppingList
{
    public class Details
    {
        public class ShoppingListClass
        {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }
        }

        public ShoppingListClass ShoppingList { get; set; }
    }
}