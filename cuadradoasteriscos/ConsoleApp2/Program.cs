using System;

namespace cuadradoasteriscos
{
    class Program
    {
        // ingresar un numero y que se forme un curadrado con la misma cantidad de asteriscos en sus bordes
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca un número para realizar el tamaño de su cuadrado");
            int tlado = Convert.ToInt16(Console.ReadLine());
            
            //arriba
            for (int b = 0; b < tlado; b++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            // centro
            for (int b =0; b < tlado-2; b++)
            {
                Console.Write("*");
                for (int a = 0; a < tlado-2; a ++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" * ");
            }
            // abajo

            for (int b = 0; b < tlado; b++)
            {
                Console.Write("* ");
            }
        }
    }
}
