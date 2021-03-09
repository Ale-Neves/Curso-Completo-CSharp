using System;
using System.Collections.Generic;
using System.Text;
using _3_Herdar_vs_Cumprir_Contrato.Model.Enums;

namespace _3_Herdar_vs_Cumprir_Contrato.Model.Entities
{
    //CLASSE ABSTRACTSHAPE VAI SER UM SUB TIPO DA INTERFACE ISHAPE
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        
        // Implementando metodo de forma abstrata.
        public abstract double Area();
    }
}
