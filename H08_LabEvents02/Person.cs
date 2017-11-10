using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02
{
    public interface IPerson
    {
        string Name { get; set; }
        int Play();
    }
}
