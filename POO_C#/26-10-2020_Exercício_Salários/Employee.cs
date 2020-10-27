using System;
using System.Collections.Generic;
using System.Text;

namespace _26_10_2020_Exercício_Salários
{
    class Employee
    {
        public string _name { get; private set; }
        public int _id { get; private set; }
        public double _salary { get; private set; }

        public Employee(string name, int id, double salary)
        {
            _name = name;
            _id = id;
            _salary = salary;
        }

        public void Raise(float percent)
        {
            _salary += (percent / 100) * _salary;
        }

        public override string ToString()
        {
            return "\nNome: " + _name + "\nID: " + _id + "\nSalário: "+_salary;
        }
    }
}
