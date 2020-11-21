using System;
using System.Collections.Generic;
using System.Text;

namespace _09_11_2020_Exercício_Herança
{
    class ContaGenerica
    {
        public int _numero { get; private set; }
        public string _titular { get; private set; }
        public double _saldo { get; protected set; }

        public ContaGenerica() { }
        public ContaGenerica(int numero, string titular, double saldo)
        {
            _numero = numero;
            _titular = titular;
            _saldo = saldo;
        }

        public virtual void Saque(double quantidade)
        {
            _saldo -= quantidade;
        }
        public void Deposito(double quantidade)
        {
            _saldo += quantidade;
        }
    }
}
