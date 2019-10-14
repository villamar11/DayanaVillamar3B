using System;

namespace deuno_dos_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un valor");
            int n = Convert.ToInt32(Console.ReadLine());
            {
                int a = 0, b = 0, c = 0;
                if (n > 0)
                {
                    do
                    {
                        a = a + 1;
                        b = b + 2;
                        c = c + 3;
                        Console.WriteLine((a) + " " + " " + (b) + " " + " " + (c));
                    } while (a < n);
                }
                else
                    Console.WriteLine(" el número que usted ingreso no es positivo");
                    Console.ReadKey();
            }
            
        }
    }
}
