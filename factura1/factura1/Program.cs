using System;

namespace factura1
{
    class Program
    {
        // factura-- introducir una cantidad positiva por el usuario }
        // primera pregunta introduzca la cantidad vendida  (valor positivo) 
        // despúes introduzca el precio 

        static void Main(string[] args)
        {
            Console.Write(" hola, bienvenido a su facturero personal :)");

            int entero = 0;
            double precio = 0, total = 0;

            do
            {
                do
                {
                    Console.WriteLine("estimado, ingrese la cantidad que vendio");
                    entero = Convert.ToInt16(Console.ReadLine());
                    if (entero < 0)
                    {
                        Console.Write("su valor ingresado no es valido");
                    }
                } while (entero < 0);
                if (entero > 0)
                {
                    Console.WriteLine("ingrese el valor del producto");
                    do
                    {
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0)
                        {
                            Console.Write("su valor ingresado no es valido");
                        }
                        else
                        {
                            total += entero * precio;
                        }
                    } while (precio < 0);
                }
            } while (entero != 0);
            Console.WriteLine(" su total de ventas es pan pan pan!!!!!!!!!!!!! profe en corto pongame 10 " + total);
            Console.ReadKey();
        }
    }
}
