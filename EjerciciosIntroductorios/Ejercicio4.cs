using System;

class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el primer número entero de dos dígitos: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número entero de dos dígitos: ");
        string input2 = Console.ReadLine();

        // Validar que ambos números sean enteros de dos dígitos
        if (int.TryParse(input1, out int number1) && 
            int.TryParse(input2, out int number2) && 
            Math.Abs(number1) >= 10 && Math.Abs(number1) <= 99 &&
            Math.Abs(number2) >= 10 && Math.Abs(number2) <= 99)
        {
            // Calcular la suma de los números
            int sum = number1 + number2;

            // Determinar si la suma es un número par
            bool isEven = sum % 2 == 0;

            // Mostrar resultados
            Console.WriteLine($"La suma de {number1} y {number2} es {sum}, que es {(isEven ? "par" : "impar")}.");
        }
        else
        {
            Console.WriteLine("Error: Ambos números deben ser enteros de dos dígitos.");
        }
    }
}
