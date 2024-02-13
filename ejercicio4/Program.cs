using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int n1,n2,n3;
            Console.WriteLine("Ingrese 3 números por favor:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if ((n1+n2) > (n2*n3)){

                Console.WriteLine("La suma de los 2 primeros es mayor al producto de los 2 últimos");
            }
                Console.WriteLine("Fin del programa");
        }
    }
}
