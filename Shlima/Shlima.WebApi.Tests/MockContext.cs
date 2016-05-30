using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using Shlima.DataAccess.Interfaces;
using Shlima.EntityModel;

namespace Shlima.WebApi.Tests
{
    internal class MockContext : Mock<IContext>
    {
        public readonly List<ShoppingList> ShoppingListData = new List<ShoppingList>();

        public readonly Mock<DbSet<ShoppingList>> ShoppingLists = new Mock<DbSet<ShoppingList>>();

        public MockContext()
        {
            Setup(x => x.ShoppingLists).Returns(GetMockedDbSet(ShoppingListData, ShoppingLists));
        }

        public MockContext WithShoppingList(ShoppingList shoppingList)
        {
            ShoppingListData.Add(shoppingList);
            return this;
        }

        public MockContext WithShoppingLists(List<ShoppingList> shoppingLists)
        {
            ShoppingListData.AddRange(shoppingLists);
            return this;
        }

        private static DbSet<T> GetMockedDbSet<T>(IEnumerable<T> objects, Mock<DbSet<T>> mockDbSet) where T : class
        {
            var queryable = objects.AsQueryable();
            mockDbSet.As<IQueryable<T>>().Setup(x => x.Provider).Returns(queryable.Provider);
            mockDbSet.As<IQueryable<T>>().Setup(x => x.Expression).Returns(queryable.Expression);
            mockDbSet.As<IQueryable<T>>().Setup(x => x.ElementType).Returns(queryable.ElementType);
            mockDbSet.As<IQueryable<T>>().Setup(x => x.GetEnumerator()).Returns(queryable.GetEnumerator());
            return mockDbSet.Object;
        }
    }
}
