using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Herdar_vs_Cumprir_Contrato.Model.Entities
{
    // ERDANDO DA CLASSE SHAPE.
    class Circle : Shape
    {
        public double Radius { get; set; }
        
        // SOBRESCREVENDO O VALOR DA AREA.
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        //CONVERTENDO PARA STRING.
        public override string ToString()
        {
            return "Circle color ="
                + Color
                + ", radies ="
                + Radius.ToString("f2")
                + ", area = "
                + Area().ToString("f2");
        }
    }
}
