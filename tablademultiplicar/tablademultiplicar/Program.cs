using System;

namespace tablademultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero para obtener un atabla de multiplicar");
            int num = Convert.ToInt16(Console.ReadLine());
           
                for (int i = 1; i <= 15; i++)
                {

                    Console.WriteLine(" ");
                    Console.Write((num) + "  x  " + (i) + "=" + (num * i));
                }
           
            
            Console.ReadLine();
        }
    }
}
