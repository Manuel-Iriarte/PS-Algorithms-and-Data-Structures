using System;

namespace A.StoringAndAccessingData
{
    // los arreglos son estructuras de datos
    // son indice 0
    // tienen tamanios estaticos

    public class Arreglos1
    {

        private readonly Random _random = new Random();
        public void Ejecutar()
        {
            // crear arreglo
            var arreglo = new int[5];

            // llenar arreglo con valores aleatorios
            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = _random.Next(0,1000);
            }

            // mostrar datos del arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Indice {i}: " + arreglo[i]);
            }

            // editar un valor
            arreglo[3] = 666;

            // mostrar datos del arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Indice {i}: " + arreglo[i]);
            }
        } 
    }
}
