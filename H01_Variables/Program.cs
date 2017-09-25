using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_Variables
{
    class Program
    {
        //method
        //entry point
        
        /*
          this is 
          a multiline
          comment
        */
        static void Main(string[] args)
        {
            //userName = ""; too early!!

            Console.WriteLine("Hello World!");
            Console.Write("What's your name? ");

            //1)variable declaration
            // type name;
            string userName;

            //2) assignment
            // name = expression;
            // target <= value

            userName = Console.ReadLine();

            //string message;
            //message = "Hello " + userName;
            //Console.WriteLine(message);

            Console.WriteLine("Hello " + userName);


            //Console.WriteLine("Hello " + Console.ReadLine());

            Console.ReadLine();
            //Console.ReadLine() = userName; NO!
        }
    }
}
