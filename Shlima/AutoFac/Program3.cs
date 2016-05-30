//using System;
//using Autofac;

//namespace AutoFac
//{
//    class Program3
//    {
//        interface IBuildStateFromDocuments
//        {
//            bool Apply(object document);
//        }

//        interface IMiEvent
//        {
//            string AccountId { get; set; }
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

//        static void Main()
//        {
//            ContainerBuilder builder = new ContainerBuilder();
//            builder.RegisterType<MainPersonUpdated2>().As<IMiEvent>();
//            builder.RegisterType<ProjectionFactory>();
//            var container = builder.Build();

//            var projectionFactory = container.Resolve<ProjectionFactory>();
//            var projection = projectionFactory.GetProjection();

//            Console.WriteLine(projection.GetType().Name);
//            Console.WriteLine("Press any key to continue");
//            Console.ReadLine();
//        }

//        class ProjectionFactory
//        {
//            private readonly Func<IMiEvent> _mainPersonUpdatedProjection;

//            public ProjectionFactory(Func<IMiEvent> mainPersonUpdatedProjection)
//            {
//                _mainPersonUpdatedProjection = mainPersonUpdatedProjection;
//            }

//            public IMiEvent GetProjection()
//            {
//                return _mainPersonUpdatedProjection();
//            }
//        }
//    }
//}
