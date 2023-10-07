using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_1
{
    class Modelo1
    {
        private static string[,] exportadores = new string[20, 2];
        private static string[,] salidas = new string[100, 5];

        public void LlenarMatriz()
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);

            for( fila = 0; fila < ultimaFila; fila++ ) 
            {
                exportadores[fila, 0] = "30-00000000-" + (fila + 1);
                exportadores[fila, 1] = "Empresa " + (fila + 1) + " S.A";
            }
        }

        /*A) Verificar Exportador(20 puntos)
        Codificar una función VerificarExportador que recibirá como parámetro el número de CUIT de un exportador, y devolverá su razón social que figura en la matriz exportadores.*/
        public string VerificarExportador(string CUIT)
        {
            string razonSoc = "";
            int fila;
            int ultimaFila = exportadores.GetLength(0);

            for( fila = 0; fila < ultimaFila; fila++ ) 
            {
                if(exportadores[fila, 0] == CUIT )
                    return razonSoc = exportadores[fila, 1];
            }
            return razonSoc;
        }

/*        B) Salida(20 puntos)
            Codificar un procedimiento AgregarSalidas que adicionará todas las ventas del día a la matriz salidas(100 registros) debiendo solicitar para cada registro:*/

        public void AgregarSalidas()
        {
            bool flag;
            int fila;
            int ultimaFila = exportadores.GetLength(0);
            string CUIT;
            string razonSoc;
            string contenedor;
            string mercaderia;

            for ( fila = 0; fila < ultimaFila; fila++ )
            {
                do
                {
                    Console.Write("Ingrese el CUIT del exportador: " + (fila + 1));
                    CUIT = Console.ReadLine();
                    razonSoc = VerificarExportador(CUIT);

                    if (string.IsNullOrEmpty(razonSoc))
                    {
                        Console.WriteLine("El CUIT introducido no corresponde a un exportador");
                        flag = false;
                    }
                    else
                        flag = true;
                } while (!flag);

                do
                {
                    Console.Write("Ingrese el numero del contenedor: " + (fila + 1));
                    contenedor = Console.ReadLine();
                    flag = ValidarVacio(contenedor, "Codigo Contenedor");

                } while(!flag);

                do
                {
                    Console.Write("Ingrese la mercaderia del contenedor: " + (fila + 1));
                    mercaderia = Console.ReadLine();
                    flag = ValidarVacio(mercaderia, "Codigo Contenedor");

                } while(!flag);

            }
        }

        private bool ValidarVacio(string valor, string campo)
        {
            bool flag;

            if(string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("El campo " + campo + " no puede estar vacio");
                return flag = false;
            }
            return flag = true;
        }
    }
}
