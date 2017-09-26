using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            1 - Vraag of de user "Game Of Thrones" leuk vindt
            2 - Vraag of de user "Breaking Bad" leuk vindt
            3 - Vraag of de user "Doctor Who" leuk vindt
            4 - Schrijf "true" als de user tenminste een TV Serie leuk vindt
            5 - Schrijf "true" als de user alle de 3 TV Series leuk vindt
            6 - Schrijf "true" als de user geen TV Serie leuk vindt
            */

            Console.Write("Do you like Game Of Thrones (y/n)? ");
            string userChoice = Console.ReadLine();
            bool gameOfThrones = userChoice.ToLower() == "y"; //y Y

            Console.Write("Do you like Breaking Bad (y/n)? ");
            userChoice = Console.ReadLine();
            bool breakingBad = userChoice.ToLower() == "y";

            Console.Write("Do you like Doctor Who (y/n)? ");
            userChoice = Console.ReadLine();
            bool doctorWho = userChoice.ToLower() == "y";

            bool allThree = gameOfThrones && breakingBad && doctorWho;
            bool atLeastOne = gameOfThrones || breakingBad || doctorWho;
            bool none = !gameOfThrones && !breakingBad && !doctorWho;

            Console.WriteLine($"You like them all: {allThree}");
            Console.WriteLine($"You like at least one: {atLeastOne}");
            Console.WriteLine($"You like none: {none}");

            Console.ReadLine();

        }
    }
}
