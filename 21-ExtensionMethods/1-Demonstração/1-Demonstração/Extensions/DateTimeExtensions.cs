using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1_Demonstração.Extensions
{
    static class DateTimeExtensions
    {
        //METODO
        public static string ElapsedTime(this DateTime thisObjs)
        {
            // Pegando a data atual e subtraindo do objto passado por parametro.
            TimeSpan duration = DateTime.Now.Subtract(thisObjs);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + "Hours";
            }
            else
            {
                return duration.TotalDays.ToString("f2", CultureInfo.InvariantCulture) + "Days";
            }

            string s1 = "Good morning dear students";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
