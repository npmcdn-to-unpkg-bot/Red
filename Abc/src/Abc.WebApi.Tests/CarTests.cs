using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Abc.WebApi.Tests
{
    [TestFixture]
    public class CarTests
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
        public void should_be_able_to_add_a_car()
        {
            Delete("cars");

            Put("cars/abc123", new
            {
                Make = "Ford",
                Model = "Escort"
            });

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.Created));
            Assert.That(_response.Headers.Location.AbsoluteUri, Is.EqualTo($"{BaseAddress}cars/abc123"));
        }

        [Test]
        public void should_be_able_to_get_a_car()
        {
            Delete("cars");

            Put("cars/abc123", new
            {
                Make = "Ford",
                Model = "Escort"
            });

            Get("cars/abc123");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{\"Make\":\"Ford\",\"Model\":\"Escort\"}"));
        }

        [Test]
        public void should_be_able_to_delete_a_car()
        {
            Delete("cars");

            Put("cars/abc123", new
            {
                Make = "Ford",
                Model = "Escort"
            });

            Delete("cars/abc123");

            Get("cars");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{}"));
        }

        [Test]
        public void should_be_able_to_get_all_cars()
        {
            Delete("cars");

            Put("cars/abc123", new
            {
                Make = "Ford",
                Model = "Fiesta"
            });

            Put("cars/abc456", new
            {
                Make = "Ford",
                Model = "Escort"
            });

            Put("cars/abc789", new
            {
                Make = "Ford",
                Model = "Mondeo"
            });

            Get("cars");

            Assert.That(_statusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(_content, Is.EqualTo("{\"abc123\":{\"Make\":\"Ford\",\"Model\":\"Fiesta\"},\"abc456\":{\"Make\":\"Ford\",\"Model\":\"Escort\"},\"abc789\":{\"Make\":\"Ford\",\"Model\":\"Mondeo\"}}"));
        }

        [Test]
        public void should_be_able_to_delete_all_cars()
        {
            Delete("cars");

            Put("cars/abc123", new
            {
                Make = "Ford",
                Model = "Fiesta"
            });

            Put("cars/abc456", new
            {
                Make = "Ford",
                Model = "Escort"
            });

            Put("cars/abc789", new
            {
                Make = "Ford",
                Model = "Mondeo"
            });

            Delete("cars");

            Get("cars");

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
