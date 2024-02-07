using Billetes;

namespace Ejercicio_I02___Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso(1);
            Dolar d = new Dolar(5);
            Euro e = new Euro(1);

            Peso peso = (Peso)e;
            Console.WriteLine(peso.GetCantidad);

            Dolar d1 = (Dolar)e;
            Console.WriteLine(d1.GetCantidad);
            Console.WriteLine(((Dolar)e).GetCantidad);

            if (d1 == e)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Peso p1 = ((Peso)e).GetCantidad + 150;
            Console.WriteLine(p1.GetCantidad);
        }
    }
}
