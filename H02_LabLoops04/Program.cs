using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops04 {
    class Program {
        static void Main(string[] args) {
            /*
             * Schrijf een programma dat een getal inleest 
             * en vervolgens bepaalt of dit getal een priemgetal is.
             */


            Console.Write("\n\n");
            Console.Write("Check whether a given number is prime or not:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  a number: ");
            int num = int.Parse(Console.ReadLine());
            int ctr = 0;
            for (int i = 2; i <= num / 2; i++) {
                if (num % i == 0) {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                Console.WriteLine($"{num} is a prime number");
            else
                Console.WriteLine($"{num} is not a prime number");
            Console.ReadLine();
        }

    }
}

