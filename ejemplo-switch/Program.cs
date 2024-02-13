using System;

namespace ejemplo_switch
{
    class Program
    {
        static void Main(string[] args)
        {
           int mes;
           Console.WriteLine("ingrese un número:");
           mes = int.Parse(Console.ReadLine());
           switch(mes){
            case 1:
            Console.WriteLine("el mes es enero");
            break;
            case 2:
            Console.WriteLine("el mes es febrero");
            break;
            case 3:
            Console.WriteLine("el mes es marzo");
            break;
            case 4:
            Console.WriteLine("el mes es abril");
            break;
            case 5:
            Console.WriteLine("el mes es mayo");
            break;
            case 6:
            Console.WriteLine("el mes es junio");
            break;
            case 7:
            Console.WriteLine("el mes es julio");
            break;
            case 8:
            Console.WriteLine("el mes es agosto");
            break;
            case 9:
            Console.WriteLine("el mes es septiembre");
            break;
            case 10:
            Console.WriteLine("el mes es octubre");
            break;
            case 11:
            Console.WriteLine("el mes es noviembre");
            break;
            case 12:
            Console.WriteLine("el mes es diciembre");
            break;
            default:
            Console.WriteLine("no se refiere a ningún mes");
            break;
           } 
        }
    }
}
