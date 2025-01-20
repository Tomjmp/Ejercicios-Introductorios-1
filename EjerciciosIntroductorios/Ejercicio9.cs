using System;

class Ejercicio9
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número entero de cuatro dígitos: ");
        string? input = Console.ReadLine();

        // Validar que el número ingresado sea un entero de cuatro dígitos
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int number) || Math.Abs(number) < 1000 || Math.Abs(number) > 9999)
        {
            Console.WriteLine("Error: Por favor, ingrese un número válido de cuatro dígitos.");
            return;
        }

        // Convertir el número a cadena para comparar los dígitos
        string absNumberStr = Math.Abs(number).ToString();

        // Comparar el segundo dígito con el penúltimo
        bool isEqual = absNumberStr[1] == absNumberStr[2];

        // Mostrar el resultado
        if (isEqual)
        {
            Console.WriteLine($"En el número {number}, el segundo dígito ({absNumberStr[1]}) es igual al penúltimo dígito ({absNumberStr[2]}).");
        }
        else
        {
            Console.WriteLine($"En el número {number}, el segundo dígito ({absNumberStr[1]}) no es igual al penúltimo dígito ({absNumberStr[2]}).");
        }
    }
}
