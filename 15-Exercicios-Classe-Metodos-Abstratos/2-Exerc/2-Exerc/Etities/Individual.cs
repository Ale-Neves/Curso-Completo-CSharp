using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Etities
{
    class Individual: Contribuinte
    {
        public double DispesaSaude { get; set; }

        public Individual()
        { }
        public Individual(string nome, double rendimentoAnual, double dispesaSaude ) : base(nome, rendimentoAnual)
        {
            DispesaSaude = dispesaSaude;
        }

        public override double Taxa()
        {
            double taxa = 0.0;

            if(RendimentoAnual<20000)
            {
                taxa = RendimentoAnual * 0.15;

                if (DispesaSaude > 0.0)
                {
                    taxa -= DispesaSaude * 0.50;
                }
            }
            else
            {
                taxa = RendimentoAnual * 0.25;

                if (DispesaSaude > 0.0)
                {
                    taxa = taxa - (DispesaSaude * 0.50);
                }
            }
            return taxa;
        }

    }
}
