using System;
using System.Collections.Generic;

namespace GC_MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountryController run = new CountryController();
            run.WelcomeAction();


            //List<ConsoleColor> colors = new List<ConsoleColor>();
            //colors.Add(ConsoleColor.Red);
            //Console.ForegroundColor = colors[0];
            //Console.WriteLine("testc");
        }
    }
}
