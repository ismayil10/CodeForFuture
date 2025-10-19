using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                        Console.WriteLine("0-a bölmək olmaz!");
                    else
                        result = a / b;
                    break;

                default:
                    Console.WriteLine("Yanlış əməliyyat seçilib!");
                    break;
            }

            return result;
        }
    }

}
