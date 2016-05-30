using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shlima.WebMvc.Models.ShoppingList
{
    public class Index
    {
        public class ShoppingListClass
        {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }
        }

        public List<ShoppingListClass> ShoppingLists { get; set; }
    }
}