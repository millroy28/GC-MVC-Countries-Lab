using System;
using System.Collections.Generic;
using System.Text;

namespace GC_MVC_Countries
{
    class Country
    {
        public string Name { get; set; }

        public string Continent { get; set; }

        public List<ConsoleColor> Colors = new List<ConsoleColor>();

        public Country() { }
        public Country(string name, string continent, List<ConsoleColor> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }


    }
}
