using System;
using _3_Herança_Multipla.Devices;

namespace _3_Herança_Multipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
