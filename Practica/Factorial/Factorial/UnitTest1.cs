using NUnit.Framework;

[TestFixture]
public class FactorialTests
{
    [Test]
    public void FactorialDeCeroEsUno()
    {
        Assert.AreEqual(1, Factorial.Calcular(0));
    }

    [Test]
    public void FactorialDeUnoEsUno()
    {
        Assert.AreEqual(1, Factorial.Calcular(1));
    }

    [Test]
    public void FactorialDeDosEsDos()
    {
        Assert.AreEqual(2, Factorial.Calcular(2));
    }

    [Test]
    public void FactorialDeCincoEsCientoVeinte()
    {
        Assert.AreEqual(120, Factorial.Calcular(5));
    }

    [Test]
    public void FactorialDeDoceEs479001600()
    {
        Assert.AreEqual(479001600, Factorial.Calcular(12));
    }
}
public static class Factorial
{
    public static long Calcular(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("El argumento debe ser un número no negativo", nameof(n));
        }

        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}



