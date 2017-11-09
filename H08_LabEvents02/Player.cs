using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02
{
    public class Player
    {
        private Random generator = new Random();
        public string Name { get; set; }

        public int Play() {
            return generator.Next(1, 7);
        }
    }
}
