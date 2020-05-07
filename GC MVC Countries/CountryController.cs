using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GC_MVC_Countries
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>();

        public CountryController()
        {
            List<ConsoleColor> CanCol = new List<ConsoleColor>();
            CanCol.Add(ConsoleColor.Red); CanCol.Add(ConsoleColor.White);
            CountryDb.Add(new Country("Canada", "North America", CanCol));

            List<ConsoleColor> MonCol = new List<ConsoleColor>();
            MonCol.Add(ConsoleColor.Black); MonCol.Add(ConsoleColor.Green); MonCol.Add(ConsoleColor.Blue); MonCol.Add(ConsoleColor.Red); MonCol.Add(ConsoleColor.White);
            CountryDb.Add(new Country("Monsterrat", "North America", MonCol));

            List<ConsoleColor> BolCol = new List<ConsoleColor>();
            BolCol.Add(ConsoleColor.Red); BolCol.Add(ConsoleColor.Yellow); BolCol.Add(ConsoleColor.Green);
            CountryDb.Add(new Country("Bolivia", "South America", BolCol));

            List<ConsoleColor> PerCol = new List<ConsoleColor>();
            PerCol.Add(ConsoleColor.Red); PerCol.Add(ConsoleColor.White);
            CountryDb.Add(new Country("Peru", "South America", PerCol));

            List<ConsoleColor> JanCol = new List<ConsoleColor>();
            JanCol.Add(ConsoleColor.Red); JanCol.Add(ConsoleColor.White);
            CountryDb.Add(new Country("Japan", "Asia", JanCol));

            List<ConsoleColor> SCCol = new List<ConsoleColor>();
            SCCol.Add(ConsoleColor.Red); SCCol.Add(ConsoleColor.White); SCCol.Add(ConsoleColor.Blue); SCCol.Add(ConsoleColor.Black);
            CountryDb.Add(new Country("South Korea", "Asia", SCCol));

            List<ConsoleColor> BelCol = new List<ConsoleColor>();
            BelCol.Add(ConsoleColor.Red);
            CountryDb.Add(new Country("Belgium", "Europe", BelCol));

            List<ConsoleColor> FraCol = new List<ConsoleColor>();
            FraCol.Add(ConsoleColor.Blue); FraCol.Add(ConsoleColor.White); FraCol.Add(ConsoleColor.Red);
            CountryDb.Add(new Country("France", "Europe", CanCol));



        }



        public void CountryAction(Country c)
        {
            CountryView viewThisCountry = new CountryView(c);
            viewThisCountry.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            bool contRun = true;
            while (contRun)
            {
                Console.Clear();
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                clv.Display();
                int selection = SelectCountry(CountryDb);
                CountryAction(CountryDb[selection]);
                Console.WriteLine();
                contRun = GetYesOrNo("Would you like to select another country? y/n: ");
            }



        }

        public int SelectCountry(List<Country> cdb)
        {   
            int selection;
            while (true)
            {
                try
                {
                    selection = int.Parse(Console.ReadLine()) - 1;
                    string test = cdb[selection].Name;
                    return selection;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number: ");
                    Console.ResetColor();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a country on record. Please try again: ");
                    Console.ResetColor();
                }
            }
        }
        public static bool GetYesOrNo(string prompt)
        {
            //Prompts user for y/n; returns true for y and false for n
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. " + prompt);
                    Console.ResetColor();
                }
                    
            }
        }

    }
}
