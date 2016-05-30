using Newtonsoft.Json.Linq;

namespace Shlima.WebApi.Client
{
    public interface IJsonDeserializer
    {
        JObject Deserialize(string contentAsString);

        T Deserialize<T>(string contentAsString);
    }
}
