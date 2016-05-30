//using System;
//using Autofac;
//using Autofac.Features.Indexed;
//using AutoFac.Properties;

//namespace AutoFac
//{
//    class Program4
//    {
//        interface IBuildStateFromDocuments
//        {
//            bool Apply(object document);
//        }

//        interface IMiEvent
//        {
//            string AccountId { get; set; }
//        }

//        class ContactPreferencesUpdated : IBuildStateFromDocuments, IMiEvent
//        {
//            public bool Apply(object document)
//            {
//                throw new NotImplementedException();
//            }

//            public string AccountId { get; set; }
//        }

//        class MainPersonUpdated : IBuildStateFromDocuments, IMiEvent
//        {
//            public bool Apply(object document)
//            {
//                throw new NotImplementedException();
//            }

//            public string AccountId { get; set; }
//        }

//        class MainPersonUpdated2 : IBuildStateFromDocuments, IMiEvent
//        {
//            public bool Apply(object document)
//            {
//                throw new NotImplementedException();
//            }

//            public string AccountId { get; set; }
//        }

//        class PersonalDetailsUpdated : IBuildStateFromDocuments, IMiEvent
//        {
//            public bool Apply(object document)
//            {
//                throw new NotImplementedException();
//            }

//            public string AccountId { get; set; }
//        }

//        class PersonalDetailsUpdated2 : IBuildStateFromDocuments, IMiEvent
//        {
//            public bool Apply(object document)
//            {
//                throw new NotImplementedException();
//            }

//            public string AccountId { get; set; }
//        }

//        enum ProjectionTypes
//        {
//            ContactPreferencesUpdated,
//            MainPersonUpdated,
//            PersonalDetailsUpdated,
//        }

//        static IContainer _container;

//        static void Main()
//        {
//            BuildContainer();

//            using (var scope = _container.BeginLifetimeScope())
//            {
//                var eventSink = scope.Resolve<EventSink>();
//                eventSink.SendEvent(ProjectionTypes.ContactPreferencesUpdated);
//            }

//            Console.WriteLine("Press any key to continue");
//            Console.ReadLine();
//        }

//        static void BuildContainer()
//        {
//            ContainerBuilder containerBuilder = new ContainerBuilder();
//            containerBuilder.RegisterType<ContactPreferencesUpdated>().Keyed<IMiEvent>(ProjectionTypes.ContactPreferencesUpdated);
//            if (Settings.Default.Version == "v1")
//            {
//                containerBuilder.RegisterType<MainPersonUpdated>().Keyed<IMiEvent>(ProjectionTypes.MainPersonUpdated);
//                containerBuilder.RegisterType<PersonalDetailsUpdated>().Keyed<IMiEvent>(ProjectionTypes.PersonalDetailsUpdated);
//            }
//            else if (Settings.Default.Version == "v2")
//            {
//                containerBuilder.RegisterType<MainPersonUpdated2>().Keyed<IMiEvent>(ProjectionTypes.MainPersonUpdated);
//                containerBuilder.RegisterType<PersonalDetailsUpdated2>().Keyed<IMiEvent>(ProjectionTypes.PersonalDetailsUpdated);
//            }
//            else
//            {
//                throw new Exception();
//            }
//            containerBuilder.RegisterType<EventSink>();
//            _container = containerBuilder.Build();
//        }

//        class EventSink
//        {
//            readonly IIndex<ProjectionTypes, IMiEvent> _events;

//            public EventSink(IIndex<ProjectionTypes, IMiEvent> events)
//            {
//                _events = events;
//            }

//            public void SendEvent(ProjectionTypes type)
//            {
                
//            }
//        }
//    }
//}
