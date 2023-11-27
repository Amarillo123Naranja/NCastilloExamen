using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCastilloExamen
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] color = { "Azul", "Verde", "Rojo" };

            Operador.For(10);
            Operador.Foreach(color);
            Operador.While(2,5);
            Console.ReadKey();


        }
    }
}
