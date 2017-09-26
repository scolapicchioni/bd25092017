using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf01 {
    class Program {
        static void Main(string[] args) {
            /*
             *  1) Ask the user "How old are you?"
                2) Print the age on the screen: 
	                - In red if he's under 18
	                - In yellow if he's between 18 and 65
	                - In green if he's over 65
            */

            Console.Write("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age < 18) {
                Console.ForegroundColor = ConsoleColor.Red;
            } else if (age > 65) {
                Console.ForegroundColor = ConsoleColor.Green;
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine($"Your age is {age}");

            Console.ReadLine();
        }
    }
}
