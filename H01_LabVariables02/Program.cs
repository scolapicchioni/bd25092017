using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program in C# Sharp to insert a substring 
             * before the first occurrence of a string

            Test Data : 
            Input the original string : this is a string 
            Input the string to be searched for : a 
            Input the string to be inserted : test 
            
            Expected Output :
            The modified string is : this is testa string
             
            */

            Console.Write("Original String: ");
            string original = Console.ReadLine();
            Console.Write("String to be searched: ");
            string toBeSearched = Console.ReadLine();
            Console.Write("String to insert: ");
            string toInsert = Console.ReadLine();

            int position = original.IndexOf(toBeSearched);

            string result = original.Insert(position, toInsert);

            //string result = original.Insert(original.IndexOf(toBeSearched), toInsert);
            Console.WriteLine(result);
            Console.ReadLine();

            
        }
    }
}
