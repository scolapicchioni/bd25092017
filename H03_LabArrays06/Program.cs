﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays06 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to print all unique elements in an array. 
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 1 
element - 1 : 5 
element - 2 : 1 
Expected Output : 
The unique elements found in the array are : 
5 
*/
            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            int[] distinct = new int[howMany];
            int counter = 0;

            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
                if (Array.IndexOf(distinct, list[i]) == -1) {
                    distinct[counter++] = list[i];
                }
            }

            Console.WriteLine("The unique elements found in the array are : ");
            for (int i = 0; i < counter; i++) {
                Console.WriteLine(distinct[i]);
            }

            Console.ReadLine();
        }
    }
}
