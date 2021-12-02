using System;

namespace A.StoringAndAccessingData
{
    // Asymtotic analisis of algorithms
    // es acerca de los recuirsos que se ocupan
    // en este caso los recursos son el numero de operaciones que se necesitan para 
    // terminar el proceso
    // por ejemplo buscar una letra del alfabeto
    public class Arreglos2
    {
        public void Ejecutar()
        {
            var letras = new char[]{ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var letraBuscada = 'Y';

            int index = 0;

            while (letras[index] != letraBuscada)
            {
                index++;
                Console.WriteLine($"{index} operacion para encontrar {letraBuscada} en el alfabeto.");
            }
                

            Console.WriteLine($"Maximo numero de operaciones (n) {letras.Length}, Total Operaciones: {index}");

            // Pero esto se necesitan 

            Console.WriteLine("The Big O Notation:");

            // asymtote analysis es la medida en que que el input de una funciona en un algoritmo
            // afecta el comportamiento a medida que se aproxima a su limite.
            // a medida que los numeros crecen en su limite se vuelven mas interesantes los algoritmos

            // algoritmos lineales, generalmente se conforman de 1 loop
            // y al ser lineal O(n) el maximo sera n en consumo de recursos
            // en este caso podria ser encontrar la letra z en el ejemplo del alfabeto
            // algoritmos logaritmicos
            // binary search es catalogado como un algoritmo logaritmico
            // en big O notation Olog(n)


            /*
            Big - Order of magnitude
            A number of very common order of magnitude functions will come up over and over as
            you study algorithms:

            Constant - O(1)
            Logarithmic - O(log n)
            Linear - O(n)
            Log Linear -O(n log n)
            Quadratic - O(n2)
            Exponential - O(2n)
            Factorial - O(n!)
            */
        }
    }
}
