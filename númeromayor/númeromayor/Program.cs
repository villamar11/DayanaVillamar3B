
using System;

namespace númeromayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que lea una serie de números por teclado e indique cuál es el mayor

            int total = 0, num = 0, mayor = 0;
            Console.Write("¿Cúantos número desea ingresar?");
            Console.WriteLine();
            total = int.Parse(Console.ReadLine());
            for (int dato = 0; dato < total; dato++)
            {
                Console.WriteLine("escriba un número a su elección");
                num = int.Parse(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }

            }
            Console.WriteLine("el valor mayor es---->" + mayor);
            Console.ReadKey();
        }
    }
}
