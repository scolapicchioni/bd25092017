﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_LabArrays04 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program in C# Sharp to copy the elements one array into another array. 
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 15 
element - 1 : 10 
element - 2 : 12 
Expected Output: 
The elements stored in the first array are : 
15 10 12 
The elements copied into the second array are : 
15 10 12 
*/

            Console.Write("How many elements do you want to store? ");
            int howMany = int.Parse(Console.ReadLine());

            int[] list = new int[howMany];
            
            for (int i = 0; i < list.Length; i++) {
                Console.Write($"Element {i}: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            int[] copy = new int[list.Length];
            for (int i = 0; i < list.Length; i++) {
                copy[i] = list[i];
            }

            Console.WriteLine("The elements stored in the first array are : ");
            for (int i = 0; i < list.Length; i++) {
                Console.Write($"{list[i]} ");
            }

            Console.WriteLine("\nThe elements copied into the second array are : ");
            for (int i = 0; i < copy.Length; i++) {
                Console.Write($"{copy[i]} ");
            }
            Console.ReadLine();

        }
    }
}
