using System;
using System.Net;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using List = Shlima.WebApi.Models.ShoppingList.List;

namespace Shlima.WebApi.Client.Tests.Unit.ShoppingList
{
    public class GetMany : Base
    {
        [Test]
        public void should_return_ok_and_shopping_lists_when_shopping_lists_exist()
        {
            var httpClient = GetHttpClient(
                HttpStatusCode.OK,
                JsonConvert.SerializeObject(new Models.ShoppingList.List
                {
                    ShoppingLists = new List<Models.ShoppingList.List.ShoppingListClass>
                    {
                        new Models.ShoppingList.List.ShoppingListClass
                        {
                            Id = 1,
                            Name = "Name #1"
                        },
                        new Models.ShoppingList.List.ShoppingListClass
                        {
                            Id = 2,
                            Name = "Name #2"
                        },
                        new Models.ShoppingList.List.ShoppingListClass
                        {
                            Id = 3,
                            Name = "Name #3"
                        }
                    }
                }));

            var list = new Client.ShoppingList.GetMany(httpClient)
                .Get()
                .Result;

            Assert.That(list.ShoppingLists.Count, Is.EqualTo(3));
            Assert.That(list.ShoppingLists[0].Id, Is.EqualTo(1));
            Assert.That(list.ShoppingLists[0].Name, Is.EqualTo("Name #1"));
            Assert.That(list.ShoppingLists[1].Id, Is.EqualTo(2));
            Assert.That(list.ShoppingLists[1].Name, Is.EqualTo("Name #2"));
            Assert.That(list.ShoppingLists[2].Id, Is.EqualTo(3));
            Assert.That(list.ShoppingLists[2].Name, Is.EqualTo("Name #3"));
        }

        [Test]
        public void should_return_ok_and_empty_list_of_shopping_lists_when_shopping_lists_dont_exist()
        {
            var httpClient = GetHttpClient(
                HttpStatusCode.OK,
                JsonConvert.SerializeObject(new Models.ShoppingList.List()
                {
                    ShoppingLists = new List<List.ShoppingListClass>()
                }));

            var list = new Client.ShoppingList.GetMany(httpClient)
                .Get()
                .Result;

            Assert.That(list.ShoppingLists.Count, Is.EqualTo(0));
        }
    }
}
