using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Produtos
{
    class Product
    {
        public string _name;
        public double _price;

        public Product() { }
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public virtual string PriceTag()
        {
            return _name + " - R$" + _price;
        }
    }
}
