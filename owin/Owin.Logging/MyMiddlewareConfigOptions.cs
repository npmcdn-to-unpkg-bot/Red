using System;

namespace Owin.Logging
{
    public class MyMiddlewareConfigOptions
    {
        string _greetingTextFormat = "<h1>{0} from {1}{2}</h1>";

        public MyMiddlewareConfigOptions(string greeting, string greeter)
        {
            GreetingText = greeting;
            Greeter = greeter;
            Date = DateTime.Now;
        }

        public string GreetingText { get; set; }

        public string Greeter { get; set; }

        public DateTime Date { get; set; }

        public bool IncludeDate { get; set; }

        public string GetGreeting()
        {
            string dateText = "";
            if (IncludeDate)
            {
                dateText = $" on {Date.ToShortDateString()}";
            }
            return string.Format(_greetingTextFormat, GreetingText, Greeter, dateText);
        }
    }
}