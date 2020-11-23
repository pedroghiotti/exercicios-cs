using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_2
{
    sealed class ContaPoupanca : ContaGenerica
    {
        public double _taxaJuros { get; set; }

        public ContaPoupanca(double taxaJuros, int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            _taxaJuros = taxaJuros;
        }

        public void atualizacaoSaldo()
        {
            _saldo += _saldo * _taxaJuros;
        }
        public override void Saque(double quantidade)
        {
            base.Saque(quantidade);
            _saldo -= 2;
        }
    }
}
