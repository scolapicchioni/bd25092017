using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays10 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to find maximum and minimum element in an array. 
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 45 
element - 1 : 25 
element - 2 : 21 
Expected Output : 
Maximum element is : 45 
Minimum element is : 21
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
                if (max < list[i]) max = list[i];
                if (min > list[i]) min = list[i];
            }

            Console.WriteLine($"The maximum element is: {max}");
            Console.WriteLine($"The minimum element is: {min}");
            Console.ReadLine();
        }
    }
}
