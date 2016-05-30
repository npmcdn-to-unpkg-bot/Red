using System.Net;
using NUnit.Framework;

namespace Shlima.WebApi.Tests.Acceptence.ShoppingList
{
    public class Delete : Base
    {
        [Test]
        public void should_return_ok_and_empty_string_when_shopping_list_exists()
        {
            var ids = AddShoppingList(
                new EntityModel.ShoppingList
                {
                    Name = "name"
                });

            var response = HttpClient.DeleteAsync($"/ShoppingList/{ids[0]}").Result;
            var content = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(content, Is.Empty);

            var shoppingLists = GetShoppingLists();
            Assert.That(shoppingLists.Length, Is.EqualTo(0));
        }

        [Test]
        public void should_return_not_found_and_null_when_shopping_list_doesnt_exist()
        {
            var response = HttpClient.DeleteAsync("/ShoppingList/1").Result;
            var content = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(content, Is.Empty);
        }
    }
}
