using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays01 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to store elements in an array and print it. 
Test Data: 
Input 10 elements in the array: 
element - 0 : 1 
element - 1 : 3 
element - 2 : 2
element - 3 : 4
element - 4 : 8
element - 5 : 2
element - 6 : 9
element - 7 : 2
element - 8 : 8
element - 9 : 2 
....... 
Expected Output : 
Elements in array are: 1 3 2 4 8 2 9 2 8 2
             */

            int[] list = { 1 ,3 ,2, 4, 8, 2, 9, 2, 8, 2 };

            Console.Write("Elements in array are: ");
            foreach (int item in list) {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
