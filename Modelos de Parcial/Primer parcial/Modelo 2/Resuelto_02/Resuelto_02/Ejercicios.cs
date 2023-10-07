using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resuelto_02
{
    class Ejercicios
    {
        string[,] clases = new string[99,4];
        string[,] docentes = new string[50,3];
        string[,] materiasxTitulo = new string[120,2];

        //A
        public int BuscarMaterias()
        {
            int dni;
            int pos;
            string titulo;
            int fila;
            int ultimaFila = materiasxTitulo.GetLength(0);
            int contador = 0;

            Console.Write("Ingrese el dni del docente: ");
            dni = Convert.ToInt32(Console.ReadLine());

            pos = BuscarDocente(dni);

            if (pos == -1)
            {
                Console.WriteLine("El docente no existe.");
            }
            else
            {
                titulo = docentes[pos, 2];

                for (fila = 0; fila < ultimaFila; fila++)
                {
                    if (materiasxTitulo[fila, 1] == titulo)
                    {
                        contador++;
                    }
                }

                if (contador < 5)
                {
                    Console.WriteLine("El docente puede dictar menos de 5 materias.");
                }
            }

            return contador;

        }

        private int BuscarDocente(int dni)
        {
            int fila;
            int ultimaFila = docentes.GetLength(0);
            int pos = -1;

            for(fila = 0; fila < ultimaFila; fila++)
            {
                if (docentes[fila, 0] == dni.ToString())
                {
                    pos = fila;
                    return pos;
                }
            }

            return pos;
        }

        //B
        public void AgregarClases()
        {
            int fila;
            int ultimaFila = clases.GetLength(0);
            string dni;
            string materia;
            string fecha;
            DateTime fechaS = DateTime.Now;
            string puntaje;
            bool flag;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Ingrese el dni del docente:");
                    dni = Console.ReadLine();
                    flag = ValidarDni(dni);
                } while (flag == false);

                do
                {
                    Console.Write("Ingrese la materia de la clase:");
                    materia = Console.ReadLine();
                    flag = ValidarVacio(materia, "Materia");
                } while (flag == false);

                do
                {
                    Console.Write("Ingrese la fecha de la clase:");
                    fecha = Console.ReadLine();
                    flag = ValidarFecha(fecha, ref fechaS);
                } while (flag == false);

                do
                {
                    Console.Write("Ingrese la fecha de la clase:");
                    puntaje = Console.ReadLine();
                    flag = ValidarPuntaje(puntaje);
                } while (flag == false);

                clases[fila, 0] = dni;
                clases[fila, 1] = materia;
                clases[fila, 2] = fechaS.ToString("dd/MM/yyyy");
                clases[fila, 3] = puntaje;        

            }

            Console.WriteLine("Se agregaron las clases");
        }

        private bool ValidarDni(string numero)
        {
            int salida;
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("El número ingresado no es un dato numérico.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("El número ingresado debe ser positivo.");
            }
            else if (salida.ToString().Length != 8)
            {
                Console.WriteLine("El número ingresado debe tener 8 digitos.");

            }
            else if (BuscarDocente(salida) == -1)
            {
                Console.WriteLine("El docente no existe.");

            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool ValidarVacio(string valor, string campo)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("El campo " + campo + " no puede estar vacío.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool ValidarFecha(string fecha, ref DateTime salida)
        {
            bool flag = false;            

            if (!DateTime.TryParse(fecha, out salida))
            {
                Console.WriteLine("El valor ingresado no corresponde a una fecha valida.");
            }
            else if (salida > DateTime.Now)
            {
                Console.WriteLine("La fecha ingresada no puede ser superior a la fecha del día.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool ValidarPuntaje(string numero)
        {
            int salida;
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("El número ingresado no es un dato numérico.");
            }
            else if (salida < 1 || salida > 10)
            {
                Console.WriteLine("El número ingresado debe ser entre 1 y 10.");            
            }
            else
            {
                flag = true;
            }

            return flag;
        }        

        //C
        public void RecuentoDiario()
        {
            int fila;
            int ultimaFila = clases.GetLength(0);
            int dni;
            string fecha;
            int contador = 0;

            Console.Write("Por favor ingrese el dni del docente:");
            dni = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingrese la fecha de las clases:");
            fecha = Console.ReadLine();

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (clases[fila, 0] == dni.ToString() && clases[fila, 2] == fecha)
                {
                    contador++;                   
                }
            }

            if (contador > 0)
            {
                Console.WriteLine("Las materias para ese docente y fecha son: " + contador +
                    System.Environment.NewLine + "Liquidacion diaria:" + (contador*500) + 
                    System.Environment.NewLine);
            } else
            {
                Console.WriteLine("No hay materias para ese docente y fecha.");
            }
        }

        //D
        public void InsatisfaccionClases()
        {
            int fila;
            int ultimaFila = clases.GetLength(0);
            int dni;
            int contador = 0;
            string acumulador = "";

            Console.Write("Por favor ingrese el dni del docente:");
            dni = Convert.ToInt32(Console.ReadLine());

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (clases[fila, 0] == dni.ToString() &&
                    Convert.ToInt32(clases[fila, 3]) < 4)
                {
                    contador++;
                    acumulador += clases[fila, 1] + System.Environment.NewLine;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine("Las materias para ese docente por debajo de puntaje 4 son: " + contador +
                    System.Environment.NewLine + acumulador);
            }
            else
            {
                Console.WriteLine("No hay materias para ese docente y puntaje debajo de 4.");
            }
        }

        //E
        public void ActividadDiaria()
        {
            int fila;
            int ultimaFila = clases.GetLength(0);
            string fecha;
            int contador = 0;
            string acumulador = "";

            Console.Write("Por favor ingrese la fecha de las clases:");
            fecha = Console.ReadLine();

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (clases[fila, 2] == fecha)
                {
                    contador++;
                    acumulador += clases[fila, 1] + System.Environment.NewLine;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine("Las materias para esa fecha son: " + contador +                    
                    System.Environment.NewLine + acumulador);
            }
            else
            {
                Console.WriteLine("No hay materias para esa fecha.");
            }
        }
    }
}
