using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops06 {
    class Program {
        static void Main(string[] args) {
            /*
             * The “Eleven Proof” is used to confirm 
             * if a given number could be a bank account number.
             * Assume that a user has entered the following number 
             * when prompted for an account number: 123456789
             
                1st digit account number = 1 		9 * 1 =		 9
                2nd digit account number = 2 		8 * 2 =		16
                3rd digit account number = 3 		7 * 3 =		21
                4th digit account number = 4 		6 * 4 =		24
                5th digit account number = 5 		5 * 5 =		25
                6th digit account number = 6 		4 * 6 =		24
                7th digit account number = 7 		3 * 7 =		21
                8th digit account number = 8 		2 * 8 =		16
                9nd digit account number = 9 		1 * 9 =		 9
						                            ------------  +
							                                165

                As 165 can be divided by 11 (165 / 11 = 15 remainder 0 ) 
                123456789 probably is a valid bank account number

               * when prompted for an account number: 538794615
             
                1st digit account number = 1 		9 * 5 =		45
                2nd digit account number = 2 		8 * 3 =		24
                3rd digit account number = 3 		7 * 8 =		56
                4th digit account number = 4 		6 * 7 =		42
                5th digit account number = 5 		5 * 9 =		45
                6th digit account number = 6 		4 * 4 =		16
                7th digit account number = 7 		3 * 6 =		18
                8th digit account number = 8 		2 * 1 =		 2
                9nd digit account number = 9 		1 * 5 =		 5
						                            ------------  +
							                                253

                As 253 can be divided by 11 (253 / 11 = 23 remainder 0 ) 
                538794615 probably is a valid bank account number
                
                This calculation can be easily performed using a loop. 
                The counter that is used in the loop can be used 
                in most of the calculation that must be done
                To isolate individual digits out of the number 
                you can use the  substring method of a  string object.

                1.	Create a new Console application.
                2.	Let the user input an accountnumber.
                3.	Check with the above algorithm whether the number is valid.

             */

            string accountNumber = Console.ReadLine();
            if (accountNumber.Length != 9) {
                Console.WriteLine("not valid");
            } else {
                int total = 0;
                for (int letterPosition = 0, multiplier = 9; letterPosition < 9; letterPosition++, multiplier--) {
                    int digit = int.Parse(accountNumber.Substring(letterPosition,1));
                    int subTotal = digit * multiplier;
                    total += subTotal;
                }
                if (total % 11 == 0) {
                    Console.WriteLine("valid");
                } else {
                    Console.WriteLine("not valid");
                }
            }
            Console.ReadLine();
        }
    }
}
