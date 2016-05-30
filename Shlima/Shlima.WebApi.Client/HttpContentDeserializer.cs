using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shlima.WebApi.Client
{
    public class HttpContentDeserializer<T> : IHttpContentDeserializer<T>
    {
        private readonly IJsonDeserializer _jsonDeserializer;

        public HttpContentDeserializer(IJsonDeserializer jsonDeserializer)
        {
            _jsonDeserializer = jsonDeserializer;
        }

        public HttpContentDeserializer()
        {
            _jsonDeserializer = new JsonDeserializer();
        }

        public async Task<T> DeserializeAsync(HttpResponseMessage httpResponseMessage)
        {
            using (var httpContent = httpResponseMessage.Content)
            {
                if (httpContent == null)
                {
                    throw new Exception(
                        $"The server returned the expected status code ({httpResponseMessage.StatusCode}) but the content was a null.");
                }

                var contentAsString = await httpContent.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(contentAsString))
                {
                    throw new Exception(
                        $"The server returned the expected status code ({httpResponseMessage.StatusCode}) but the content was either a null or was white space.");
                }

                T contentAsObject;
                try
                {
                    contentAsObject = _jsonDeserializer.Deserialize<T>(contentAsString);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"The server returned the expected status code ({httpResponseMessage.StatusCode}) but an exception ({ex.Message}) was thrown when deserializing the content to a json object.");
                }

                if (contentAsObject == null)
                {
                    throw new Exception(
                        $"The server returned the expected status code ({httpResponseMessage.StatusCode}) but the content was a null json object.");
                }

                return contentAsObject;
            }
        }
    }
}