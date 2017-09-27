using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_IfAndLoops_03 {
    class Program {
        static void Main(string[] args) {
            //variable scope
            //block scope
            int x = 10;
            int y = 0;

            if (x == 10) {
                y = 20;
                Console.WriteLine(x);
                Console.WriteLine(y);
            } 

            x += 20;
            y += 30;

            //loops


            //while (true) 
            //{

            //}

            //initialize
            //test
            //update

            //initialize
            int i = 0;
            //test
            while (i < 10) 
            {
                Console.WriteLine(i);
                //update
                i++;
            }

            Console.WriteLine("Done!");

            do {
                Console.WriteLine("I'm in the loop!!");
            } while (i<10);

            //for
            //for(initialize; test ; update){}
            for (int index = 0; index < 10; index++) {
                Console.WriteLine(index);
            }

            for (int r = 0, c = 10; r < 10; r++, c--) {
                Console.WriteLine($"{r} {c}");
            }

            Console.ReadLine();
        }
    }
}
