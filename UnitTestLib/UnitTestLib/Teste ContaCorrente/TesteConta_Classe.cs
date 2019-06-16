using NUnit.Framework;
using System;
using UnitTestLib.Mocks;

namespace UnitTestLib.Teste_ContaCorrente
{
    class TesteConta_Classe
    {
        //Inicializando mockContaCorrente com saldo de R$500 e usuário proprietário como 'Usuário Teste'
        MockContaCorrente mockContaCorrente = new MockContaCorrente(500, "Usuário Tete");

        [Test]
        [Description("Teste1: O método depositar da conta corrente não deve aceitar valores negativos ou nulos.")]
        public void SaqueMenorQue_0()
        {
            Assert.IsFalse(mockContaCorrente.Sacar(-100));
        }

        [Test]
        [Description("Teste2: O método sacar deve funcionar corretamente.")]
        public void SaqueCorreto()
        {
            Assert.IsTrue(mockContaCorrente.Sacar(100));
        }

        [Test]
        [Description("Teste3: O método sacar da conta corrente não pode permitir saques maiores que o saldo.")]
        public void SaqueMaiorQue_Saldo()
        {
            Assert.IsFalse(mockContaCorrente.Sacar(700));
        }

        [Test]
        [Description("Teste4: O método depositar da conta corrente não deve aceitar valores negativos ou nulos.")]
        public void DepositoMenorQue_0()
        {
            Assert.IsFalse(mockContaCorrente.Depositar(-100));
        }

        [Test]
        [Description("Teste5: O método depositar deve funcionar corretamente.")]
        public void DepositoCorreto()
        {
            Assert.IsTrue(mockContaCorrente.Depositar(100));
        }
    }
}
