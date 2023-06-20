using ExceptionsSample.Exceptions;

namespace ExceptionsSample;

public class ContaCorrente
{
    public decimal Saldo { get; private set; } = 100;

    public void Saque(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException();

        if (valor > Saldo)
            throw new SaldoInsuficienteException();

        if (valor == 22.22M)
            throw new ContaCorrenteException();

        Saldo -= valor;
    }
}