using System;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace ConsoleApplication1
{
    public class ApdRepository
    {
        private MongoCollection<ApdAccount> _accounts;

        public ApdRepository()
        {
            var client = new MongoClient();
            var server = client.GetServer();
            var database = server.GetDatabase("apd");
            _accounts = database.GetCollection<ApdAccount>("accounts");
        }

        public void Drop()
        {
            _accounts.Drop();
        }

        public ApdAccount Load(Guid accountId)
        {
            var account =
                _accounts.AsQueryable<ApdAccount>()
                    .FirstOrDefault(x => x.AccountId == accountId);

            return account;
        }

        public void Save(Guid accountId, ApdAccount account)
        {
            _accounts.Save(account);
        }
    }
}