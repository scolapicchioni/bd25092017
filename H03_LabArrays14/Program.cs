using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays14 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to insert New value in the array (unsorted list ). 
Test Data : 
Input the size of array : 4 
Input 4 elements in the array in ascending order: 
element - 0 : 1 
element - 1 : 8 
element - 2 : 7 
element - 3 : 10 
Input the value to be inserted : 5 
Input the Position, where the value to be inserted :2 
Expected Output :
The current list of the array :
1 8 7 10 
After Insert the element the new list is :
1 5 8 7 10 
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input the value to be inserted : ");
            int newValue = int.Parse(Console.ReadLine());

            Console.Write($"Input position where to insert {newValue}: ");
            int position = int.Parse(Console.ReadLine());
            
            int[] temp = new int[list.Length + 1];

            for (int i = 0; i < position; i++) {
                temp[i] = list[i];
            }

            temp[position] = newValue;
            for (int i = position; i < list.Length; i++) {
                temp[i + 1] = list[i];
            }

            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine($"{temp[i]}");
            }
            Console.ReadLine();
        }
    }
}
