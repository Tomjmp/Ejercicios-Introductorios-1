using System;

class Ejercicio7
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el primer número entero:");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el segundo número entero:");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el tercer número entero:");
        int c = int.Parse(Console.ReadLine() ?? "0");

        // Usar dos variables: una para el mayor y otra como auxiliar
        int mayor = a; // Suponemos que el primero es el mayor inicialmente

        if (b > mayor) 
        {
            mayor = b; // Si b es mayor, actualizamos
        }

        if (c > mayor)
        {
            mayor = c; // Si c es mayor, actualizamos
        }

        // Mostrar el resultado
        Console.WriteLine($"El mayor de los tres números es: {mayor}");
    }
}
