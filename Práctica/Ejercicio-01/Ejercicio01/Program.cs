using System;

/*

1. En este ejercicio, vamos a trabajar con el manejo de
mensajes por pantalñla e introducción de información por
teclado. Tenemos que realizar lo siguiente:

a. Introducir por teclado el nombre, apellidos, edad y 
una afición, y almacenarlo.
b- Mostrarlo en el siguiente dormato.

====== INFORMACIÓN BÁSICA =========
Eres <nombre><apellidos>.
Tienes <años> años.
Hobby: <hobby>.
===================================
*/

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame tu nombre: ");
            string name = Console.ReadLine();
            Console.Write("Dame tus apellidos: ");
            string lastname = Console.ReadLine();
            Console.Write("Dame tu edad: ");
            string age = Console.ReadLine();
            Console.Write("¿Cuál es tu hobby?: ");
            string hobby = Console.ReadLine();
        
            Console.WriteLine("====== INFORMACIÓN BÁSICA =========");
            Console.WriteLine($"Eres {name} {lastname}.");
            Console.WriteLine($"Tienes {age} años.");
            Console.WriteLine($"Hobby: {hobby}.");
            Console.WriteLine("===================================");

        }
    }
}
