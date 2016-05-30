using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.HttpClient
{
    public class DefaultDeserializingHandler<T> : IExpectedStatusCodeHandler<T>
    {
        private readonly IJsonDeserializer _jsonDeserializer;

        public DefaultDeserializingHandler(IJsonDeserializer jsonDeserializer)
        {
            _jsonDeserializer = jsonDeserializer;
        }

        public HttpStatusCode HttpStatusCode { get; set; }

        public async Task<T> Handle(HttpContent httpContent)
        {
            if (httpContent == null)
            {
                throw new Exception($"The server returned the expected status code ({HttpStatusCode}) but the content was a null.");
            }

            var contentAsString = await httpContent.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(contentAsString))
            {
                throw new Exception($"The server returned the expected status code ({HttpStatusCode}) but the content was either a null or was white space.");
            }

            T contentAsObject;
            try
            {
                contentAsObject = _jsonDeserializer.Deserialize<T>(contentAsString);
            }
            catch (Exception ex)
            {
                throw new Exception($"The server returned the expected status code ({HttpStatusCode}) but an exception ({ex.Message}) was thrown when deserializing the content to a json object.");
            }

            if (contentAsObject == null)
            {
                throw new Exception($"The server returned the expected status code ({HttpStatusCode}) but the content was a null json object.");
            }

            return contentAsObject;
        }
    }
}
