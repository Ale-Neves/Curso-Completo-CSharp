using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Herança_Multipla.Devices
{   
    //Classe abstract
    abstract class Device
    {
        public int SerialNumber { get; set; }

        //Declaração metodo abstrato.
        public abstract void ProcessDoc(string document);
    }
}
