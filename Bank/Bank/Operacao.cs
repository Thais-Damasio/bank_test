using System;

namespace Bank
{
    [Flags]
    public enum Operacao
    {
        sacar,
        depositar,
        transferir,
        informações
    }
}
