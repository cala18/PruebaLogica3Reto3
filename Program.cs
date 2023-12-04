internal partial class Program
{
    public static void Main(string[] args)
    {
  static int SumaDivisores(int numero)
    {
        int suma = 1;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                suma += i;
                if (i != numero / i)
                {
                    suma += numero / i;
                }
            }
        }
        return suma;
    }

        static void Cala1()
    {
        Console.WriteLine("Buscando un par amigable en el rango [1000, 1500]...");

        for (int m = 1000; m <= 1500; m++)
        {
            int n = SumaDivisores(m);


            if (m != n && SumaDivisores(n) == m)
            {
                Console.WriteLine($"Se encontró un par amigable: ({m}, {n})");
            }
        }

        Console.WriteLine("Fin del programa.");
    }
    Cala1();

    }
}