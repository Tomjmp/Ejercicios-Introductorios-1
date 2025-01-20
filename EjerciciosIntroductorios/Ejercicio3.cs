using System;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de dos dígitos: ");
        string input = Console.ReadLine();

        // Validar que el número ingresado sea un entero de dos dígitos
        if (int.TryParse(input, out int number) && Math.Abs(number) >= 10 && Math.Abs(number) <= 99)
        {
            // Separar los dígitos
            int tens = Math.Abs(number / 10); // Dígito de las decenas
            int units = Math.Abs(number % 10); // Dígito de las unidades

            // Verificar si ambos dígitos son primos
            bool tensIsPrime = IsPrime(tens);
            bool unitsIsPrime = IsPrime(units);

            // Mostrar resultados
            Console.WriteLine($"El dígito de las decenas ({tens}) es {(tensIsPrime ? "primo" : "no primo")}.");
            Console.WriteLine($"El dígito de las unidades ({units}) es {(unitsIsPrime ? "primo" : "no primo")}.");

            if (tensIsPrime && unitsIsPrime)
            {
                Console.WriteLine($"Ambos dígitos de {number} son primos.");
            }
            else
            {
                Console.WriteLine($"No ambos dígitos de {number} son primos.");
            }
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido de dos dígitos.");
        }
    }

    // Método para determinar si un número es primo
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
