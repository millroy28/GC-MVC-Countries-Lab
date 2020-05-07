using System;
using System.Collections.Generic;
using System.Text;

namespace GC_MVC_Countries
{
    class CountryView
    {
        public Country DisplayCountry = new Country();
        public CountryView() { }
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"Country Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.Write("Country Colors: ");
            foreach (ConsoleColor color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = color;
                Console.Write($"\t{color}");
                Console.ResetColor();
            }
        }


    }
}
