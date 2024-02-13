using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

            // i5 (1)	i7 (2)	i9 (3)
            // 8 RAM (1)	USD 800	USD 900	USD 1200
            // 16 RAM (2)	USD 900	USD 1000	USD 1400
            // 32 RAM (3)	USD 1000	USD 1400	USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            // Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para disco y 0 para no disco) y 
            // calcule y emita por pantalla el monto de la máquina seleccionada.

            int precio = 0, procesador,ram;
            bool disco;
            Console.WriteLine("Seleccione la opción del procesador:");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la opción de la RAM:");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Desea ampliar el disco duro?");
            disco = bool.Parse(Console.ReadLine());
            switch(procesador)
            {
                case 1: 
                switch(ram)
                {
                    case 1:
                    precio += 800;
                    break;
                    case 2:
                    precio += 900;
                    break;
                    case 3:
                    precio += 1000;
                    break;
                    default:
                    Console.WriteLine("La opción de RAM seleccionada no es compatible con nuestra configuración");
                    break;
                }
                break;
                case 2:
                switch(ram)
                {
                    case 1: 
                    precio += 900;
                    break;
                    case 2:
                    precio +=1000;
                    break;
                    case 3:
                    precio += 1400;
                    break;
                    default:
                    Console.WriteLine("La opción de RAM seleccionada no es compatible con nuestra configuración");
                    break;
                }
                break;
                case 3:
                switch(ram)
                {
                    case 1:
                    precio += 1200;
                    break;
                    case 2:
                    precio += 1400;
                    break;
                    case 3:
                    precio += 2000;
                    break;
                    default:
                    Console.WriteLine("La opción de RAM seleccionada no es compatible con nuestra configuración");
                    break;
                }
                break;
                default:
                Console.WriteLine("La opción de Procesador seleccionada no es compatible con nuestra configuración");
                break;
            }
                if (disco && (procesador == 1 || procesador == 2 || procesador == 3) && ( ram == 1 || ram == 2 || ram == 3)){
                    precio += 300;
                }                
                
                if (precio != 0)
                    Console.WriteLine ("El monto de la máquina seleccionada es de " + precio + " dolares.");

                // NO OLVIDARSE DE PONER LOS BREAK AUNQUE LOS CASE SEAN COMPUESTOS
                // PONER true o false si deseamos ampliar el disco

        }
        
    }
}
