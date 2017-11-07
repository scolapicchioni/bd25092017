using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class Phone
    {
        public Phone() {
            Apps.Add(new PhoneBook());
        }
        public Collection<App> Apps { get; } = new Collection<App>();
    }
}
