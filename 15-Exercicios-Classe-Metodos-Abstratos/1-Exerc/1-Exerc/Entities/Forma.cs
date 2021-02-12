using _1_Exerc.Entities.Enums;

namespace _1_Exerc.Entities
{
    abstract class Forma
    {
        public Cores Cor { get; set; }

        public Forma()
        { }
        public Forma(Cores cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
