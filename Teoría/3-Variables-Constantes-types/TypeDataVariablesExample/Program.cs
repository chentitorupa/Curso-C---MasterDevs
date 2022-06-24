using System;

namespace TypeDataVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Tipos de datos numéricos -  Enteros - Con signo");

            // //sbyte -128 a 127
            // //sbyte sbyteInvalid = 140; <-- Error
            // sbyte sbyteValid = 120;
            // Console.WriteLine(sbyteValid);

            // //short -32768 a 32767
            // //short shortInvalid = 32768; <-- Error
            // short shortValid = 32767;
            // Console.WriteLine(shortValid);

            // //int -2,147,483,648 a 2,147,483,647
            // //int IntInvalid = 2147483648; <-- Error
            // int IntValid = 2147483647;
            // Console.WriteLine(IntValid);

            // //long -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            // //long longInvalid = 9223372036854775808; <-- Error
            // long longValid = 9223372036854775807;
            // Console.WriteLine(longValid);

            /*  Datos simples - Tipos Numéricos - Enteros - Sin Signo */

            // Console.WriteLine("Tipos de datos numéricos -  Enteros - Sin signo");

            // //byte 0 / 255
            // //byte byteInvalid = 256; <-- Error
            // byte byteValid = 120;
            // Console.WriteLine(byteValid);

            // //ushort 0 / 65535
            // //ushort ushortInvalid = 65536; <-- Error
            // ushort ushortValid = 32767;
            // Console.WriteLine(ushortValid);

            // //uint 0 / 4294967295
            // //uint uintInvalid = 4294967296; <-- Error
            // uint uintValid = 4294967295;
            // Console.WriteLine(uintValid);

            // //ulong 0 / 18446744073709551615
            // //ulong ulongInvalid = 18446744073709551616; <-- Error
            // ulong ulongValid = 18446744073709551615;
            // Console.WriteLine(ulongValid);

            /* Datos simples - Tipos de Datos Numéricos - No enteros */

            // Console.WriteLine("Tipos de Datos Numéricos - No enteros");

            // //float +-1.5x10^-45 / +-3,4x10^38 - agregar f alfinal del número
            // float floatInvalid = 341000000000000000000000000000000000000.00f; // <-- Error
            // float floatValid = 340000000000000000000000000000000000000.00f;
            // Console.WriteLine(floatInvalid);

            // //double +-5.0x10^-324 / +-1.7x10^308 

            // //decimal +-1.0x10^-28 / +-7.9228x10^28 

            /* Datos simples - NO Numéricos - bool */

            // Console.WriteLine("NO Numéricos - bool");

            // //bool true o false
            // bool startGame = Convert.ToBoolean(1); // true ó Convert.ToBoolean(1)
            // bool endGame = false;  // false ó Convert.ToBoolean(0)
            // Console.WriteLine($"¿Juego Iniciado?: {startGame}");
            // Console.WriteLine($"¿Juego Iniciado?: {endGame}");

            /* Datos simples - NO Numéricos - char */

            Console.WriteLine("NO Numéricos - char");

            //char Unicode - Decimal - Básico
            char charBasic = 'h';   ;
            char charUnicode = '\u0068';
            char charDecimal = Convert.ToChar(104);

            Console.WriteLine($"Básico: {charBasic}");
            Console.WriteLine($"Unicode: {charUnicode}");
            Console.WriteLine($"Decimal: {charDecimal}");

        }
    }
}
