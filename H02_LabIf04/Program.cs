using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf04 {
    class Program {
        static void Main(string[] args) {
            /*
             * Let the user insert 3 numbers
                Output the highest number
            */
            Console.WriteLine("First: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Third: ");
            int n3 = int.Parse(Console.ReadLine());

            int max;
            if (n1 > n2) {
                if (n1 > n3) {
                    max = n1;
                } else {
                    max = n3;
                }
            } else {
                if (n2 > n3) {
                    max = n2;
                } else {
                    max = n3;
                }
            }
            Console.WriteLine($"Max between {n1}, {n2} and {n3} is {max}");

            Console.ReadLine();
        }
    }
}
