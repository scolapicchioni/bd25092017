using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    public class Label : Control {
        //A Label draws itself by printing its text in its color
        public override void Draw() {
            Console.SetCursorPosition(Left, Top);
            Console.ForegroundColor = Color;
            Console.BackgroundColor = BackgroundColor;
            Console.Write(Text);
        }
    }
}
