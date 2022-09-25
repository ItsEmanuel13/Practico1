using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En cuantas horas quieres empezar?");
            int horas1 = int.Parse( Console.ReadLine());
            Console.WriteLine("En cuantos minutos quieres empezar?");
            int minutos1 = int.Parse( Console.ReadLine());
            Console.WriteLine("En cuantos segundos quieres empezar?");
            int segundos1 =int.Parse( Console.ReadLine());

            int horas;
            int minutos;    
            int segundos;   
            

            for ( horas = horas1; horas < 25; horas++) {

                if (horas == 24)
                {

                    horas1 = 0;
                }

                for ( minutos = minutos1 ; minutos < 60; minutos++) {

                    if (minutos == 59)
                    {
                        minutos1 = 0;

                    }

                    for( segundos = segundos1; segundos < 60; segundos++){ 

                        if (segundos == 59)
                    {
                        segundos1 = 0;

                    }
                    
                        Console.Clear();
                        Console.WriteLine("RELOJ");
                        Console.WriteLine("Tiempo: " + horas + ": " + minutos + ": " + segundos);
                        Thread.Sleep(950);

                        
                    }
                }


            }

                    
        }
    }
}
