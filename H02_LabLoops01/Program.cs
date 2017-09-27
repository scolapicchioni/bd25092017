using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops01 {
    class Program {
        static void Main(string[] args) {
            /*
             * Schrijf een programma dat 10 getallen inleest 
             * van het toetsenbord en vervolgens 
             * de som van die getallen afdrukt.
             */
            int total = 0;
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Number?");
                int n = int.Parse(Console.ReadLine());
                total += n;
            }
            Console.WriteLine($"The total is {total}");
            Console.ReadLine();
        }
    }
}
