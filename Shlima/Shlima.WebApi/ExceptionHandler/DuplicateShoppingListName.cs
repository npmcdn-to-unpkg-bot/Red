using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using Common.DataAccess.Interfaces;

namespace Shlima.WebApi.ExceptionHandler
{
    internal class DuplicateShoppingListName : IExceptionHandler
    {
        public Dictionary<string, string> Handle(Exception ex)
        {
            if (
                ex is DbUpdateException &&
                ex.InnerException?.InnerException != null &&
                ex.InnerException.InnerException.Message.StartsWith("Cannot insert duplicate key row in object 'dbo.ShoppingLists' with unique index 'IX_Name'. The duplicate key value is ("))
            {
                return new Dictionary<string, string>
                {
                    {
                        string.Empty, $"A shopping list with the name: '{ex.InnerException.InnerException.Message.Substring(119, ex.InnerException.InnerException.Message.IndexOf(")", 119) - 119)}' already exists."
                    }
                };
            }
            throw ex;
        }
    }
}