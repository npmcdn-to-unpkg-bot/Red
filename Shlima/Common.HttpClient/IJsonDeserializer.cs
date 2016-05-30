using Newtonsoft.Json.Linq;

namespace Common.HttpClient
{
    public interface IJsonDeserializer
    {
        JObject Deserialize(string contentAsString);

        T Deserialize<T>(string contentAsString);
    }
}
