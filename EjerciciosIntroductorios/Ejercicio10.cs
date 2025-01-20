using System;

class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el primer número entero: ");
        string? input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número entero: ");
        string? input2 = Console.ReadLine();

        // Validar que ambos números sean enteros
        if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
        {
            // Calcular la diferencia absoluta entre los dos números
            int difference = Math.Abs(number1 - number2);

            if (difference <= 10)
            {
                // Determinar el menor y el mayor
                int menor = Math.Min(number1, number2);
                int mayor = Math.Max(number1, number2);

                // Mostrar los números comprendidos entre el menor y el mayor
                Console.WriteLine($"Los números comprendidos entre {menor} y {mayor} son:");
                for (int i = menor; i <= mayor; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("La diferencia entre los dos números es mayor a 10.");
            }
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingrese valores enteros válidos.");
        }
    }
}
