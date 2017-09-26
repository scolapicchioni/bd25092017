using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf02 {
    class Program {
        static void Main(string[] args) {
            /*
             * Let's ask the user a minimum value, 
             * a maximum value and a number. 
             * Let's output if the number 
             * fits in between the range or not.
             */

            Console.WriteLine("Min: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Max: ");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= min && number <= max) {
                Console.WriteLine($"{number} is in range between {min} and {max}");
            } else {
                Console.WriteLine($"{number} is not in range between {min} and {max}");
            }
            Console.ReadLine();
        }
    }
}
