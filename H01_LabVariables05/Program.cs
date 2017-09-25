using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Write a C# Sharp program that takes two numbers as input 
            and writes True if the first number is a multiple of the second number

            Test Data
            Number 1: 20
            Number 2: 5

            Expected result 
            "20 is a multiple of 5: True"

            Number 1: 21
            Number 2: 5

            Expected result 
            "21 is a multiple of 5: False"
            
             */

            Console.Write("First number:");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Second number:");
            int second = int.Parse(Console.ReadLine());

            bool multiple = first % second == 0;

            Console.WriteLine($"{first} is a multiple of {second}: {multiple}");

            Console.ReadLine();
        }
    }
}
