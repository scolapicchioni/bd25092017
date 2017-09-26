using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_IfAndLoops {
    class Program {
        static void Main(string[] args) {
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            //if
            if (age > 18) {
                Console.WriteLine("Welcome");
                Console.WriteLine("This is our application");
                Console.WriteLine("Bla bla bla yada yada yada");
            } else // !(age > 18)
              {
                Console.WriteLine("You're too young");
                Console.WriteLine("Come back when you grow up");
            }

            if (age > 18) {
                Console.WriteLine("Welcome");
                Console.WriteLine("This is our application");
                Console.WriteLine("Bla bla bla yada yada yada");
            } else {
                Console.WriteLine("You're too young");
                Console.WriteLine("Come back when you grow up");
            }


            Console.WriteLine("Press Enter to quit....");

            Console.ReadLine();
        }
    }
}
