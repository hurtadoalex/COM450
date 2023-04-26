using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Combinatoria
{
    public static int Calcular(int n, int x)
    {
        if (n < x)
        {
            throw new ArgumentException("El valor de n debe ser mayor o igual que el valor de x");
        }

        if (n == x || x == 0)
        {
            return 1;
        }

        int resultado = 1;

        for (int i = 1; i <= x; i++)
        {
            resultado *= n - x + i;
            resultado /= i;
        }

        return resultado;
    }
}