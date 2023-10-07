using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resuelto_20211007
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios e = new Ejercicios();

            e.LLenarMatriz();

            //A)
            //string rz;
            //rz = e.VerificarExportador("30-00000000-15");
            //Console.WriteLine("La razon socila es " + rz);

            //B)
            e.AgregarSalidas();

            //E)
            e.ListarAfip();

            Console.WriteLine("Presione enter para salir");
            Console.ReadLine();
        }
    }
}
