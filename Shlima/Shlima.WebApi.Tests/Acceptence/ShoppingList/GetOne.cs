using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Shlima.WebApi.Tests.Acceptence.ShoppingList
{
    public class GetOne : Base
    {
        [Test]
        public void should_return_ok_and_shopping_list_when_shopping_list_exists()
        {
            var ids = AddShoppingList(new EntityModel.ShoppingList
            {
                Name = "Name"
            });

            var response = HttpClient.GetAsync($"/ShoppingList/{ids[0]}").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var details = (JObject)JsonConvert.DeserializeObject(content);
            var shoppingList = details["ShoppingList"];

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That((int)shoppingList["Id"], Is.EqualTo(ids[0]));
            Assert.That((string)shoppingList["Name"], Is.EqualTo("Name"));
        }

        [Test]
        public void should_return_not_found_and_null_when_shopping_list_doesnt_exist()
        {
            var response = HttpClient.GetAsync("/ShoppingList/1").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var details = JsonConvert.DeserializeObject(content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(details, Is.Null);
        }
    }
}
