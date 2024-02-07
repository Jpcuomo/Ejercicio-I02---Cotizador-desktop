using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        // Atributos de Peso
        private double _cantidad;
        private static double _cotizRespectoDolar;


        // Constructores de Peso
        static Peso()
        {
            _cotizRespectoDolar = 102.65;
        }


        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }

        public Peso(double cantidad)
        {
            _cantidad = cantidad;
        }


        // Propiedades de Peso
        public static double GetCotizacion
        {
            get {  return _cotizRespectoDolar;}
        }


        public double GetCantidad
        {
            get { return _cantidad; }
        }


        // Sobrecargas de conversión de double a Peso
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }


        // Sobrecarga explicita de Euro y Dolar
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad / Peso.GetCotizacion);
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }


        // Sobrecarga de oprador ==
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }


        //Sobrecarga de operador + entre Peso Euro
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso (p.GetCantidad + ((Peso)e).GetCantidad);
        }
        //Sobrecarga de operador - entre Peso Euro
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad - ((Peso)e).GetCantidad);
        }
        

        //Sobrecarga de operador + entre Peso Dolar
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad + ((Peso)d).GetCantidad);
        }
        //Sobrecarga de operador - entre Peso Dolar
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }

        public static void SetCotizacion()
        {

        }
    }
}
