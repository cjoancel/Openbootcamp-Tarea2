using System;

namespace Excercise1Data
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduce tu Nombre:");
            string Name = Console.ReadLine();

            Console.WriteLine("introduce tu Apellido:");
            string LastName = Console.ReadLine();

            Console.WriteLine("introduce tu edad:");
            int age = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Sabe Programar? (S/N):");
            char c = Console.ReadKey().KeyChar;

            string sabe = c =='S'|| c == 's' ? "Felicidades! Sabes programar" : "Deberias aprender a programar";

            Console.WriteLine("");
            Console.WriteLine("Hola, "+ Name + " " + LastName);
            Console.WriteLine("tu edad es: {0}", age);
            Console.WriteLine(sabe);
            Console.WriteLine("");




        }
    }
}
