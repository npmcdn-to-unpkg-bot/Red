using System;
using MongoDB.Driver.Builders;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DropRepository();

            var accountId = Guid.NewGuid();

            AddAccount(accountId);

            var account = GetAccount(accountId);
            if (account.Person.FirstName != "John")
                throw new Exception();

            UpdateAccount(account);

            account = GetAccount(accountId);
            if (account.Person.FirstName != "Jane")
                throw new Exception();
        }

        private static void DropRepository()
        {
            var repository = new ApdRepository();
            repository.Drop();
        }

        static ApdAccount GetAccount(Guid accountId)
        {
            var repository = new ApdRepository();

            return repository.Load(accountId);
        }

        static void AddAccount(Guid accountId)
        {
            var repository = new ApdRepository();

            var account = new ApdAccount
            {
                AccountId = accountId,
                Version = 1,
                Person = new ApdPerson
                {
                    FirstName = "John",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1999, 12, 31),
                    EmploymentStatus = "Employed"
                },
            };

            repository.Save(accountId, account);
        }

        static void UpdateAccount(ApdAccount account)
        {
            var repository = new ApdRepository();

            account.Person.FirstName = "Jane";
            account.Person.LastName = "Jones";
            account.Person.DateOfBirth = new DateTime(1950, 6, 15);

            repository.Save(account.AccountId, account);
        }

    }
}
