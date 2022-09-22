using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Impresora Nuevo = new Impresora();

            Nuevo.ImprimirFactura();
            Nuevo.ImprimirFacturaLuz();
            Nuevo.ImprimirMunicipal();
            Nuevo.ImprimirRemito();

        }
    }
    class Impresora
    {

        private int fecha;
        private int importe;

        public Impresora()
        {

            this.fecha = 0;
            this.importe = 0;
        }
        public Impresora(int fecha, int importe)
        {

            this.fecha = fecha;
            this.importe = importe;
        }

        public int getFecha()
        {

            return (fecha);
        }

        public void setFecha(int fecha)
        {

            this.fecha = fecha;
        }

        public int getImporte()
        {

            return (importe);
        }

        public void setImporte(int importe)
        {

            this.importe = importe;
        }

        public void ImprimirFactura()
        {

            Console.WriteLine("Imprimiendo Factura");
        }

        public void ImprimirFacturaLuz()
        {

            Console.WriteLine("Imprimiendo Factura de Luz");
        }

        public void ImprimirMunicipal()
        {

            Console.WriteLine("Imprimiendo Municipal");
        }

        public void ImprimirReciboSueldo()
        {

            Console.WriteLine("Imprimiendo Recibo de Sueldo");
        }

        public void ImprimirRemito()
        {

            Console.WriteLine("Imprimiendo Remito");
        }
    }

    class Remito : Impresora
    {

        private int CantBultos;
        private int Numero;

        
        

        public Remito()
        {

            this.CantBultos = 0;
            this.Numero = 0;
        }
        public Remito(int CantBultos, int Numero)
        {

            this.CantBultos = CantBultos;
            this.Numero = Numero;
        }

        public int getCantBultos()
        {

            return (CantBultos);
        }

        public void setCantBultos(int CantBultos)
        {

            this.CantBultos = CantBultos;
        }

        public int getNumero()
        {

            return (Numero);
        }

        public void setNumero(int Numero)
        {

            this.Numero = Numero;
        }

    }

    class FacturaLuz : Impresora
    {

        private int CodigoPago;

        public FacturaLuz()
        {

            this.CodigoPago = 0;

        }

        public FacturaLuz(int CodigoPago)
        {

            this.CodigoPago = CodigoPago;

        }

        public int getCodigoPago()
        {

            return (CodigoPago);
        }

        public void setCodigoPago(int CodigoPago)
        {

            this.CodigoPago = CodigoPago;
        }
    }

    class Municipal : Impresora
    {

        private int Partida;

        public Municipal()
        {

            this.Partida = 0;

        }

        public Municipal(int Partida)
        {

            this.Partida = Partida;

        }

        public int getPartida()
        {

            return (Partida);
        }

        public void setPartida(int Partida)
        {

            this.Partida = Partida;
        }


    }

    class ReciboSueldo : Impresora
    {

        private int Legajo;
        private int Total;

        public ReciboSueldo()
        {

            this.Legajo = 0;
            this.Total = 0;
        }

        public ReciboSueldo(int Legajo, int Total)
        {

            this.Legajo = Legajo;
            this.Total = Total;

        }

        public int getLegajo()
        {

            return (Legajo);
        }

        public void setLegajo(int Legajo)
        {

            this.Legajo = Legajo;
        }

        public int getTotal()
        {

            return (Total);
        }

        public void setTotal(int Total)
        {

            this.Total = Total;
        }


    }

}
