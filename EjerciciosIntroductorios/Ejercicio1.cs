using System;

class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de dos dígitos: ");
        string input = Console.ReadLine();

        // Validar que el número ingresado sea un entero de dos dígitos
        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            // Separar los dígitos
            int tens = number / 10; // Obtener el dígito de las decenas
            int units = number % 10; // Obtener el dígito de las unidades

            // Calcular la suma de los dígitos
            int sum = tens + units;

            // Mostrar el resultado
            Console.WriteLine($"La suma de los dígitos de {number} es: {sum}");
        }
        else
        {
            Console.WriteLine("Error: Por favor ingrese un número válido de dos dígitos.");
        }
    }
}
