using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3y4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VectorSuma NuevaSuma = new VectorSuma();
            VectorResta NuevaResta = new VectorResta();
            Distancia NuevaDistancia = new Distancia();

            NuevaSuma.Cargar();
            NuevaSuma.Visualizar();
            NuevaResta.Cargar();
            NuevaResta.Visualizar();
            NuevaDistancia.Cargar();
            NuevaDistancia.Visualizar();

        }

        class VectorSuma
        {

            private int[] A;
            private int[] B;
            private int[] C;

            public void Cargar()
            {
                Console.Write("Ingrese la longitud de los vectores a sumar : ");
                string linea;
                linea = Console.ReadLine();
                int n = int.Parse(linea);
                A = new int[n];
                B = new int[n];
                C = new int[n];
                Console.WriteLine("Ingresando valores al vector A");
                for (int i = 0; i < A.Length; i++)
                {

                    Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                    linea = Console.ReadLine();
                    A[i] = int.Parse(linea);
                }

                Console.WriteLine("Ingresando valores al vector B");
                for (int j = 0; j < B.Length; j++)
                {
                    Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                    linea = Console.ReadLine();
                    B[j] = int.Parse(linea);
                }
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i] + B[i];
                }
            }
            public void Visualizar()
            {
                Console.WriteLine("La suma de los vectores es: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("[" + C[i] + "] ");
                }

                Console.WriteLine();
            }


        }


        class VectorResta
        {

            private int[] A;
            private int[] B;
            private int[] C;
            public void Cargar()
            {
                Console.Write("Ingrese la longitud de los vectores a restar: ");
                string linea;
                linea = Console.ReadLine();
                int n = int.Parse(linea);
                A = new int[n];
                B = new int[n];
                C = new int[n];
                Console.WriteLine("Ingresando valores al vector A");
                for (int i = 0; i < A.Length; i++)
                {

                    Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                    linea = Console.ReadLine();
                    A[i] = int.Parse(linea);
                }

                Console.WriteLine("Ingresando valores al vector B");
                for (int j = 0; j < B.Length; j++)
                {
                    Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                    linea = Console.ReadLine();
                    B[j] = int.Parse(linea);
                }
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i] - B[i];
                }


            }

            public void Visualizar()
            {
                Console.WriteLine("La resta de los vecores es: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("[" + C[i] + "] ");
                }
                Console.WriteLine();
            }


        }

        class Distancia
        {

            private int[] A;
            private int[] B;
            private int[] C;

            public void Cargar()
            {
                Console.Write("Ingrese la longitud de los vectores para calcular la distancia : ");
                string linea;
                linea = Console.ReadLine();
                int n = int.Parse(linea);
                A = new int[n];
                B = new int[n];
                C = new int[n];
                Console.WriteLine("Ingresando valores al vector A");
                for (int i = 0; i < A.Length; i++)
                {

                    Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                    linea = Console.ReadLine();
                    A[i] = int.Parse(linea);
                }

                Console.WriteLine("Ingresando valores al vector B");
                for (int j = 0; j < B.Length; j++)
                {
                    Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                    linea = Console.ReadLine();
                    B[j] = int.Parse(linea);
                }

                Console.WriteLine();
            }

            public void Visualizar()
            {
                var distancia = Math.Sqrt((Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - B[1], 2)));
                Console.WriteLine("La distancia es: " + distancia);
            }

        }

    }
}