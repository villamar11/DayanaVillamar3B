using System;

namespace menú
{
    class Program
    {
        static void Main(string[] args)

        {
            int opción;
            do
            {
                int num1, num2, numero, factorial, suma = 0;
                Console.WriteLine("**********MENÚ**********");
                Console.WriteLine("\nEscoja una opción del menú:");
                Console.WriteLine();
                Console.WriteLine("1-> Salir");
                Console.WriteLine();
                Console.WriteLine("2-> Sumatorio");
                Console.WriteLine();
                Console.WriteLine("3-> Factorial");
                Console.WriteLine();
                Console.WriteLine("*************************");
                opción = Convert.ToInt16(Console.ReadLine());

                switch (opción)
                {
                    case 1:
                        Console.WriteLine("usted acaba de salir del programa");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("ingrese los valores para su suma");
                        num1 = Convert.ToInt16(Console.ReadLine());
                        num2 = Convert.ToInt16(Console.ReadLine());
                        suma = num1 + num2;
                        Console.WriteLine("la suma de sus números ingresados es -->" + suma);
                        Console.WriteLine();
                        Console.WriteLine("Ingresar cualquier tecla para continuar:");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un número para calcular el factorial:");
                        numero = Convert.ToInt16(Console.ReadLine());
                        factorial = numero;
                        for (int r = numero - 1; r >= 1; r--)
                        {
                            factorial = factorial * r;
                        }
                        Console.WriteLine("el factorial de su nmero ingresado es-->" + factorial);
                        Console.WriteLine();
                        Console.WriteLine("Ingresar cualqueir tecla para continuar:");
                        Console.ReadKey();
                        break;

                }

            } while (opción != 1);


        }
    }
}