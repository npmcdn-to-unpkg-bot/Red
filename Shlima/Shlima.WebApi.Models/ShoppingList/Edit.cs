using System.ComponentModel.DataAnnotations;

namespace Shlima.WebApi.Models.ShoppingList
{
    public class Edit
    {
        public class ShoppingListClass
        {
            [Required]
            [StringLength(9)]
            public string Name { get; set; }
        }

        public ShoppingListClass ShoppingList { get; set; }
    }
}
