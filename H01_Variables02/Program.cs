using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_Variables02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is a value";

            s1 = "Some value " + "another value";

            string userName = Console.ReadLine();

            //string message = "Hello " + userName;

            string thePathOfMyFile = @"C:\ty folder";

            //C# 7
            string message = $"Hello {userName}";

            message = "Before\tAfter\nNextLine";

            //string UpperCaseMessage = message.ToUpper();
            
            Console.WriteLine(message.ToUpper());

            Console.WriteLine(message.Length); 
            Console.ReadLine();
        }
    }
}
