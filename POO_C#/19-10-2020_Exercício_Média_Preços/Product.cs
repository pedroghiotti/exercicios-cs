using System;
using System.Collections.Generic;
using System.Text;

namespace _19_10_2020_Exercício_Média_Preços
{
    class Product
    {
        public string _name { get; private set; } // Impede que a variável seja modificada fora da classe.
        public double _price { get; private set; } // Impede que a variável seja modificada fora da classe.

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
    }
}
