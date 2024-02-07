using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        // Atributos de Euro
        private double _cantidad;
        private static double _cotizRespectoDolar;


        // Constructores de Euro
        static Euro()
        {
            _cotizRespectoDolar = 1 / 1.17;
        }


        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }


        public Euro(double cantidad)
        {
            _cantidad = cantidad;
        }


        // Propiedades de Euro
        public static double GetCotizacion
        {
            get { return _cotizRespectoDolar; }
        }


        public double GetCantidad
        {
            get { return _cantidad; }
        }


        // Sobrecargas implicita de double a Euro
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }


        // Sobrecarga explicita de Dolar y Peso
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad / Euro.GetCotizacion);
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }


        // Sobrecarga de oprador ==
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad == e2.GetCantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }


        //Sobrecarga de operador + entre Euro Peso
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad + ((Euro)p).GetCantidad);
        }
        //Sobrecarga de operador - entre Euro Peso
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad - ((Euro)p).GetCantidad);
        }


        //Sobrecarga de operador + entre Euro Dolar
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad + ((Euro)d).GetCantidad);
        }
        //Sobrecarga de operador - entre Euro Dolar
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad - ((Euro)d).GetCantidad);
        }


        public static void SetCotizacion()
        {

        }
    }
}
