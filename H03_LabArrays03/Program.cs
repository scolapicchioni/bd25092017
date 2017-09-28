using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays03 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to find the sum of all elements of the array. 
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 2 
element - 1 : 5 
element - 2 : 8 
Expected Output : 
Sum of all elements stored in the array is : 15 
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            int total = 0;
            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
                total += list[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is : {total}");
            Console.ReadLine();
        }
    }
}
