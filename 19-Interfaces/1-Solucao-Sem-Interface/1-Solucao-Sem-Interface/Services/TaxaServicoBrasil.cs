namespace _1_Solucao_Sem_Interface.Services
{
    class TaxaServicoBrasil
    {
        public double Taxa(double quantia)
        {
            if(quantia <= 100.00)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
