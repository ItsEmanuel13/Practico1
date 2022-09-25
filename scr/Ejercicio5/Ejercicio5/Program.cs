using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];

            int[,] C = new int[3, 3];

            Console.WriteLine("Ingreso de datos Matriz A");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    Console.Write("\nIngrese dato: ");
                    A[i, j] = int.Parse(Console.ReadLine());

                }

            }

            Console.Write("Ingreso de datos Matriz B");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    Console.Write("\nIngrese dato: ");

                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Suma de matrices");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("Resultado de la suma");

            for (int i = 0; i < 3; i++)
            {


                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(C[i, j] + "  ");

                }
            }
        }
    }
}
