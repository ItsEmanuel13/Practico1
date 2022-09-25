using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno Nuevo = new Alumno();

            Nuevo.setEdad(16);
            Nuevo.setNombre("Juan");

            Nuevo.imprimirNombre();
            Nuevo.imprimirNombreEdad();
        }

        class Alumno
        {

            private string nombreAlumno;
            private int edadAlumno;

            public Alumno()
            {

                this.nombreAlumno = "ninguno";
                this.edadAlumno = 0;
            }

            public Alumno(string nombreAlumno)
            {


                this.nombreAlumno = nombreAlumno;
            }

            public string getNombre()
            {

                return (nombreAlumno);
            }

            public void setNombre(string nombreAlumno)
            {

                this.nombreAlumno = nombreAlumno;

            }

            public Alumno(int edad)
            {

                this.edadAlumno = edad;

            }

            public int getEdad()
            {

                return (edadAlumno);

            }

            public void setEdad(int Edad)
            {

                this.edadAlumno = Edad;

            }


            public void imprimirNombre()
            {

                Console.WriteLine(nombreAlumno);

            }

            public void imprimirNombreEdad()
            {

                Console.WriteLine(nombreAlumno + " " + edadAlumno);

            }


        }


    }
}
