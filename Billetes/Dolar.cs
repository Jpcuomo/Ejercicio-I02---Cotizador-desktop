using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        // Atributos de Dolar
        private double _cantidad;
        private static double _cotizRespectoDolar;


        // Constructores de Dolar
        static Dolar()
        {
            _cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }


        // Propiedades de Dolar
        public static double GetCotizacion
        {
            get { return _cotizRespectoDolar; }
        }

        public double GetCantidad
        {
            get { return _cantidad; }
        }


        // Sobrecargas de conversión de double a Dolar
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }


        // Sobrecarga explicita de Euro y Peso
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad * Peso.GetCotizacion);
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad * Euro.GetCotizacion);
        }


        // Sobrecarga de oprador == entre Dolar Dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        // Sobrecarga de oprador == entre Dolar Peso
        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }


        // Sobrecarga de oprador == entre Dolar Euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad == ((Dolar)e).GetCantidad);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }


        //Sobrecarga de operador + entre Dolar Euro
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad + ((Dolar)e).GetCantidad);
        }
        //Sobrecarga de operador - entre Dolar Euro
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad - ((Dolar)e).GetCantidad);
        }


        //Sobrecarga de operador + entre Dolar Peso
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad + ((Dolar)p).GetCantidad);
        }
        //Sobrecarga de operador - entre Dolar Peso
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad - ((Dolar)p).GetCantidad);
        }
    }
}
