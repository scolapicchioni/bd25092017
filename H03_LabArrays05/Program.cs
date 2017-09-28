using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays05 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to count a total number of duplicate elements in an array.
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 5 
element - 1 : 1 
element - 2 : 1 
Expected Output : 
Total number of duplicate elements found in the array is : 1 
*/
            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(list);

            int prev = list[0];
            int prevDuplicate = list[0] - 1; //I hope the user did not insert the minimum possible int...
            int duplicates = 0;
            for (int i = 1; i < list.Length; i++) {
                //Console.WriteLine($"Comparing {prev} with {list[i]}, previous duplicate is {prevDuplicate}");
                if (prev == list[i]) { //gotcha!
                    //Console.WriteLine($"{prev} == {list[i]}!");
                    if (list[i] != prevDuplicate) { //it's not the same number AGAIN
                        //Console.WriteLine($"{list[i]} != {prevDuplicate}!");
                        duplicates++;
                        prevDuplicate = list[i];
                        //Console.WriteLine($"duplicates so far: {duplicates}");
                    }
                }
                prev = list[i];
            }
            Console.WriteLine($"Total number of duplicate elements found in the array is : {duplicates}");
            Console.ReadLine();
        }
    }
}
