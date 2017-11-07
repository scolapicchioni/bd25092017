using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    public class TextBox : Control {
        public override void Draw() {
            Console.SetCursorPosition(Left, Top);
            Console.ForegroundColor = Color;
            Console.BackgroundColor = BackgroundColor;

            for (int i = 0; i < Width; i++) {
                Console.Write("-");
            }
            Console.SetCursorPosition(Left, Top+1);

            Console.Write($"| {Text}");
            Console.SetCursorPosition(Left + Width, Top + 1);
            Console.Write("|");
            Console.SetCursorPosition(Left, Top + Height);
            for (int i = 0; i < Width; i++) {
                Console.Write("-");
            }
        }

        // The Input method reads an input from the console 
        // and sets its Text property
        public void Input() {
            Console.SetCursorPosition(Left+1, Top+1);
            Text = Console.ReadLine();
        }
    }
}
