using NUnit.Framework;

namespace Shlima.WebApi.Client.Tests.Acceptence.ShoppingList
{
    public class Create : Base
    {
        [Test]
        public void should_return_ok_and_id_when_shopping_list_is_valid()
        {
            //var model = new
            //{
            //    ShoppingList = new
            //    {
            //        Name = "Name",
            //    }
            //};
            //var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            //requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = HttpClient.PostAsync("/ShoppingList", requestContent).Result;
            //var responseContent = response.Content.ReadAsStringAsync().Result;
            //var id = Convert.ToInt32(responseContent);

            //Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            //Assert.That(id, Is.Not.EqualTo(0));

            //var shoppingLists = GetShoppingLists();
            //Assert.That(shoppingLists.Length, Is.EqualTo(1));
            //Assert.That(shoppingLists[0].Name, Is.EqualTo("Name"));
        }

        [Test]
        public void should_return_bad_request_and_error_message_when_shopping_list_already_exists()
        {
            //AddShoppingList(new EntityModel.ShoppingList
            //{
            //    Name = "Name"
            //});

            //var model = new
            //{
            //    ShoppingList = new 
            //    {
            //        Name = "Name",
            //    }
            //};
            //var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            //requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = HttpClient.PostAsync("/ShoppingList", requestContent).Result;
            //var responseContent = response.Content.ReadAsStringAsync().Result;

            //Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            //Assert.That(responseContent, Is.EqualTo("{\"Message\":\"The request is invalid.\",\"ModelState\":{\"\":[\"A shopping list with the name: 'Name' already exists.\"]}}"));
        }

        [TestCase(null)]
        [TestCase("")]
        public void should_return_bad_request_and_error_message_when_name_is_empty(string name)
        {
            //var model = new
            //{
            //    ShoppingList = new 
            //    {
            //        Name = name,
            //    }
            //};
            //var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            //requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = HttpClient.PostAsync("/ShoppingList", requestContent).Result;
            //var responseContent = response.Content.ReadAsStringAsync().Result;

            //Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            //Assert.That(responseContent, Is.EqualTo("{\"Message\":\"The request is invalid.\",\"ModelState\":{\"model.ShoppingList.Name\":[\"The Name field is required.\"]}}"));
        }

        [Test]
        public void should_return_bad_request_and_error_message_when_name_is_too_long()
        {
            //var model = new
            //{
            //    ShoppingList = new 
            //    {
            //        Name = "Name too long", //[StringLength(9)]
            //    }
            //};
            //var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            //requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //var response = HttpClient.PostAsync("/ShoppingList", requestContent).Result;
            //var responseContent = response.Content.ReadAsStringAsync().Result;

            //Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            //Assert.That(responseContent, Is.EqualTo("{\"Message\":\"The request is invalid.\",\"ModelState\":{\"model.ShoppingList.Name\":[\"The field Name must be a string with a maximum length of 9.\"]}}"));
        }
    }
}
