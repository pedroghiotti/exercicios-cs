using System;
using System.Collections.Generic;
using System.Text;

namespace _09_11_2020_Exercício_Herança
{
    class ContaJur : ContaGenerica
    {
        public double _emprestimoLimite { get; set; }

        public ContaJur() { }
        public ContaJur(double emprestimoLimite, int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            _emprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double quantidade)
        {
            if (quantidade <= _emprestimoLimite)
            {
                _saldo += quantidade;
            }
        }
    }
}
