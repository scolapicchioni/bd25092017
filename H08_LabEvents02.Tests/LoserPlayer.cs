using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02.Tests
{
    public class LoserPlayer : IPlayer
    {
        public string Name { get; set; }
        public int Play() {
            return 1;
        }
    }
}
