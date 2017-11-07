using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class Calendar : App {
        public override void Start() {
            
        }

        public Collection<Appointment> Appointments { get; } = new Collection<Appointment>();
    }
}
