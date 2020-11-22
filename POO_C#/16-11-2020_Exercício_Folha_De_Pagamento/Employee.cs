using System;
using System.Collections.Generic;
using System.Text;

namespace _16_11_2020_Exercício_Folha_De_Pagamento
{
    class Employee
    {
        public string _name { get; private set; }
        public int _hoursWorked { get; private set; }
        public double _hourlyWage { get; private set; }

        public Employee() { }
        public Employee(string name, int hoursWorked, double hourlyWage)
        {
            _name = name;
            _hoursWorked = hoursWorked;
            _hourlyWage = hourlyWage;
        }

        virtual internal double Salary()
        {
            return _hourlyWage * _hoursWorked;
        }

        public virtual string Info() // Escreve as informações. Virual pois deve poder ser sobrescrito na subclasse "OutsourcedEmployee".
        {
            return "\nNome: " + _name + "\nTerceirizado: não\nHoras trabalhadas: " + _hoursWorked + "\nSalário por hora: " + _hourlyWage + "\nSalário recebido: " + Salary();
        }
    }
}
