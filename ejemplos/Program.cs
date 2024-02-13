using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND Y OR ... NOT
            // AND = &&
            // OR = ||
            // NOT = ! 

            int edad = 20;
            char inicial = 'J';

            if(edad > 20 && inicial == 'H' && inicial != 'N' || inicial == 'J'){

                Console.WriteLine("21 OFF");
            } 

                 
        }
    }
}
