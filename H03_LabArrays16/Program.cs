using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays16 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to find the second largest element in an array. 
Test Data : 
Input the size of array : 5 
Input 5 elements in the array : 
element - 0 : 2 
element - 1 : 9 
element - 2 : 1 
element - 3 : 4 
element - 4 : 6 
Expected Output : 
The Second largest element in the array is: 6 
*/
            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list1 = new int[howMany];

            for (int i = 0; i < list1.Length; i++) {
                Console.Write($"Element {i}: ");
                list1[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
