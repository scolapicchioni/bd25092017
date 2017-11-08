using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO02.Logic {
    public class Calendar : App {
        public override void Start() {
            
        }

        public Collection<Appointment> Appointments { get; } = new Collection<Appointment>();
    }
}
