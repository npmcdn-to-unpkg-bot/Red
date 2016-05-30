using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Shlima.WebApi.Client
{
    public class JsonDeserializer : IJsonDeserializer
    {
        public JObject Deserialize(string contentAsString)
        {
            return JsonConvert.DeserializeObject(contentAsString) as JObject;
        }

        public T Deserialize<T>(string contentAsString)
        {
            return JsonConvert.DeserializeObject<T>(contentAsString);
        }
    }
}
