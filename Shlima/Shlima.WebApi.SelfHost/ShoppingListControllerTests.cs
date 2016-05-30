using System.Net.Http;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.Testing;
using NUnit.Framework;

namespace Shlima.WebApi.SelfHost
{
    public class ShoppingListControllerTests
    {

        public class rmg
        {
            [Test]
            public void test1()
            {
                //string baseAddress = "http://localhost/Shlima.WebApi/";
                //using (WebApp.Start<Startup>(baseAddress))
                //{
                //    HttpClient client = new HttpClient();
                //    var response = client.GetAsync(baseAddress + "ShoppingList");
                //    var result = response.Result;
                //}
                using (var testServer = TestServer.Create<Startup>())
                {
                    var response = testServer.HttpClient.GetAsync("ShoppingList");
                    var result = response.Result;
                }
                ;

            }
        }

        //public class GetMany
        //{
        //    [Test]
        //    public void returns_ok_and_shopping_lists_when_shopping_lists_exists()
        //    {
        //        //Arrange.
        //        var context = new MockContext();
        //        context.ShoppingListData.AddRange(new List<ShoppingList>
        //        {
        //            new ShoppingList
        //            {
        //                Id = 1,
        //                Name = "Shopping List #1"
        //            },
        //            new ShoppingList
        //            {
        //                Id = 2,
        //                Name = "Shopping List #2"
        //            },
        //            new ShoppingList
        //            {
        //                Id = 3,
        //                Name = "Shopping List #3"
        //            },
        //        });
        //        var controller = new ShoppingListController(context.Object);

        //        //Act.
        //        var result = controller.Get();

        //        //Assert.
        //        Assert.IsInstanceOf<OkNegotiatedContentResult<Models.ShoppingList.List>>(result);
        //        var shoppingLists =
        //            ((OkNegotiatedContentResult<Models.ShoppingList.List>)result).Content.ShoppingLists;
        //        Assert.AreEqual(3, shoppingLists.Count);
        //    }

        //    [Test]
        //    public void returns_ok_and_empty_shopping_lists_when_shopping_lists_dont_exists()
        //    {
        //        //Arrange.
        //        var context = new MockContext();
        //        context.ShoppingListData.AddRange(new List<ShoppingList>());
        //        var controller = new ShoppingListController(context.Object);

        //        //Act.
        //        var result = controller.Get();

        //        //Assert.
        //        Assert.IsInstanceOf<OkNegotiatedContentResult<Models.ShoppingList.List>>(result);
        //        var shoppingLists =
        //            ((OkNegotiatedContentResult<Models.ShoppingList.List>)result).Content.ShoppingLists;
        //        Assert.AreEqual(0, shoppingLists.Count);
        //    }
        //}

        //public class GetOne
        //{
        //    [Test]
        //    public void returns_ok_and_shopping_list_when_shopping_list_exists()
        //    {
        //        //Arrange.
        //        var context = new MockContext();
        //        context.ShoppingListData.Add(new ShoppingList
        //        {
        //            Id = 1,
        //            Name = "Shopping List #1"
        //        });
        //        var controller = new ShoppingListController(context.Object);

        //        //Act.
        //        var result = controller.Get(1);

        //        //Assert.
        //        Assert.IsInstanceOf<OkNegotiatedContentResult<Models.ShoppingList.Details>>(result);
        //        var shoppingList =
        //            ((OkNegotiatedContentResult<Models.ShoppingList.Details>)result).Content.ShoppingList;
        //        Assert.AreEqual(1, shoppingList.Id);
        //        Assert.AreEqual("Shopping List #1", shoppingList.Name);
        //    }

        //    [Test]
        //    public void returns_not_found_when_shopping_list_doesnt_exist()
        //    {
        //        //Arrange.
        //        var context = new MockContext();
        //        var controller = new ShoppingListController(context.Object);

        //        //Act.
        //        var result = controller.Get(1);

        //        //Assert.
        //        Assert.IsInstanceOf<NotFoundResult>(result);
        //    }
        //}
    }
}
