using System;

class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        string input = Console.ReadLine();

        // Validar que el número ingresado sea entero de tres dígitos
        if (int.TryParse(input, out int number) && Math.Abs(number) >= 100 && Math.Abs(number) <= 999)
        {
            // Tomar el valor absoluto para manejar números negativos
            int absNumber = Math.Abs(number);

            // Separar los dígitos
            int hundreds = absNumber / 100; // Centenas
            int tens = (absNumber / 10) % 10; // Decenas
            int units = absNumber % 10; // Unidades

            // Determinar el mayor dígito y su posición
            int maxDigit = Math.Max(hundreds, Math.Max(tens, units));
            string position = "";

            if (maxDigit == hundreds)
                position = "centena";
            else if (maxDigit == tens)
                position = "decena";
            else
                position = "unidad";

            // Mostrar resultados
            Console.WriteLine($"El mayor dígito es {maxDigit} y está en la posición de la {position}.");
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido de tres dígitos.");
        }
    }
}
