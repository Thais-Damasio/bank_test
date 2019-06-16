using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string donoConta) : base(donoConta) { }

        public override bool Depositar(double valor)
        {
            if (valor <= 0)
                return false;
            this.saldo += valor;
            return true;
        }

        public override bool Sacar(double valor)
        {
            if (valor <= 0)
                return false;
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
                return false;
        }
    }
}
