using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays15 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to delete an element at desired position from an array. 
Test Data : 
Input the size of array : 5 
Input 5 elements in the array in ascending order: 
element - 0 : 1 
element - 1 : 2 
element - 2 : 3 
element - 3 : 4 
element - 4 : 5 
Input the position where to delete: 3 
Expected Output : 
The new list is : 1 2 4 5
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"Input position to delete: ");
            int position = int.Parse(Console.ReadLine());

            int[] temp = new int[list.Length - 1];

            for (int i = 0; i < position; i++) {
                temp[i] = list[i];
            }

            for (int i = position+1; i < list.Length; i++) {
                temp[i - 1] = list[i];
            }

            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine($"{temp[i]}");
            }
            Console.ReadLine();
        }
    }
}
