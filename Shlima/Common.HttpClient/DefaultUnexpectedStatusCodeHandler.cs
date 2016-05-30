using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Common.HttpClient
{
    public class DefaultUnexpectedStatusCodeHandler : IUnexpectedStatusCodeHandler
    {
        private readonly IJsonDeserializer _jsonDeserializer;

        public DefaultUnexpectedStatusCodeHandler(IJsonDeserializer jsonDeserializer)
        {
            _jsonDeserializer = jsonDeserializer;
        }

        public async Task<Exception> Handle(HttpStatusCode httpStatusCode, HttpContent httpContent)
        {
            var message = $"The server returned an unexpected status code ({httpStatusCode}). ";

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
                return new Exception(string.Concat(message, $"An exception ({ex.Message}) was thrown when deserializing the content to a json object."));
            }

            JToken exceptionMessage;
            if (!contentAsObject.TryGetValue("ExceptionMessage", out exceptionMessage))
            {
                return new Exception(string.Concat(message, "No exception message was returned in the content."));
            }

            return new Exception(string.Concat(message, $"The exception message ({exceptionMessage}) was returned in the content."));
        }
    }
}
