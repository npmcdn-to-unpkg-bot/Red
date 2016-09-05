using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation
{
    public class CisPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string TelephoneNumber { get; set; }
    }

    public interface ICisStore
    {
        int Version { get; set; }

        Guid AccountId { get; }

        IReadOnlyCollection<CisPerson> People { get; }

        CisPerson MainPerson { get; }

        void AddPerson(CisPerson person);

        void UpdatePerson(CisPerson person);

        void DeletePerson();
    }

    public interface ICisRepository
    {
        ICisStore Load(Guid accountId);

        void Save(ICisStore cisStore);
    }

    public class ApdPerson
    {
        public int Version { get; set; }

        public Guid AccountId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmploymentStatus { get; set; }
    }

    public interface IApdRepository
    {
        ApdPerson Load(Guid accountId);

        void Save(Guid accountId, ApdPerson person);
    }

    public class AccountDto
    {
        public Guid AccountId { get; }

        public IReadOnlyCollection<Person> People { get; set; }

        public Person MainPerson { get; }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string TellephoneNumber { get; set; }

        public string EmploymentStatus { get; set; }

        public CisPerson ToCisPerson()
        {
            return new CisPerson();
        }

        public ApdPerson ToApdPerson(int version)
        {
            return new ApdPerson
            {
                Version = version
            };
        }

        public interface IMap<x, y>
        {
            x Map(y source);

        }

        public AccountDto From(ICisStore cisStore, ApdPerson apdPerson)
        {
            IMap<Person, CisPerson> personMap;
            return new AccountDto
            {
                People = cisStore.People.Select(personMap.Map).ToList()
            };
        }
    }

    public class Service
    {
        private readonly ICisRepository _cisRepository;

        private readonly IApdRepository _apdRepository;

        public Service(
            ICisRepository cisRepository,
            IApdRepository apdRepository)
        {
            _cisRepository = cisRepository;
            _apdRepository = apdRepository;
        }

        public CisPerson GetAccount(Guid accountId)
        {
            var cisStore = _cisRepository.Load(accountId);      //load the account from the event store repo.

            var apdAccount = _apdRepository.Load(accountId);    //load the account from the crud store.

            if (cisStore.Version == apdAccount.Version)         //check the versions are the same.
            {

            }

            throw new NotImplementedException();
        }

        public void AddPerson(Guid accountId, Person person)
        {
            var cisStore = _cisRepository.Load(accountId);      //load the account from the event store repo.

            var cisPerson = person.ToCisPerson();               //create an event store person from the person.

            cisStore.AddPerson(cisPerson);                      //add the event store person to the account.
                                                                //needs to throw is person already exists.

            _cisRepository.Save(cisStore);                      //save the account to the event store repo.
                                                                //needs to throw for concurrency issues.

            var version = cisStore.Version;                     //get the version from the account (was updated when we saved the account).

            var apdPerson = person.ToApdPerson(version);        //create a crud store person from the person.

            _apdRepository.Save(accountId, apdPerson);          //save the crud store person to the crud store repo. 
                                                                //needs to throw for concurrency issues. 
                                                                //needs to throw for version number inconsistencies.
        }

        public void UpdatePerson(Guid accountId, Person person)
        {
            var cisStore = _cisRepository.Load(accountId);      //load the account from the event store repo.

            var cisPerson = person.ToCisPerson();               //update the event store person from the data in person.

            cisStore.UpdatePerson(cisPerson);                   //add the event store person to the account.
                                                                //needs to throw is person doesn't already exists.

            _cisRepository.Save(cisStore);                      //save the account to the event store repo.
                                                                //needs to throw for concurrency issues.

            var version = cisStore.Version;                     //get the version from the account (was updated when we saved the account).

            var apdPerson = person.ToApdPerson(version);        //create a crud store person from the person.

            _apdRepository.Save(accountId, apdPerson);                     //save the crud store person to the crud store repo. 
                                                                           //needs to throw for concurrency issues. 
                                                                           //needs to throw for version number inconsistencies.
        }
    }
}
