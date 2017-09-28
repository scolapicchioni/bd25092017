using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays11 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to sort elements of array in ascending order. 
Test Data : 
Input the size of array : 5 
Input 5 elements in the array : 
element - 0 : 2 
element - 1 : 7 
element - 2 : 4 
element - 3 : 5 
element - 4 : 9 
Expected Output : 
Elements of array in sorted ascending order: 
2 4 5 7 9
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(list);

            Console.WriteLine("Elements of array in sorted ascending order: ");
            foreach (int item in list) {
                Console.Write(item + " " );
            }
            Console.ReadLine();
        }
    }
}
