using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays09 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to separate odd and even integers in separate arrays. 
Test Data : 
Input the number of elements to be stored in the array :5 
Input 5 elements in the array : 
element - 0 : 25 
element - 1 : 47 
element - 2 : 42 
element - 3 : 56 
element - 4 : 32 
Expected Output: 
The Even elements are: 
42 56 32 
The Odd elements are : 
25 47
*/
            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            int[] odds = new int[howMany];
            int[] evens = new int[howMany];
            int oddCounter = 0, evenCounter = 0;

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
                if (list[i] % 2 == 0) {
                    evens[evenCounter++] = list[i];
                } else {
                    odds[oddCounter++] = list[i];
                }
            }

            Console.WriteLine("The Even elements are: ");

            for (int i = 0; i < evenCounter; i++) {
                Console.Write(evens[i] + " ");
            }

            Console.WriteLine("The Odd elements are: ");

            for (int i = 0; i < oddCounter; i++) {
                Console.Write(odds[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
