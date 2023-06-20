// See https://aka.ms/new-console-template for more information

using ExceptionsSample;
using ExceptionsSample.Exceptions;

var conta = new ContaCorrente();

while (true)
{
    Console.WriteLine("Por favor insira o valor para saque...");

    var valor = Console.ReadLine();

    decimal saque;

    if (!decimal.TryParse(valor, out saque))
    {
        Console.WriteLine("Valor inválido.");
        Console.WriteLine("Por favor, insira um valor decimal.");
        continue;
    }

    try
    {
        conta.Saque(saque);

        Console.WriteLine("Operação efetuada com sucesso.");
        Console.WriteLine($"Saldo atual de {conta.Saldo:C}");
    }
    catch (SaldoInsuficienteException)
    {
        Console.WriteLine("Seu saldo é insuficiente para completar essa operação");
    }
    catch (ContaCorrenteException)
    {
        Console.WriteLine("Não foi possível completar essa operação");
    }
    catch
    {
        Console.WriteLine("Falha crítica");
    }
}