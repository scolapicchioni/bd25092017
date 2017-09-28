using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays02 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
Test Data : 
Input the number of elements to store in the array :3 
Input 3 number of elements in the array : 
element - 0 : 2 
element - 1 : 5 
element - 2 : 7 
Expected Output: 
The values store into the array are: 
2 5 7 
The values store into the array in reverse are : 
7 5 2 
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*****************");
            for (int i = 0; i < list.Length; i++) {
                Console.WriteLine($"list[{i}] == {list[i]}");
            }

            Console.WriteLine("****REVERSED*****");
            for (int i = list.Length-1; i >= 0; i--) {
                Console.WriteLine($"list[{i}] == {list[i]}");
            }

            Console.ReadLine();
        }
    }
}
