public static class Combinatoria
{
    public static int Calcular(int n, int k)
    {
        if (n < k)
        {
            throw new ArgumentException("El valor de n debe ser mayor o igual que el valor de k");
        }

        if (n == k || k == 0)
        {
            return 1;
        }

        int resultado = 1;

        for (int i = 1; i <= k; i++)
        {
            resultado *= n - k + i;
            resultado /= i;
        }

        return resultado;
    }
}