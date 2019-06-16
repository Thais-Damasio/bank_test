using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        /**
         * Main do programa
         */
        static void Main(string[] args)
        {
            int option;
            bool inputValid = false, exit = false;
            Bank banco = new Bank();

            do
            {
                Menu.PrintIntro();

                string input = Console.ReadLine();
                inputValid = int.TryParse(input, out option);
                if (inputValid)
                    Menu.PrintMenu(option, ref exit, banco);
                else
                    Menu.PrintInvalidMessage();
            } while (!exit);
        }
    }
}
