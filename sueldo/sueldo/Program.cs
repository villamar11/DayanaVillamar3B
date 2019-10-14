 using System;

namespace sueldo
{
    class Program
    {
        static void Main (string[] args)
        { 
            // crear un programa que permita calcular el salio se manl del trabajor  al que se le pagan 15 dólares por hora 
            //si esta n superan a las 35 horas cada hora superior se consisera como horas extras y se pagara 22 dólares
            // el programa pide las horas del trabajados y devuelve el salario que se debera pagar
            //además pregunta si si deseas cálcular otro salio 
            
            
            int horas = 0, sueldo = 0, extras, a,b;
            Console.WriteLine("ingrese el la cantidas de horas realizadas por el trabajador");
            horas = int.Parse(Console.ReadLine());
            if (horas <= 35)
            {
                sueldo = (horas * 15);
                Console.Write("el sueldo a cancelar de su trabajor es     ----->   "+ sueldo    );
                Console.Write("         que tenga un buen día");
                Console.WriteLine(" ");
            } else
            {
                a = (horas - 35);
                extras = (a * 22);
                b = (35 * 15);
                sueldo = (extras + b);
                Console.Write(" el valor de sueldo mas horas extras es    ------>  " + sueldo);
                Console.Write("         que tenga un buen día");
                Console.WriteLine(" " );
            }
            Console.WriteLine(" ");
            Console.WriteLine("desea cálacular otro sueldo: presione 1, caso contrario 0 ");
            int continuar = int.Parse(Console.ReadLine());
            if (continuar == 1)
            {
                Console.WriteLine("ingrese el la cantidas de horas realizadas por el trabajador");
                horas = int.Parse(Console.ReadLine());
                if (horas <= 35)
                {
                    sueldo = (horas * 15);
                    Console.Write("el sueldo a cancelar de su trabajor es     ----->   " + sueldo );
                    Console.Write("         que tenga un buen día");
                    Console.WriteLine(" ");
                }
                else
                {
                    a = (horas - 35);
                    extras = (a * 22);
                    b = (35 * 15);
                    sueldo = (extras + b);
                    Console.Write(" el valor de sueldo mas horas extras es    ------>  " + sueldo );
                    Console.Write("         que tenga un buen día");
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }   
    }
}
