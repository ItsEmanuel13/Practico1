using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto Nuevo = new Auto("ninguno");

            Nuevo.setAuto("BMW");
            Console.WriteLine(Nuevo.getAuto());
            Console.WriteLine();    

            Nuevo.CambiarTap("azul");
            Nuevo.CambiarTap("ninguno");
            Nuevo.CambiarClimatizador();
            
            

        }

        class Auto {

            private string nuevoAuto;

            public Auto()
            {
                this.nuevoAuto = "ninguno";


            }

            public Auto(string nuevoAuto) { 
            
            
                this.nuevoAuto = nuevoAuto;
            }

            public string getAuto()
            {

                return (nuevoAuto);
            }

            public void setAuto(string nuevoAuto) {

                this.nuevoAuto = nuevoAuto;
            
            }

            public void CambiarTap(string Color) {

                Console.WriteLine("Tapiceria color " + Color);
            
            }

            

            public void CambiarClimatizador() {

                Console.WriteLine("Cambiando climatizador");
            
            }

        }

       
    }
}
