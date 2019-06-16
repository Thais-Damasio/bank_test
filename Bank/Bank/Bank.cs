using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public class Bank
    {
        protected List<Conta> contas = new List<Conta>();
        /**
         * Cria uma conta corrente para o usuário
         */
        public void CriarConta()
        {
            Console.WriteLine("Digite seu nome:");
            string entrada = Console.ReadLine();

            Conta conta = new ContaCorrente(entrada);
            contas.Add(conta);

            Console.WriteLine("Conta criada com sucesso! Informações da conta: " + conta.ToString());
        }

        /**
         * Realiza a operação de saque em uma conta
         */
        public void Sacar(int numConta, double valor) 
        {
            Conta result = contas.Where(c => c.numConta == numConta).FirstOrDefault();
            if (result != null)
            {
                if (result.Sacar(valor))
                    Console.WriteLine("Saque realizado com sucesso!");
                else
                    Console.WriteLine("Não foi possível completar a operação!");
            }
            else
            {
                Console.WriteLine("Nenhuma conta encontrada!");
            }
        }


        /**
         * Realiza a operação de deposito em uma conta
         */
        public void Depositar(int numConta, double valor)
        {
            Conta result = contas.Where(c => c.numConta == numConta).FirstOrDefault();
            if (result != null)
            {
                if (result.Depositar(valor))
                    Console.WriteLine("Depósito realizado com sucesso!");
                else
                    Console.WriteLine("Não foi possível completar a operação!");
            }
            else
            {
                Console.WriteLine("Nenhuma conta encontrada!");
            }
        }

        /**
         * Realiza a operação de transferência em uma conta
         */
        public void Transferir(int numContaDest, int numContaOrigem, double valor)
        {
            Conta resultDest = contas.Where(c => c.numConta == numContaDest).FirstOrDefault();
            Conta resultOrigem = contas.Where(c => c.numConta == numContaOrigem).FirstOrDefault();

            if (resultDest == null)
                Console.WriteLine("Conta de destino não encotrada!");
            else if (resultOrigem == null)
                Console.WriteLine("Conta de origem não encontrada!");
            else
                if (resultOrigem.Sacar(valor))
                {
                    resultDest.Depositar(valor);
                    Console.WriteLine("Depósito realizado com sucesso!");
                }
        }

        /**
         * Exibi detalhes de uma conta
         */
        public void DetalhesDaConta(int numConta)
        {
            Conta result = contas.Where(c => c.numConta == numConta).FirstOrDefault();

            if(result != null)
                Console.WriteLine(result.ToString());
            else
                Console.WriteLine("Nenhuma conta encontrada!");
        }
    }
}
