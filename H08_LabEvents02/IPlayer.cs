using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02
{
    
    public interface IPlayer
    {
        
        int Play();
        string Name { get; set; }
    }
}
