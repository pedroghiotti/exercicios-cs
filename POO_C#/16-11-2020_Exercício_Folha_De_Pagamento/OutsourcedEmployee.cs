using System;
using System.Collections.Generic;
using System.Text;

namespace _16_11_2020_Exercício_Folha_De_Pagamento
{
    class OutsourcedEmployee : Employee
    {
        public double _extra = 0;

        public OutsourcedEmployee(double extra, string name, int hoursWorked, double hourlyWage) : base (name, hoursWorked, hourlyWage)
        {
            _extra = extra;
        }

        internal override double Salary()
        {
            return base.Salary() + 1.1 * _extra;
        }

        public override string Info() // Escreve as informações. Sobrescreve o método da superclasse.
        {
            return "\nNome: " + _name + "\nTerceirizado: sim\nHoras trabalhadas: " + _hoursWorked + "\nSalário por hora: " + _hourlyWage + "\nBônus: " + _extra + "\nSalário recebido: " + Salary();
        }
    }
}
