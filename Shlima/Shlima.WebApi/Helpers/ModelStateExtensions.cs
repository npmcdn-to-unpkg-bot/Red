using System.Collections.Generic;
using System.Web.Http.ModelBinding;

namespace Shlima.WebApi.Helpers
{
    internal static class ModelStateExtensions
    {
        public static void AddModelError(this ModelStateDictionary modelState, Dictionary<string, string> errors)
        {
            foreach (var error in errors)
            {
                modelState.AddModelError(error.Key, error.Value);
            }
        }
    }
}