using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    public class ControlsCollection {
        private Control[] controls = new Control[10];
        private int count = 0;
        public int Count => count;
        public void Add(Control control) {
            controls[count++] = control;
        }

        public Control this[int index] => controls[index];
    }
}
