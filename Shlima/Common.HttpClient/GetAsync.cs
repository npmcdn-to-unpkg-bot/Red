using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Common.HttpClient
{
    public class GetAsync<T> : IGetAsync<T>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly IUnexpectedStatusCodeHandler _unexpectedStatusCodeHandler;

        private readonly Dictionary<HttpStatusCode, IExpectedStatusCodeHandler<T>> _expectedStatusCodeHandlers = new Dictionary<HttpStatusCode, IExpectedStatusCodeHandler<T>>();

        public GetAsync(
            IHttpClientFactory httpClientFactory,
            IUnexpectedStatusCodeHandler unexpectedStatusCodeHandler,
            params IExpectedStatusCodeHandler<T>[] expectedStatusCodeHandlers)
        {
            _httpClientFactory = httpClientFactory;
            _unexpectedStatusCodeHandler = unexpectedStatusCodeHandler;
            foreach (var expectedStatusCodeHandler in expectedStatusCodeHandlers)
            {
                _expectedStatusCodeHandlers.Add(expectedStatusCodeHandler.HttpStatusCode, expectedStatusCodeHandler);
            }
        }

        public async Task<T> Execute(string uri)
        {
            using (var httpClient = await _httpClientFactory.GetHttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync(new Uri(uri)))
                {
                    using (var httpContent = httpResponseMessage.Content)
                    {
                        IExpectedStatusCodeHandler<T> expectedStatusCodeHandler;
                        if (_expectedStatusCodeHandlers.TryGetValue(httpResponseMessage.StatusCode, out expectedStatusCodeHandler))
                        {
                            return await expectedStatusCodeHandler.Handle(httpContent);
                        }
                        throw await _unexpectedStatusCodeHandler.Handle(httpResponseMessage.StatusCode, httpContent);
                    }
                }
            }
        }
    }
}
