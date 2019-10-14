using System;

namespace dos_columnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int  b= 101, c=0;
            do
            {
                c = c + 1;
                b = b - 1;
                Console.WriteLine((c) + " " + " " + " " + " " + (b)); 
            } while (c <100);
           
            Console.ReadKey();
        }
    }
}
