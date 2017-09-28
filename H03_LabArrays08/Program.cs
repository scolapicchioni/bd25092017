using System;

namespace H03_LabArrays08 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to count the frequency of each element of an array. 
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 25 
element - 1 : 12 
element - 2 : 43 
Expected Output : 
Frequency of all elements of array : 
25 occurs 1 times 
12 occurs 1 times 
43 occurs 1 times
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            int[] distinct = new int[howMany];
            int[] counters = new int[howMany];
            int counter = 0;

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
                int position = Array.IndexOf(distinct, list[i]);
                if (position != -1) {
                    counters[position]++;
                } else {
                    distinct[counter] = list[i];
                    counters[counter]++;
                    counter++;
                }
            }

            for (int i = 0; i < counter; i++) {
                Console.WriteLine($"{distinct[i]} has been found {counters[i]} times");
            }

            Console.ReadLine();
        }
    }
}
