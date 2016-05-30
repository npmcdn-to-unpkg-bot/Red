using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Shlima.WebApi.Client
{
    public class UnexpectedStatusCodeHandler : IUnexpectedStatusCodeHandler
    {
        private readonly IJsonDeserializer _jsonDeserializer;

        public UnexpectedStatusCodeHandler(IJsonDeserializer jsonDeserializer)
        {
            _jsonDeserializer = jsonDeserializer;
        }

        public UnexpectedStatusCodeHandler()
        {
            _jsonDeserializer = new JsonDeserializer();
        }

        public async Task<Exception> HandleAsync(HttpResponseMessage httpResponseMessage)
        {
            var message = $"The server returned an unexpected status code ({httpResponseMessage.StatusCode}). ";
            using (var httpContent = httpResponseMessage.Content)
            {
                if (httpContent == null)
                {
                    return new Exception(string.Concat(message, "The content was a null."));
                }

                var contentAsString = await httpContent.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(contentAsString))
                {
                    return new Exception(string.Concat(message, "The content was either a null or was white space."));
                }

                JObject contentAsObject;
                try
                {
                    contentAsObject = _jsonDeserializer.Deserialize(contentAsString);
                    if (contentAsObject == null)
                    {
                        return new Exception(string.Concat(message, "The content was a null json object."));
                    }
                }
                catch (Exception ex)
                {
                    return
                        new Exception(string.Concat(message,
                            $"An exception ({ex.Message}) was thrown when deserializing the content to a json object."));
                }

                JToken exceptionMessage;
                if (!contentAsObject.TryGetValue("ExceptionMessage", out exceptionMessage))
                {
                    return new Exception(string.Concat(message, "No exception message was returned in the content."));
                }

                return
                    new Exception(string.Concat(message,
                        $"The exception message ({exceptionMessage}) was returned in the content."));
            }
        }
    }
}