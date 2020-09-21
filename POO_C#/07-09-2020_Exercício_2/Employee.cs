using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2_17_09_2020
{
    class Employee
    {
        private string _name;
        private double _grossSalary;
        private double _netSalary;
        private double _tax;
        public Employee(string name, double grossSalary, double tax)
        {
            _name = name;
            _grossSalary = grossSalary;
            _tax = tax;
        }

        private double NetSalary()
        {
            return _grossSalary - _tax;
        }
        public void raiseByPercent(double percent)
        {
            _grossSalary += (_grossSalary * (percent / 100));
        }
        public override string ToString()
        {
            return new string
                (
                "\nDados atualizados: "     +
                "\nNome - "     + _name     +
                "\nSalário - "  + NetSalary()
                );
        }
    }
}
