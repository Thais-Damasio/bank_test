using NUnit.Framework;
using UnitTestLib.Mocks;

namespace UnitTestLib
{
    [TestFixture]
    public class TesteConta_Limite
    {
        //Inicializando mockContaCorrente com saldo de R$500 e usuário proprietário como 'Usuário Teste'
        MockContaCorrente mockContaCorrente = new MockContaCorrente(500, "Usuário Tete");

        [Test]
        [Description("Teste1: Limite inferior do método sacar.")]
        public void SaqueIgualA_0()
        {   
            Assert.IsFalse(mockContaCorrente.Sacar(0));
        }

        [Test]
        [Description("Teste2: Limite inferior do método sacar.")]
        public void SaqueIgualA_N1()
        {
            Assert.IsTrue(mockContaCorrente.Sacar(1));
        }

        [Test]
        [Description("Teste3: Limite superior do método sacar.")]
        public void SaqueIgualA_500()
        {
            Assert.IsTrue(mockContaCorrente.Sacar(500));
        }

        [Test]
        [Description("Teste4: Limite superior do método sacar.")]
        public void SaqueIgualA_501()
        {
            Assert.IsFalse(mockContaCorrente.Sacar(501));
        }

        [Test]
        [Description("Teste5: Teste limite Deposito.")]
        public void DepositoIgualA_0()
        {
            Assert.IsFalse(mockContaCorrente.Depositar(0));
        }

        [Test]
        [Description("Teste6: Teste limite depósito.")]
        public void DepositoMenorQue_0()
        {
            Assert.IsTrue(mockContaCorrente.Depositar(1));
        }
    }
}
