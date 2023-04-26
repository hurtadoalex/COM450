using NUnit.Framework;
using System;


[TestFixture]
public class CombinatoriaTests
    
{
    
    [Test]
    public void Combinatoria_0_0_Devuelve_1()
    {
        
        int n = 0;
        int k = 0;
        int resultado = Combinatoria.Calcular(n, k);

        
        Assert.AreEqual(1, resultado);
    }

    [Test]
    public void Combinatoria_5_3_Devuelve_10()
    {

        int n = 5;
        int k = 3;

        
        int resultado = Combinatoria.Calcular(n, k);

        
        Assert.AreEqual(10, resultado);
    }

    [Test]
    public void Combinatoria_10_5_Devuelve_252()
    {
        
        int n = 10;
        int k = 5;

        
        int resultado = Combinatoria.Calcular(n, k);

       
        Assert.AreEqual(252, resultado);
    }

    [Test]
    public void Combinatoria_20_0_Devuelve_1()
    {
        
        int n = 20;
        int k = 0;

        
        int resultado = Combinatoria.Calcular(n, k);

        
        Assert.AreEqual(1, resultado);
    }

    [Test]
    public void Combinatoria_15_15_Devuelve_1()
    {
        
        int n = 15;
        int k = 15;

        
        int resultado = Combinatoria.Calcular(n, k);

        
        Assert.AreEqual(1, resultado);
    }
}

