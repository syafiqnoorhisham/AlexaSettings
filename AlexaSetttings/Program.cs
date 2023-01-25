using System;

namespace AlexaSetttings
{
    class Program
    {
        private static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }
    }
    class Alexa
    {
        public string GreetingMessage { get; set; } = "Hello, I am Alexa";
        public string OwnerName { get; set; }

        public void Configure(Action<Alexa> config)
        {
            config(this);
        }

        public string Talk()
        {
            return GreetingMessage.Replace("{OwnerName}", OwnerName);
        }
    }
}
