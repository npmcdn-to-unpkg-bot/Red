using System.Collections.Generic;

namespace Shlima.WebApi.Models.ShoppingList
{
    public class List
    {
        public class ShoppingListClass
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public List<ShoppingListClass> ShoppingLists { get; set; }
    }
}