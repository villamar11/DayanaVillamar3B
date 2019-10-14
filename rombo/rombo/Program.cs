using System;

namespace rombo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero el cual será el tamaño de su piramide");
            int tamaño = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= tamaño; i++)
            {
                for (int j = 1; j <= tamaño - i; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 1; g <= (2 * i) - 1; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //parteinferior
            tamaño--;
            for (int i = 1; i <= tamaño; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 1; g <= (tamaño - i) * 2 + 1; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


                Console.ReadLine();
            
        }
    }
}
