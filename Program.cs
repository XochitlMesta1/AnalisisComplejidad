
using System;

namespace AnalisisComplejidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {
                10, 20, 30, 40, 50, 60, 70
            };

            int objetivo = 60;

            Console.WriteLine("==================================");
            Console.WriteLine("   ANALISIS DE ALGORITMOS");
            Console.WriteLine("   BUSQUEDA LINEAL Y BINARIA");
            Console.WriteLine("==================================");

            Console.WriteLine("\nArreglo utilizado:");

            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\n\nNumero que buscamos: " + objetivo);


            int posicionLineal =
                AlgoritmosBusqueda.BusquedaLineal(
                    numeros,
                    objetivo,
                    out int comparacionesLineal
                );

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("         BUSQUEDA LINEAL");
            Console.WriteLine("----------------------------------");

            if (posicionLineal != -1)
            {
                Console.WriteLine(
                    "Numero encontrado en la posicion: "
                    + posicionLineal
                );
            }
            else
            {
                Console.WriteLine("Numero no encontrado.");
            }

            Console.WriteLine(
                "Comparaciones realizadas: "
                + comparacionesLineal
            );

            Console.WriteLine("Complejidad temporal: O(n)");
            Console.WriteLine("Complejidad espacial: O(1)");


            // EJECUTAR BUSQUEDA BINARIA
            int posicionBinaria =
                AlgoritmosBusqueda.BusquedaBinaria(
                    numeros,
                    objetivo,
                    out int comparacionesBinaria
                );

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("         BUSQUEDA BINARIA");
            Console.WriteLine("----------------------------------");

            if (posicionBinaria != -1)
            {
                Console.WriteLine(
                    "Numero encontrado en la posicion: "
                    + posicionBinaria
                );
            }
            else
            {
                Console.WriteLine("Numero no encontrado.");
            }

            Console.WriteLine(
                "Comparaciones realizadas: "
                + comparacionesBinaria
            );

            Console.WriteLine("Complejidad temporal: O(log n)");
            Console.WriteLine("Complejidad espacial: O(1)");


            Console.WriteLine("\n==================================");
            Console.WriteLine("       COMPARACION FINAL");
            Console.WriteLine("==================================");

            Console.WriteLine(
                "Busqueda lineal: "
                + comparacionesLineal
                + " iteraciones"
            );

            Console.WriteLine(
                "Busqueda binaria: "
                + comparacionesBinaria
                + " iteraciones"
            );

            if (comparacionesLineal < comparacionesBinaria)
            {
                Console.WriteLine(
                    "\nLa busqueda lineal realizo menos iteraciones."
                );
            }
            else if (comparacionesBinaria < comparacionesLineal)
            {
                Console.WriteLine(
                    "\nLa busqueda binaria realizo menos iteraciones."
                );
            }
            else
            {
                Console.WriteLine(
                    "\nAmbas realizaron la misma cantidad de iteraciones."
                );
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
