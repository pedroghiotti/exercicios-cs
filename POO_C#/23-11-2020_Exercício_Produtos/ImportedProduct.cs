using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Produtos
{
    class ImportedProduct : Product
    {
        double _tax; // Guarda taxa sobre importação do produto

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double tax): base(name, price)
        {
            _tax = tax;
        }

        private double TotalPrice()
        {
            return _price += _tax;
        }

        public override string PriceTag()
        {
            return _name + " - R$" + TotalPrice() + "(Taxa: R$" + _tax + ")"; // Substitui a string definida na superclasse pois precisa substituir uma informação
        }
    }
}
