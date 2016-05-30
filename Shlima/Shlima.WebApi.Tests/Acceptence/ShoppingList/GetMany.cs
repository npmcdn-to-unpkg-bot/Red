using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Shlima.WebApi.Tests.Acceptence.ShoppingList
{
    public class GetMany : Base
    {
        [Test]
        public void should_return_ok_and_shopping_lists_when_shopping_lists_exist()
        {
            var ids = AddShoppingList(
                new EntityModel.ShoppingList
                {
                    Name = "Name #1"
                },
                new EntityModel.ShoppingList
                {
                    Name = "Name #2"
                },
                new EntityModel.ShoppingList
                {
                    Name = "Name #3"
                });

            var response = HttpClient.GetAsync("/ShoppingList").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var list = (JObject)JsonConvert.DeserializeObject(content);
            var shoppingLists = (JArray)list["ShoppingLists"];

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(shoppingLists.Count, Is.EqualTo(3));
            Assert.That((int)shoppingLists[0]["Id"], Is.EqualTo(ids[0]));
            Assert.That((string)shoppingLists[0]["Name"], Is.EqualTo("Name #1"));
            Assert.That((int)shoppingLists[1]["Id"], Is.EqualTo(ids[1]));
            Assert.That((string)shoppingLists[1]["Name"], Is.EqualTo("Name #2"));
            Assert.That((int)shoppingLists[2]["Id"], Is.EqualTo(ids[2]));
            Assert.That((string)shoppingLists[2]["Name"], Is.EqualTo("Name #3"));
        }

        [Test]
        public void should_return_ok_and_empty_list_of_shopping_lists_when_shopping_lists_dont_exist()
        {
            var response = HttpClient.GetAsync("/ShoppingList").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var list = (JObject)JsonConvert.DeserializeObject(content);
            var shoppingLists = (JArray)list["ShoppingLists"];

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(shoppingLists.Count, Is.EqualTo(0));
        }
    }
}
