using System.Collections.Generic;
using Abc.WebApi.Models;

namespace Abc.WebApi.Persistence
{
    static class BookPersistence
    {
        public static readonly Dictionary<string, BookModel> Books = new Dictionary<string, BookModel>();
    }
}
