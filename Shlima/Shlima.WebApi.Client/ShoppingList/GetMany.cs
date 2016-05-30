using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Shlima.WebApi.Models.ShoppingList;

namespace Shlima.WebApi.Client.ShoppingList
{
    public class GetMany
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContentDeserializer<List> _contentDeserializer;
        private readonly IUnexpectedStatusCodeHandler _unexpectedStatusCodeHandler;

        public GetMany(
            HttpClient httpClient,
            IHttpContentDeserializer<List> contentDeserializer, 
            IUnexpectedStatusCodeHandler unexpectedStatusCodeHandler)
        {
            _httpClient = httpClient;
            _contentDeserializer = contentDeserializer;
            _unexpectedStatusCodeHandler = unexpectedStatusCodeHandler;
        }

        public GetMany(
            HttpClient httpClient)
        {
            _httpClient = httpClient;
            _contentDeserializer = new HttpContentDeserializer<List>();
            _unexpectedStatusCodeHandler = new UnexpectedStatusCodeHandler();
        }

        public async Task<List> Get()
        {
            using (var httpResponseMessage = await _httpClient.GetAsync("/ShoppingList"))
            {
                if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    return await _contentDeserializer.DeserializeAsync(httpResponseMessage);
                }
                throw await _unexpectedStatusCodeHandler.HandleAsync(httpResponseMessage);
            }
        }
    }
}
