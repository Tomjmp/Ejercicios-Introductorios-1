using System;

class Ejercicio8
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de cinco dígitos: ");
        string? input = Console.ReadLine();

        // Validar que el número ingresado sea un entero de cinco dígitos
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int number) || Math.Abs(number) < 10000 || Math.Abs(number) > 99999)
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido de cinco dígitos.");
            return;
        }

        // Convertir el número a cadena para comparar
        string absNumberStr = Math.Abs(number).ToString();

        // Verificar si el número es Capicúa
        bool isCapicua = absNumberStr[0] == absNumberStr[4] && absNumberStr[1] == absNumberStr[3];

        // Mostrar el resultado
        if (isCapicua)
        {
            Console.WriteLine($"El número {number} es Capicúa.");
        }
        else
        {
            Console.WriteLine($"El número {number} no es Capicúa.");
        }
    }
}
