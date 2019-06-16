using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Conta
    {
        protected static int count = 0;
        public int numConta { get;  protected set; }
        public double saldo { get; protected set; }
        protected string donoConta;

        public Conta(string donoConta)
        {
            this.numConta = count++;
            this.donoConta = donoConta;
        }

        /**
         * Sacar um valor da conta
         */
        public abstract bool Sacar(double valor);
        /**
         * Deposita um valor na conta
         */
        public abstract bool Depositar(double valor);

        /**
         * Recupera os dados da conta
         */
        public override string ToString()
        {
            return "Conta: " + numConta + " | Proprietário: " + donoConta;
        }
    }
}
