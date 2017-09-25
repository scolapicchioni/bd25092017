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

            //step 1:
            //asks the age of the user 

            Console.Write("How old are you?");
            string userAge = Console.ReadLine();

            //step 2:
            // convert to int
            int age = int.Parse(userAge);

            //step 3:
            // write True if the age is greater than 18
            Console.WriteLine(age > 18);

            Console.ReadLine();


        }
    }
}
