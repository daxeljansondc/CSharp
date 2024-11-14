using System;
/*Elaborado por Daxel Janson Guerrero "Java"*/
class Program
{
    // Método para calcular el Máximo Común Divisor (MCD) usando el algoritmo de Euclides
    public static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Método para calcular el Mínimo Común Múltiplo (MCM)
    public static int MCM(int a, int b)
    {
        return Math.Abs(a * b) / MCD(a, b);
    }

    static void Main()
    {
        int num1 = 12;
        int num2 = 15;

        Console.WriteLine($"El MCM de {num1} y {num2} es: {MCM(num1, num2)}");
    }
}