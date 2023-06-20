using ExceptionsSample;
using ExceptionsSample.Exceptions;

namespace ExceptionSample.Tests;

public class ContaCorrenteTests
{
    private readonly ContaCorrente _contaCorrente = new();

    [Fact]
    public void DeveLancarFundosInsuficientes()
    {
        Assert.Throws<SaldoInsuficienteException>(() => { _contaCorrente.Saque(999); });
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(-10000)]
    public void DeveLancarArgumentOutOfRangeException(decimal amount)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => { _contaCorrente.Saque(amount); });
    }

    [Fact]
    void Sucesso()
    {
        _contaCorrente.Saque(10);

        Assert.Equal(90, _contaCorrente.Saldo);
    }
}