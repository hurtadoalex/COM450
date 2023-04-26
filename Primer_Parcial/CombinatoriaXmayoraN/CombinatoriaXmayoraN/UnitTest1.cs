using NUnit.Framework;
using System;


[TestFixture]
public class CombinatoriaTests

{

    [Test]
    public void Combinatoria_x_Mayor_n()
    {

        int x = 7;
        int n = 0;
        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(10, resultado);
    }

    [Test]
    public void Combinatoria_x_negativo()
    {

        int x = -1;
        int n = 3;


        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(1, resultado);
    }

    [Test]
    public void Combinatoria_n_negativo()
    {

        int x = 1;
        int n = -5;


        int resultado = Combinatoria.Calcular(n, x);

        Assert.AreEqual(throw new ArgumentException("El valor de n debe ser mayor o igual que el valor de x"), resultado);
    }

    [Test]
    public void Combinatoria_n_3_x_1()
    {
                
        int n = 3;
        int x = 1;

        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(3, resultado);
    }

    [Test]
    public void Combinatoria_n_4_x_3()
    {

        int n = 4;
        int x = 3;


        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(4, resultado);
    }

    [Test]
    public void Combinatoria_x_2_n_6()
    {

        int x = 2;
        int n = 6;


        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(15, resultado);
    }
    [Test]
    public void Combinatoria_x_3_n_7()
    {

        int x = 3;
        int n = 7;


        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(35, resultado);
    }
    [Test]
    public void Combinatoria_x_igual_n()
    {

        int x = 2;
        int n = 2;


        int resultado = Combinatoria.Calcular(n, x);


        Assert.AreEqual(1, resultado);
    }
   /* [Test]
    public void Combinatoria_x_y_n_cadena()
    {

        int x = "4";
        int n = "5";


        int resultado = Combinatoria.Calcular(x, n);


        Assert.AreEqual(1, resultado);
    }*/
}
