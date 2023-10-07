using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resuelto_20211007
{
    class Ejercicios
    {
        string[,] salidas = new string[6, 5];
        string[,] exportadores = new string[20, 2];

        public void LLenarMatriz()
        {
            int fila;
            int ultimaFila = exportadores.GetLength(0);

            for (fila = 0; fila < ultimaFila; fila++)
            {
                exportadores[fila, 0] = "30-00000000-" + (fila + 1);
                exportadores[fila, 1] = "Empresa " + (fila + 1) + " S.A";
            }
        }

        //A
        public string VerificarExportador(string cuit)
        {
            string rz = "";
            int fila;
            int ultimaFila = exportadores.GetLength(0);

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (cuit == exportadores[fila, 0])
                {
                    rz = exportadores[fila, 1];
                    break;
                }
            }

            return rz;
        }

        //B
        public void AgregarSalidas()
        {
            int fila;
            int ultimaFila = salidas.GetLength(0);
            string cuit;
            string rz;
            string codigo;
            string mercaderia;
            string legislacion;
            bool flag;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Por favor ingrese el CUIT del exportador del contenedor " + (fila + 1) + ":");
                    cuit = Console.ReadLine();
                    rz = VerificarExportador(cuit);

                    if (string.IsNullOrEmpty(rz))
                    {
                        Console.WriteLine("No existe el exportador con CUIT " + cuit);
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }

                } while (flag == false);

                do
                {
                    Console.Write("Por favor ingrese el código del contenedor " + (fila + 1) + ":");
                    codigo = Console.ReadLine();
                    flag = ValidarVacio(codigo, "Código Contenedor");

                } while (flag == false);

                do
                {
                    Console.Write("Por favor ingrese la mercadería del contenedor " + (fila + 1) + ":");
                    mercaderia = Console.ReadLine();
                    flag = ValidarVacio(mercaderia, "Mercadería Declarada");

                } while (flag == false);

                do
                {
                    Console.Write("Por favor ingrese si el contenedor " + (fila + 1) + " requiere legislación especial:");
                    legislacion = Console.ReadLine();
                    flag = ValidarLegislacion(legislacion);

                } while (flag == false);

                salidas[fila, 0] = codigo;
                salidas[fila, 1] = rz;
                salidas[fila, 2] = DateTime.Now.ToString("dd/MM/yyyy");
                salidas[fila, 3] = mercaderia;
                salidas[fila, 4] = legislacion;

                Console.WriteLine("Se agregó con exito el contenedor " + (fila + 1));
            }
        }

        private bool ValidarVacio(string valor, string campo)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("El campo " + campo + " no debe estar vacío.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool ValidarLegislacion(string legislacion)
        {
            bool flag = false;

            if (legislacion == "SI" || legislacion == "NO")
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("El valor de la legislacion es incorrecto, debe ser (SI/NO)");
            }

            return flag;
        }

        //C)
        public void Legales()
        {
            int fila;
            int ultimaFila = salidas.GetLength(0);
            string mensaje = "";

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (salidas[fila, 4] == "SI")
                {
                    mensaje += salidas[fila, 1] + " - " + salidas[fila, 3] + System.Environment.NewLine;
                }
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                Console.WriteLine("No hay contenedores que siguen legislacion especial");
            } 
            else
            {
                Console.WriteLine("Los contenedores que siguen una legislacion especial son: "
                    + System.Environment.NewLine + mensaje);
            }

        }

        //D)
        public void CantidadContenedores()
        {
            int fila;
            int ultimaFila = salidas.GetLength(0);
            string rz;
            int contador = 0;

            Console.Write("Por favor ingrese la razon social del exportador para buscar la cantida de contenedores:");
            rz = Console.ReadLine();

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (salidas[fila, 1] == rz)
                {
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay contenedores registrados para la empresa " + rz);
            }
            else
            {
                Console.WriteLine("La cantidad de contenedores registrados para la empresa " + rz + " son: " + contador);

            }           
        }

        //E)
        public void ListarAfip()
        {
            int filaE;
            int ultimaFilaE = exportadores.GetLength(0);
            int filaS;
            int ultimaFilaS = salidas.GetLength(0);
            string rz;
            string cuit;
            int contador;
            string lista = "";


            for (filaE = 0; filaE < ultimaFilaE; filaE++)
            {
                //EXPORTADOR
                contador = 0;
                rz = exportadores[filaE, 1];
                cuit = exportadores[filaE, 0];


                for (filaS = 0; filaS < ultimaFilaS; filaS++)
                {
                    //CONTENEDOR
                    if (salidas[filaS, 1] == rz)
                    {
                        if (salidas[filaS, 4] == "SI")
                        {
                            contador++;
                        }
                    }
                }

                if (contador > 3)
                {
                    lista += cuit + System.Environment.NewLine;
                }
            }

            if (string.IsNullOrEmpty(lista))
            {
                Console.WriteLine("No hay exportadores que tengan más de 3 contenedores con legislacion especial");
            }
            else
            {
                Console.WriteLine("Los exportadores que tengan más de 3 contenedores con legislacion especial son: "
                    + System.Environment.NewLine + lista);

            }
        }
    }
}
