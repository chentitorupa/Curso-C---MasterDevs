using System;

namespace MensajePant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenido! ");
            Console.Write("Chente Ruiz");

            // Trabajando con la función WriteLine
            string name = "Chente";
            string lastname = "Ruiz";
            Console.WriteLine("Trabajando con WriteLine()");
            Console.WriteLine("Hola " + name);
            Console.WriteLine("Hola " + name + " " + lastname);
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hola soy {name} {lastname}");

            // Trabajando con la función ReadLine()
            /* Ejemplo 1*/
            Console.WriteLine("Dime tu nombre:");
            Console.WriteLine("Hola " + Console.ReadLine());
            Console.WriteLine("Dime tu edad");
            string edad = Console.ReadLine();
            Console.WriteLine($"Tienes {edad}");
            /* Ejemplo 2*/
            Console.WriteLine("Dame un número");
            // Primero lee el valor y después imprime en pantalla.
            Console.WriteLine($"El número es: {Console.ReadLine()}");
        }
    }
}
