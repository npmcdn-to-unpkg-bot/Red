using NUnit.Framework;
using List = Shlima.WebApi.Models.ShoppingList.List;

namespace Shlima.WebApi.Client.Tests.Acceptence.ShoppingList
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

            var list = new Client.ShoppingList.GetMany(HttpClient)
                .Get()
                .Result;

            Assert.That(list.ShoppingLists.Count, Is.EqualTo(3));
            Assert.That(list.ShoppingLists[0].Id, Is.EqualTo(ids[0]));
            Assert.That(list.ShoppingLists[0].Name, Is.EqualTo("Name #1"));
            Assert.That(list.ShoppingLists[1].Id, Is.EqualTo(ids[1]));
            Assert.That(list.ShoppingLists[1].Name, Is.EqualTo("Name #2"));
            Assert.That(list.ShoppingLists[2].Id, Is.EqualTo(ids[2]));
            Assert.That(list.ShoppingLists[2].Name, Is.EqualTo("Name #3"));
        }

        [Test]
        public void should_return_ok_and_empty_list_of_shopping_lists_when_shopping_lists_dont_exist()
        {
            var list = new Client.ShoppingList.GetMany(HttpClient)
                .Get()
                .Result;

            Assert.That(list.ShoppingLists.Count, Is.EqualTo(0));
        }
    }
}
