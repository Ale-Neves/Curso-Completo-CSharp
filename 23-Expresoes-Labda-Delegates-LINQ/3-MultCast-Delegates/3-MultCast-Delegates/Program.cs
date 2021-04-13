using System;
using _3_MultCast_Delegates.Services;
namespace _3_MultCast_Delegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
        }
    }
}
