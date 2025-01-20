using System;

class Ejercicio2
{
   public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de dos dígitos: ");
        string input = Console.ReadLine();

        // Validar que el número ingresado sea entero y de dos dígitos
        if (int.TryParse(input, out int number) && Math.Abs(number) >= 10 && Math.Abs(number) <= 99)
        {
            // Verificar si el número es negativo
            bool isNegative = number < 0;

            // Verificar si el número es primo
            bool isPrime = IsPrime(Math.Abs(number)); // Usamos el valor absoluto para verificar primalidad

            // Mostrar resultados
            Console.WriteLine($"El número {number} es {(isNegative ? "negativo" : "positivo")}.");
            Console.WriteLine($"El número {number} es {(isPrime ? "primo" : "no primo")}.");
        }
        else
        {
            Console.WriteLine("Error: Por favor ingrese un número válido de dos dígitos.");
        }
    }

    // Método para verificar si un número es primo
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
