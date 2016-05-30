using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using NUnit.Framework;

namespace Shlima.WebApi.Tests.Acceptence.ShoppingList
{
    public class Edit : Base
    {
        [Test]
        public void should_return_ok_and_id_when_shopping_list_is_valid()
        {
            var ids = AddShoppingList(new EntityModel.ShoppingList
            {
                Name = "Name"
            });

            var model = new
            {
                ShoppingList = new 
                {
                    Name = "New Name",
                }
            };
            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = HttpClient.PutAsync($"/ShoppingList/{ids[0]}", requestContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseContent, Is.Empty);

            var shoppingLists = GetShoppingLists();
            Assert.That(shoppingLists.Length, Is.EqualTo(1));
            Assert.That(shoppingLists[0].Name, Is.EqualTo("New Name"));
        }

        [Test]
        public void should_return_not_found_and_null_when_shopping_list_doesnt_exist()
        {
            var model = new
            {
                ShoppingList = new 
                {
                    Name = "New Name",
                }
            };
            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = HttpClient.PutAsync($"/ShoppingList/1", requestContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            Assert.That(responseContent, Is.Empty);
        }

        [TestCase(null)]
        [TestCase("")]
        public void should_return_bad_request_and_error_message_when_name_is_empty(string name)
        {
            var ids = AddShoppingList(new EntityModel.ShoppingList
            {
                Name = "Name"
            });

            var model = new
            {
                ShoppingList = new 
                {
                    Name = name,
                }
            };
            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = HttpClient.PutAsync($"/ShoppingList/{ids[0]}", requestContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            Assert.That(responseContent, Is.EqualTo("{\"Message\":\"The request is invalid.\",\"ModelState\":{\"model.ShoppingList.Name\":[\"The Name field is required.\"]}}"));
        }

        [Test]
        public void should_return_bad_request_and_error_message_when_name_is_too_long()
        {
            var ids = AddShoppingList(new EntityModel.ShoppingList
            {
                Name = "Name"
            });

            var model = new
            {
                ShoppingList = new 
                {
                    Name = "Name too long", //[StringLength(9)]
                }
            };
            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = HttpClient.PutAsync($"/ShoppingList/{ids[0]}", requestContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            Assert.That(responseContent, Is.EqualTo("{\"Message\":\"The request is invalid.\",\"ModelState\":{\"model.ShoppingList.Name\":[\"The field Name must be a string with a maximum length of 9.\"]}}"));
        }
    }
}
