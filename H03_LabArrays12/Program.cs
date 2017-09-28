using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays12 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to sort elements of the array in descending order. 
Test Data : 
Input the size of array : 3 
Input 3 elements in the array : 
element - 0 : 5 
element - 1 : 9 
element - 2 : 1
Expected Output : 
Elements of the array in sorted descending order: 
9 5 1
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];


            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(list);
            Array.Reverse(list);

            Console.WriteLine("Elements of array in sorted descending order: ");
            foreach (int item in list) {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
