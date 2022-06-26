using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, resultado;
            double i = 0;

            Console.WriteLine("Qual a tabuada? ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o número de início? ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o número final? ");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 < 0 || n1 > 100 || n2 < 0 || n2 > 100 || n3 < 0 || n3 > 100)
            {
                Console.WriteLine("Número inválido");
            }
            else
            {

                for (i = n2; i <= n3; i++)
                {
                    resultado = n1 * n2;
                    Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
                    n2++;
                }



                /*
                while (n2 <= n3)
                {
                    resultado = n1 * n2;
                    Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
                    n2++;
                }
                */


                /*
                do
                {
                    resultado = n1 * n2;
                    Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
                    n2++;
                } while (n2 <= n3);
                */

            }

            //Console.Write("\tn1: " + n1 + "\tn2: " + n2 + "\tn3: " + n3);

            Console.ReadKey();
        }
    }
}
