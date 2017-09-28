using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays13 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to insert New value in the array (sorted list ). 
Test Data : 
Input the size of array : 3 
Input 3 elements in the array in ascending order: 
element - 0 : 5 
element - 1 : 7 
element - 2 : 9 
Input the value to be inserted : 8 
Expected Output : 
The exist array list is : 
5 7 9 
After Insert the list is : 
5 7 8 9
*/
            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];


            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(list); //just to be sure...

            Console.Write("Input the value to be inserted : ");
            int newValue = int.Parse(Console.ReadLine());

            int[] temp = new int[list.Length + 1];
            int position = 0;
            for (int i = 0; i < list.Length; i++) {
                if (list[i] <= newValue) {
                    temp[i] = list[i];
                } else {
                    position = i;
                    break;
                }
            }

            temp[position] = newValue;
            for (int i = position ; i < list.Length; i++) {
                temp[i + 1] = list[i];
            }

            
            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine($"{temp[i]}");
            }
            Console.ReadLine();
        }
    }
}
