using System;
using System.Collections.Generic;
using System.Text;
using _3_Herdar_vs_Cumprir_Contrato.Model.Enums;

namespace _3_Herdar_vs_Cumprir_Contrato.Model.Entities
{
    // CLASSE SHAPE ABSTRATA.
    abstract class Shape
    {
        public Color Color { get; set; }

        //DECLARAÇÃO DE METODO ABSTRATO
        public abstract double Area();
    }
}
