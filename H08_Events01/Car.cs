using System;

namespace H08_Events01
{
    public delegate void ColorChangedHandler(ConsoleColor color);

    public class Car
    {
        public event ColorChangedHandler ColorChanged;

        private ConsoleColor _color;
        public ConsoleColor Color {
            get {
                return _color;
            }
            set {
                _color = value;
                if(ColorChanged!=null)
                    ColorChanged(_color);
            }
        }
    }
}
