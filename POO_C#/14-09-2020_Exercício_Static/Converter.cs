using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercício_Static_14_09_2020
{
    public static class Converter
    {
        public static double ConvertDollarToReal(double valueInDollars, double conversionRate)
        {
            double valueInReais = valueInDollars * conversionRate;
            double tax = valueInReais * 0.06;
            return (valueInReais + tax);
        }
    }
}
