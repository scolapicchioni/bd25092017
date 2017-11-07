using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    public abstract class Control {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor Color { get; set; }

        private string text;
        public string Text {
            get {
                return text;
            }
            set {
                text = value;
                Draw();
            }
        }

        public abstract void Draw();
    }
}
