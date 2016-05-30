using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using Microsoft.Owin.Hosting;
using NUnit.Framework;

namespace Shlima.WebApi.Client.Tests.Acceptence
{
    [TestFixture]
    public class Base
    {
        private IDisposable _app;

        protected HttpClient HttpClient;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            new DataAccess.Context().Database.CreateIfNotExists();
            var port = FreeTcpPort();
            var address = $"http://localhost:{port}";
            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri(address),
            };
            _app = WebApp.Start<Startup>(address);
        }

        [SetUp]
        public void Setup()
        {
            DeleteShoppingLists();
        }

        internal void DeleteShoppingLists()
        {
            using (var connection = GetOpenConnection())
            {
                using (var command = new SqlCommand("delete from ShoppingLists", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        internal int[] AddShoppingList(params EntityModel.ShoppingList[] shoppingLists)
        {
            var ids = new int[shoppingLists.Length];
            using (var connection = GetOpenConnection())
            {
                using (var command = new SqlCommand(string.Empty, connection))
                {
                    for (int i = shoppingLists.Length - 1; i >= 0; i--)
                    {
                        command.CommandText = $"insert into ShoppingLists values ('{shoppingLists[i].Name}', null)";
                        command.ExecuteNonQuery();
                        command.CommandText = "select SCOPE_IDENTITY()";
                        ids[i] = Convert.ToInt32((decimal)command.ExecuteScalar());
                    }
                }
            }
            return ids;
        }

        internal EntityModel.ShoppingList[] GetShoppingLists()
        {
            var shoppingLists = new List<EntityModel.ShoppingList>();
            using (var connection = GetOpenConnection())
            {
                using (var command = new SqlCommand(string.Empty, connection))
                {
                    command.CommandText = "select * from ShoppingLists";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shoppingLists.Add(new EntityModel.ShoppingList
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return shoppingLists.ToArray();
        }

        private static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Shlima"].ConnectionString);
            connection.Open();
            return connection;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _app.Dispose();
        }

        private static int FreeTcpPort()
        {
            var tcpListener = new TcpListener(IPAddress.Loopback, 0);
            tcpListener.Start();
            var tcpPort = ((IPEndPoint)tcpListener.LocalEndpoint).Port;
            tcpListener.Stop();
            return tcpPort;
        }
    }
}
