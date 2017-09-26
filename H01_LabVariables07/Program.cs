using System;

namespace H01_LabVariables07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Vraag op de naam van de user, dan print
             - hoe lang het is
             - de eerste letter van de naam
             - de laatste letter van de naam
            */

            Console.Write("Name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName} is {userName.Length} letters long");
            Console.WriteLine($"The first letter of {userName} is {userName.Substring(0,1)}");
            Console.WriteLine($"The last letter of {userName} is {userName.Substring(userName.Length-1, 1)}");
            Console.ReadLine();
        }
    }
}
