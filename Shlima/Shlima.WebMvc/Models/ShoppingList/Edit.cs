using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Shlima.WebMvc.Models.ShoppingList
{
    public class Edit
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