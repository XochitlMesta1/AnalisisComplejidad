
using System;

namespace AnalisisComplejidad
{
    internal static class AlgoritmosBusqueda
    {
        // BUSQUEDA LINEAL
        // Complejidad temporal: O(n)
        // Complejidad espacial: O(1)

        public static int BusquedaLineal(
            int[] arreglo,
            int objetivo,
            out int comparaciones)
        {
            comparaciones = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                comparaciones++;

                if (arreglo[i] == objetivo)
                {
                    return i;
                }
            }

            return -1;
        }


        // BUSQUEDA BINARIA
        // Complejidad temporal: O(log n)
        // Complejidad espacial: O(1)
        // IMPORTANTE: El arreglo debe estar ordenado.

        public static int BusquedaBinaria(
            int[] arregloOrdenado,
            int objetivo,
            out int comparaciones)
        {
            comparaciones = 0;

            int inicio = 0;
            int fin = arregloOrdenado.Length - 1;

            while (inicio <= fin)
            {
                comparaciones++;

                int medio = inicio + ((fin - inicio) / 2);

                if (arregloOrdenado[medio] == objetivo)
                {
                    return medio;
                }

                if (arregloOrdenado[medio] < objetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1;
        }
    }
}
