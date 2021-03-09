using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Herdar_vs_Cumprir_Contrato.Model.Entities
{
    class Retangulo : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color ="
                + Color
                + ", width = "
                + Width.ToString("f2")
                + ", height = "
                + Height.ToString("f2")
                + ", area = "
                + Area().ToString("f2");
        }
    }
}
