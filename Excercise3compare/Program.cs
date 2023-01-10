using System;

namespace Excercise3compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce el primer numero; ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduce el segundo numero; ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("el primer numero es mayor o igual a 18? " + (num1 >= 18));

            Console.WriteLine("introduce caracter; ");
            char b = Console.ReadKey().KeyChar;
            Console.WriteLine("el caracter es 'a'? " + (b == 'a'));

            Console.WriteLine( "el primer numero es mayor que el segundo y menor a 20? " + ( num1>num2 && num1<20 ) );

            Console.WriteLine("el segundo numero es 7 o es menor a 10 ? " + (num2 == 7 || num2 < 10));

        }
    }
}
