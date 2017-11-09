using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents01
{
    public delegate void AlarmHandler(NuclearReactor r);
    public class NuclearReactor
    {
        public event AlarmHandler Alarm;
        public event AlarmHandler TemperatureChanged;
        private int _temperature;
        public int Temperature {
            get {
                return _temperature;
            } set {
                _temperature = value;
                if (TemperatureChanged != null)
                    TemperatureChanged(this);
            }
        }

        public void Split() {
            Temperature++;
            if (Alarm != null)
                Alarm(this);
        }
    }
}
