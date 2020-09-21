using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Constructor
{
    class Product
    {
        public string _name; // Nome do produto.
        private double _price; // Preço do produto.
        private int _amountInStock; // Descreve a quantidade do produto guardada em estoque.

        public Product(string name, double price, int amountInStock) // Construtor.
        {
            _name = name;
            _price = price;
            _amountInStock = amountInStock;
        }

        public void AddToStock(int amount) // Adiciona uma quantidade 'amount' à quantidade em estoque.
        {
            _amountInStock += amount;
        }
        public void RemoveFromStock(int amount) // Remove uma quantidade 'amount' da quantidade em estoque.
        {
            _amountInStock -= amount;
        }
        public double ValueInStock() // Retorna o valor total dos produtos em estoque.
        {
            return _price * _amountInStock;
        }
        public override string ToString() 
        {
            return _name + ", R$ " + _price + ", qtd. em estoque = " + _amountInStock + ", valor total em estoque = " + ValueInStock() + ".";
        }
    }
}
