using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Menu
    {/**
         * Menu que executa a funcionalidade escolhida.
         */
        public static void PrintMenu(int option, ref bool exit, Bank banco)
        {
            switch (option)
            {
                case 0:
                    banco.CriarConta();
                    break;
                case 1:
                    banco.Depositar(PrintGetNumConta(Operacao.depositar), PrintGetValor(Operacao.depositar));
                    break;
                case 2:
                    banco.Sacar(PrintGetNumConta(Operacao.sacar), PrintGetValor(Operacao.sacar));
                    break;
                case 3:
                    banco.Transferir(PrintGetNumConta(Operacao.sacar), PrintGetNumConta(Operacao.transferir), PrintGetValor(Operacao.transferir));
                    break;
                case 4:
                    banco.DetalhesDaConta(PrintGetNumConta(Operacao.informações));
                    break;
                case 5:
                    PrintEnd();
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }

        /**
         * Printa na tela as opções e as boas vindas ao usuário.
         */
        public static void PrintIntro()
        {
            Console.Clear();
            Console.WriteLine("### Bank ###");
            Console.WriteLine("Olá usuário! Digite e ação que deseja fazer:");
            Console.WriteLine("0 - Criar conta");
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Detalhes da conta");
            Console.WriteLine("5 - Sair");
        }

        /**
         * Printa uma mensagem informando que a entrada é inválida.
         */
        public static void PrintInvalidMessage()
        {
            Console.WriteLine("Entrada inválida! Digite apenas números.");
            Console.ReadKey();
        }

        /**
         * Printa uma mensagem de despedida ao usuário.
         */
        public static void PrintEnd()
        {
            Console.Clear();
            Console.WriteLine("Obrigada por utilizar nosso programa! :D");
            Console.ReadKey();
        }

        /**
         * Recupera o número da conta onde será feita a alteração.
         */
        public static int PrintGetNumConta(Operacao operacao)
        {
            int numConta;
            string entrada;
            bool inputValid = false;

            do
            {
                Console.WriteLine("Digite o número da conta para " + operacao + ":");
                entrada = Console.ReadLine();
                inputValid = int.TryParse(entrada, out numConta);
                if (!inputValid)
                    PrintInvalidMessage();
            }
            while (!inputValid);

            return numConta;
        }

        /**
         * Recupera o número da conta onde será feita a alteração.
         */
        public static double PrintGetValor(Operacao opcao)
        {
            double valor;
            string entrada;
            bool inputValid = false;

            do
            {
                Console.WriteLine("Digite o valor para " + opcao + ":");
                entrada = Console.ReadLine();
                inputValid = double.TryParse(entrada, out valor);
                if (!inputValid)
                    PrintInvalidMessage();
            }
            while (!inputValid);

            return valor;
        }
    }
}
