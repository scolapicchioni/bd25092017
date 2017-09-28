using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays07 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
Test Data : 
Input the number of elements to be stored in the first array :3 
Input 3 elements in the array : 
element - 0 : 1 
element - 1 : 2 
element - 2 : 3 
Input the number of elements to be stored in the second array :3 
Input 3 elements in the array: 
element - 0 : 1 
element - 1 : 2 
element - 2 : 3 
Expected Output: 
The merged array in ascending order is : 
1 1 2 2 3 3 
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list1 = new int[howMany];

            for (int i = 0; i < list1.Length; i++) {
                Console.Write($"Element {i}: ");
                list1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(list1);
            Console.WriteLine("*******SECOND LIST************");
            int[] list2 = new int[howMany];

            for (int i = 0; i < list2.Length; i++) {
                Console.Write($"Element {i}: ");
                list2[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(list2);

            int[] merged = new int[howMany * 2];

            for (int listIndex = 0, mergedIndex=0 ; listIndex < list1.Length; listIndex++, mergedIndex+=2) {
                merged[mergedIndex] = list1[listIndex];
                merged[mergedIndex+1] = list2[listIndex];
            }

            Console.WriteLine("\nThe merged array is : ");
            for (int i = 0; i < merged.Length; i++) {
                Console.Write(merged[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
