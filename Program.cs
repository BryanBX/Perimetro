using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cuadrado, Perimetro;
            Console.WriteLine("Escribe el numero de cuadrado");
            Cuadrado = int.Parse(Console.ReadLine());
            Perimetro = Cuadrado * 4;
            Console.WriteLine("El perimetro del cuadrado {0} es {1}",Cuadrado,Perimetro);
            Console.ReadKey();

        }
    }
}
