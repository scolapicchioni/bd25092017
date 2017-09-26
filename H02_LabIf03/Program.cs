using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf03 {
    class Program {
        static void Main(string[] args) {
            /*
             * Ask the user:
	            - is it windy?
	            - does it rain?
            Our user needs an umbrella if it rains but it's no use if it's also windy.
            Tell the user if he has to take an umbrella or not.
            */

            Console.WriteLine("Does it rain?");
            bool rain = Console.ReadLine().ToLower() == "y";

            if (rain) {
                Console.WriteLine("Is it windy?");
                bool wind = Console.ReadLine().ToLower() == "y";
                if (wind) {
                    Console.WriteLine("No need for an umbrella, you'll get wet anyway");
                } else {
                    Console.WriteLine("Take your umbrella!");
                }
            } else {
                Console.WriteLine("No need for an umbrella, it does not rain!");
            }

            Console.ReadLine();
        }
    }
}
