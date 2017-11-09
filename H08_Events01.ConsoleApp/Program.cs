using System;

namespace H08_Events01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            //c.ColorChanged += anotherListener;
            //c.ColorChanged += changeScreenColor;
            

            c.Color = ConsoleColor.Black;

            Console.ReadLine();
        }

        private static void anotherListener(ConsoleColor color) {
            Console.WriteLine("another listener here!");
        }

        private static void changeScreenColor(ConsoleColor color) {
            Console.BackgroundColor = color;
            Console.WriteLine("LOOK! THE COLOR CHANGED!!!");
        }
    }
}
