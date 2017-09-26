using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf05 {
    class Program {
        static void Main(string[] args) {
            /*
             * Generate a random number between 1 and 10.
            Let the user guess the number.
            Print if the user guessed too high, too low, or if he guessed correctly.
            */

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,11);

            Console.WriteLine("Guess a number between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number) {
                Console.WriteLine($"YOU GUESSED RIGHT!! {number} == {guess}");
            } else if(guess > number) { 
                Console.WriteLine($"Too high {number} < {guess}");
            }else{
                Console.WriteLine($"Too low {number} > {guess}");
            }
            Console.ReadLine();
        }
    }
}
