using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa te calcula la taza cambio


            double dolar, taza, cambio;

            Console.WriteLine("ESTE PROGRAMA CALCULA LA TAZA DEL DOLAR");

          

            Console.WriteLine("Digite la cantidad en Dolar");
            dolar = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite la Taza del Dolar");
            taza =  double.Parse(Console.ReadLine());

            

            cambio = taza * dolar;
            cambio = Convert.ToInt32(cambio);

            Console.WriteLine("El Resultado de la cantidad de  Pesos RD$ es : "+ cambio);

            Console.ReadKey();


        }
    }
}
