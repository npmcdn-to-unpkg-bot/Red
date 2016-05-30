//using System;
//using Autofac;

//namespace AutoFac
//{
//    class Program2
//    {
//        private static IContainer Container { get; set; }

//        static void Main()
//        {
//            ContainerBuilder builder = new ContainerBuilder();
//            builder.RegisterType<FakePerson>().As<PersonBase>();
//            builder.RegisterType<PersonHandler>();
//            var context = builder.Build();
//            var handler = context.Resolve<PersonHandler>();
//            handler.DoWork();

//            Console.WriteLine("Press any key to continue");
//            Console.ReadLine();
//        }

//        class PersonBase
//        {
//            public virtual string SaySomething()
//            {
//                return "I am base";
//            }
//        }

//        class FakePerson : PersonBase
//        {
//            public override string SaySomething()
//            {
//                return "I'm so Fake";
//            }
//        }

//        class RealPerson : PersonBase
//        {
//            public override string SaySomething()
//            {
//                return "I am For Real";
//            }
//        }

//        class PersonHandler
//        {
//            private readonly Func<PersonBase> _createPerson;

//            public PersonHandler(Func<PersonBase> createPerson)
//            {
//                _createPerson = createPerson;
//            }

//            public void DoWork()
//            {
//                PersonBase pb = _createPerson();
//                Console.WriteLine(pb.SaySomething());
//            }
//        }
//    }
//}
