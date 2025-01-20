using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== MENÚ DE EJERCICIOS ===");
            Console.WriteLine("1. Ejercicio 1: Suma de dígitos de un número de dos dígitos.");
            Console.WriteLine("2. Ejercicio 2: Determinar si un número de dos dígitos es primo y negativo.");
            Console.WriteLine("3. Ejercicio 3: Verificar si los dígitos de un número son primos.");
            Console.WriteLine("4. Ejercicio 4: Verificar si la suma de dos números es par.");
            Console.WriteLine("5. Ejercicio 5: Determinar la posición del mayor dígito en un número de tres dígitos.");
            Console.WriteLine("6. Ejercicio 6: Determinar si algún dígito de un número de tres dígitos es múltiplo de otro.");
            Console.WriteLine("7. Ejercicio 7: Encontrar el mayor de tres números usando dos variables.");
            Console.WriteLine("8. Ejercicio 8: Verificar si un número de cinco dígitos es Capicúa.");
            Console.WriteLine("9. Ejercicio 9: Comparar el segundo y penúltimo dígito de un número de cuatro dígitos.");
            Console.WriteLine("10. Ejercicio 10: Mostrar los números entre dos números si su diferencia es ≤ 10.");
            Console.WriteLine("0. Salir.");
            Console.Write("Seleccione el número del ejercicio que desea ejecutar: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "4":
                    Ejercicio4.Ejecutar();
                    break;
                case "5":
                    Ejercicio5.Ejecutar();
                    break;
                case "6":
                    Ejercicio6.Ejecutar();
                    break;
                case "7":
                    Ejercicio7.Ejecutar();
                    break;
                case "8":
                    Ejercicio8.Ejecutar();
                    break;
                case "9":
                    Ejercicio9.Ejecutar();
                    break;
                case "10":
                    Ejercicio10.Ejecutar();
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para regresar al menú...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
