//using System;
//using Autofac;

//namespace AutoFac
//{
//    class Program1
//    {
//        private static IContainer Container { get; set; }

//        static void Main()
//        {
//            var builder = new ContainerBuilder();
//            builder.RegisterType<ConsoleOutput>().As<IOutput>();
//            builder.RegisterType<TodayWriter>().As<IDateWriter>();
//            Container = builder.Build();

//            WriteDate();

//            Console.WriteLine("Press any key to continue");
//            Console.ReadLine();
//        }

//        public static void WriteDate()
//        {
//            using (var scope = Container.BeginLifetimeScope())
//            {
//                var writer = scope.Resolve<IDateWriter>();
//                writer.WriteDate();
//            }
//        }
//    }

//    public interface IOutput
//    {
//        void Write(string content);
//    }

//    public class ConsoleOutput : IOutput
//    {
//        public void Write(string content)
//        {
//            Console.WriteLine(content);
//        }
//    }

//    public interface IDateWriter
//    {
//        void WriteDate();
//    }

//    public class TodayWriter : IDateWriter
//    {
//        private readonly IOutput _output;

//        public TodayWriter(IOutput output)
//        {
//            _output = output;
//        }

//        public void WriteDate()
//        {
//            _output.Write(DateTime.Today.ToShortDateString());
//        }
//    }
//}
