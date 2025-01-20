using System;

class Ejercicio6
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        string? input = Console.ReadLine();

        // Validar que el número ingresado sea entero de tres dígitos
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int number) || Math.Abs(number) < 100 || Math.Abs(number) > 999)
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido de tres dígitos.");
            return;
        }

        // Tomar el valor absoluto para manejar números negativos
        int absNumber = Math.Abs(number);

        // Separar los dígitos
        int hundreds = absNumber / 100; // Centenas
        int tens = (absNumber / 10) % 10; // Decenas
        int units = absNumber % 10; // Unidades

        // Determinar si algún dígito es múltiplo de los otros
        bool isMultiple = (hundreds != 0 && tens != 0 && units != 0) &&
                          (hundreds % tens == 0 || hundreds % units == 0 ||
                           tens % hundreds == 0 || tens % units == 0 ||
                           units % hundreds == 0 || units % tens == 0);

        // Mostrar resultados
        if (isMultiple)
        {
            Console.WriteLine($"En el número {number}, algún dígito es múltiplo de otro.");
        }
        else
        {
            Console.WriteLine($"En el número {number}, ningún dígito es múltiplo de otro.");
        }
    }
}
