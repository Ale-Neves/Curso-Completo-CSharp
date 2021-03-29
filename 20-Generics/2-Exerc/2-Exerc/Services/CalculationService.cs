using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc.Services
{
    class CalculationService
    {
        public int Max(List<int> list)
        {
            if (list.Count == 0)
                throw new ArgumentException("The list can not be empty");

            int max = list[0];
            for(int i=0; i<list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
            }

            return max;
        }

    }
}
