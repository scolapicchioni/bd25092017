using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops02 {
    class Program {
        static void Main(string[] args) {
            /*
             * Schrijf een programma dat een (willekeurig) aantal getallen inleest 
             * van het toetsenbord (afgesloten door een 0) 
             * en vervolgens de som van die getallen afdrukt.
             */

            int total = 0;
            int n = -1;
            while (n != 0) {
                Console.Write("Enter a number (0 to stop): ");
                n = int.Parse(Console.ReadLine());
                total += n;
            }
            Console.WriteLine($"The total is {total}");
            Console.ReadLine();
        }
    }
}
