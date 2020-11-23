using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Produtos
{
    class UsedProduct : Product
    {
        DateTime _manufacturingDate; // Guarda a data de fabricação do produto

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufacturingDate) : base(name, price)
        {
            _manufacturingDate = manufacturingDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Data de fabricação: "+_manufacturingDate.ToString("dd/MM/yyyy")+")"; // Adiciona a data de fabricação [formatada para que não seja mostrado horário] ao final da string definida na superclasse
        }
    }
}
