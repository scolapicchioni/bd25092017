using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    public class Form {
        //TODO: Create an instance of this guy!
        public ControlsCollection Controls { get; } = new ControlsCollection();

        public void Draw() {
            for (int i = 0; i < Controls.Count; i++) {
                Control item = Controls[i];
                item.Draw();
            }
        }
    }
}
