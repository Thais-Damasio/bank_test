using Bank;

namespace UnitTestLib.Mocks
{
    class MockContaCorrente : ContaCorrente
    {
        public MockContaCorrente(double saldo, string dono): base(dono)
        {
            this.saldo = saldo;
        }
    }
}
