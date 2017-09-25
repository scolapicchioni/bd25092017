using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that asks the age of the user and writes True if the age is greater than 18
            */

            Console.WriteLine("How old are you?");

            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);
            bool greaterThan18 = age > 18; 
            Console.WriteLine(greaterThan18);
            Console.ReadLine();


        }
    }
}
