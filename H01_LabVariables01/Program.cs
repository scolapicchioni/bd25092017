using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# Sharp program to determine 
             * 1) whether a string is contained in another string
             * 2) At what position the substring can be found (-1 if not present)

            Test Data: 
            String1 : "Kill two birds with one stone"
            String2 : "birds"

            Expected Output :

            'birds' is in the string 'Kill two birds with one stone': True
            'birds begins at character position 9

            Test Data: 
            String1 : "Kill two birds with one stone"
            String2 : "TWO"

            Expected Output :

            'TWO' is in the string 'Kill two birds with one stone': True
            'TWO begins at character position 5

            Test Data: 
            String1 : "Kill two birds with one stone"
            String2 : "stoone"

            Expected Output :

            'stoone' is in the string 'Kill two birds with one stone': False
            'stoone begins at character position -1

            */

            Console.WriteLine("Insert the first string");
            string first = Console.ReadLine();
            Console.WriteLine("Insert the second string");
            string second = Console.ReadLine();

            string firstToLower = first.ToLower();
            string secondToLower = second.ToLower();

            bool result = firstToLower.Contains(secondToLower);
            int position = firstToLower.IndexOf(secondToLower);

            Console.WriteLine($"{second} is contained in {first}: {result}");
            Console.WriteLine($"{second} begins at character position: {position}");

            Console.ReadLine();
        }
    }
}
