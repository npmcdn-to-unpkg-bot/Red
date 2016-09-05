using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Abc.WebApi.Tests
{
    [TestFixture]
    public class BookTests
    {
        [SetUp]
        public void SetUp()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(BaseAddress)
            };
        }

        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
        }

        [Test]
        public void should_be_able_to_add_a_book()
        {
            Delete("books");

            Put("books/123", new
            {
                Author = "Stephen King",
                Title = "Carrie"
            });

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.Created));
            Assert.That(_response.Headers.Location.AbsoluteUri, Is.EqualTo($"{BaseAddress}books/123"));
        }

        [Test]
        public void should_be_able_to_get_a_book()
        {
            Delete("books");

            Put("books/123", new
            {
                Author = "Stephen King",
                Title = "Carrie"
            });

            Get("books/123");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{\"Author\":\"Stephen King\",\"Title\":\"Carrie\"}"));
        }

        [Test]
        public void should_be_able_to_delete_a_book()
        {
            Delete("books");

            Put("books/123", new
            {
                Author = "Stephen King",
                Title = "Carrie"
            });

            Delete("books/123");

            Get("books");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{}"));
        }

        [Test]
        public void should_be_able_to_get_all_books()
        {
            Delete("books");

            Put("books/456", new
            {
                Author = "Stephen King",
                Title = "The Shining"
            });

            Put("books/123", new
            {
                Author = "Stephen King",
                Title = "Carrie"
            });

            Put("books/789", new
            {
                Author = "Stephen King",
                Title = "The Stand"
            });

            Get("books");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{\"456\":{\"Author\":\"Stephen King\",\"Title\":\"The Shining\"},\"123\":{\"Author\":\"Stephen King\",\"Title\":\"Carrie\"},\"789\":{\"Author\":\"Stephen King\",\"Title\":\"The Stand\"}}"));
        }

        [Test]
        public void should_be_able_to_delete_all_books()
        {
            Delete("books");

            Put("books/456", new
            {
                Author = "Stephen King",
                Title = "The Shining"
            });

            Put("books/123", new
            {
                Author = "Stephen King",
                Title = "Carrie"
            });

            Put("books/789", new
            {
                Author = "Stephen King",
                Title = "The Stand"
            });

            Delete("books");

            Get("books");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{}"));
        }

        private HttpClient _client;

        private HttpResponseMessage _response;

        private HttpStatusCode _statusCode;

        private string _content;

        private const string BaseAddress = "http://localhost/Abc.WebApi/"; //"http://localhost:5000/"


        private void Get(string uri)
        {
            _response = _client.GetAsync(uri).Result;
            _statusCode = _response.StatusCode;
            _content = _response.Content.ReadAsStringAsync().Result;
        }

        private void Put(string uri, object obj)
        {
            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            _response = _client.PutAsync(uri, content).Result;
            _statusCode = _response.StatusCode;
            _content = _response.Content.ReadAsStringAsync().Result;
        }

        private void Delete(string uri)
        {
            _response = _client.DeleteAsync(uri).Result;
            _statusCode = _response.StatusCode;
            _content = _response.Content.ReadAsStringAsync().Result;
        }
    }
}
