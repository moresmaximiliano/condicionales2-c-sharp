using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.

            int n1,n2,n3,n4;
            Console.WriteLine("Ingrese 4 números por favor:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n2 > n3 && n3 > n4){

                Console.WriteLine("Los números ingresados estan ordenados de forma decreciente");
            }
            Console.WriteLine("Fin del programa");       
        }   
    }
}