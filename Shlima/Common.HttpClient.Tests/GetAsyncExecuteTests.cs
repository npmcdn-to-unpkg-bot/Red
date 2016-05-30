using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Common.HttpClient.Tests
{
    public class GetAsyncExecuteTests
    {
        static GetAsync<TestClass> _getAsync;

        private class when_the_server_returns_an_expected_return_code
        {
            [Test]
            public void and_content_it_returns_the_content()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(
                        HttpStatusCode.OK,
                        JsonConvert.SerializeObject(new TestClass()
                        {
                            Id = 1,
                            Name = "Bob"
                        }))),
                    null,
                    new DefaultDeserializingHandler<TestClass>(new DefaultJsonDeserializer())
                    {
                        HttpStatusCode = HttpStatusCode.OK                    
                    });
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Is.InstanceOf<TestClass>()
                        .With.Property(nameof(TestClass.Id)).EqualTo(1).And
                        .With.Property(nameof(TestClass.Name)).EqualTo("Bob"));
            }

            [Test]
            public void and_a_null_content_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(
                        HttpStatusCode.OK, null)),
                    null,
                    new DefaultDeserializingHandler<TestClass>(new DefaultJsonDeserializer())
                    {
                        HttpStatusCode = HttpStatusCode.OK                     
                    });
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo("The server returned the expected status code (OK) but the content was a null."));
            }

            [Test]
            public void and_white_space_content_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(
                        HttpStatusCode.OK, string.Empty)),
                    null,
                    new DefaultDeserializingHandler<TestClass>(new DefaultJsonDeserializer())
                    {
                        HttpStatusCode = HttpStatusCode.OK
                    });
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned the expected status code (OK) but the content was either a null or was white space."));
            }

            [Test]
            public void and_a_null_json_object_it_throws_an_exception()
            {
                var mockDeserializer = new Mock<IJsonDeserializer>();
                mockDeserializer.Setup(x => x.Deserialize(It.IsAny<string>())).Returns((JObject)null);
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{}")),
                    null,
                    new DefaultDeserializingHandler<TestClass>(mockDeserializer.Object)
                    {
                        HttpStatusCode = HttpStatusCode.OK
                    });
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned the expected status code (OK) but the content was a null json object."));
            }

            [Test]
            public void and_an_undeserializable_json_object_it_throws_an_exception()
            {
                var mockDeserializer = new Mock<IJsonDeserializer>();
                mockDeserializer.Setup(x => x.Deserialize<TestClass>(It.IsAny<string>())).Throws(new Exception("Oops"));
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{}")),
                    null,
                    new DefaultDeserializingHandler<TestClass>(mockDeserializer.Object)
                    {
                        HttpStatusCode = HttpStatusCode.OK
                    });
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned the expected status code (OK) but an exception (Oops) was thrown when deserializing the content to a json object."));
            }
        }

        private class when_the_server_returns_an_unexpected_return_code
        {
            [Test]
            public void and_a_null_content_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, null)),
                    new DefaultUnexpectedStatusCodeHandler(new DefaultJsonDeserializer()));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo("The server returned an unexpected status code (OK). The content was a null."));
            }

            [Test]
            public void and_white_space_content_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, string.Empty)),
                    new DefaultUnexpectedStatusCodeHandler(new DefaultJsonDeserializer()));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned an unexpected status code (OK). The content was either a null or was white space."));
            }

            [Test]
            public void and_a_null_json_object_it_throws_an_exception()
            {
                var mockDeserializer = new Mock<IJsonDeserializer>();
                mockDeserializer.Setup(x => x.Deserialize(It.IsAny<string>())).Returns((JObject)null);
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{}")),
                    new DefaultUnexpectedStatusCodeHandler(mockDeserializer.Object));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned an unexpected status code (OK). The content was a null json object."));
            }

            [Test]
            public void and_an_undeserializable_json_object_it_throws_an_exception()
            {
                var mockDeserializer = new Mock<IJsonDeserializer>();
                mockDeserializer.Setup(x => x.Deserialize(It.IsAny<string>())).Throws(new Exception("Oops"));
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{}")),
                    new DefaultUnexpectedStatusCodeHandler(mockDeserializer.Object));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned an unexpected status code (OK). An exception (Oops) was thrown when deserializing the content to a json object."));
            }

            [Test]
            public void and_a_json_object_with_no_error_message_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{}")),
                    new DefaultUnexpectedStatusCodeHandler(new DefaultJsonDeserializer()));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned an unexpected status code (OK). No exception message was returned in the content."));
            }

            [Test]
            public void and_a_json_object_with_an_error_message_it_throws_an_exception()
            {
                _getAsync = new GetAsync<TestClass>(
                    HttpClientFactory(HttpMessageHandler(HttpStatusCode.OK, "{ 'ExceptionMessage' : 'Oops' }")),
                    new DefaultUnexpectedStatusCodeHandler(new DefaultJsonDeserializer()));
                Assert.That(
                    async () => await _getAsync.Execute("http://abc.co.uk"),
                    Throws.Exception.TypeOf<Exception>()
                        .With.Property("Message")
                        .EqualTo(
                            "The server returned an unexpected status code (OK). The exception message (Oops) was returned in the content."));
            }
        }

        #region Helpers

        private class TestClass
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        static HttpMessageHandler HttpMessageHandler(HttpStatusCode statusCode, string content)
        {
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage()
                {
                    StatusCode = statusCode,
                    Content = content == null ? null : new StringContent(content),
                }));
            return mockHttpMessageHandler.Object;
        }

        static IHttpClientFactory HttpClientFactory(HttpMessageHandler httpMessageHandler)
        {
            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            mockHttpClientFactory
                .Setup(x => x.GetHttpClient())
                .Returns(Task<System.Net.Http.HttpClient>.Factory.StartNew(() => new System.Net.Http.HttpClient(httpMessageHandler)));
            return mockHttpClientFactory.Object;
        }

        #endregion
    }
}
