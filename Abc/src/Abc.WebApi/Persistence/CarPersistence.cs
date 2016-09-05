using System.Collections.Generic;
using Abc.WebApi.Models;

namespace Abc.WebApi.Persistence
{
    static class CarPersistence
    {
        public static readonly Dictionary<string, CarModel> Cars = new Dictionary<string, CarModel>();
    }
}
