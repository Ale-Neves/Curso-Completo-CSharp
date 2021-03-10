using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Herança_Multipla.Devices
{  
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
