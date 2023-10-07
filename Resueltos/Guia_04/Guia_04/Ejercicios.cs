using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_04
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            string[] alumnos = new string[5];
            string nombre;
            int ultimaFila = alumnos.Length;
            int fila;
            bool flag;
            string acumulador = "";

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Por favor, ingrese el nombre del alumno " + (fila + 1) + ": ");
                    nombre = Console.ReadLine();
                    flag = ValidarVacio(nombre, "Nombre");
                } while (!flag);

                alumnos[fila] = nombre;
                acumulador += alumnos[fila] + System.Environment.NewLine;
            }

            Console.WriteLine("El vector de nombres es: " + acumulador);
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

        public void Ejercicio2()
        {
            float[] sueldos = new float[8];
            int ultimaFila = sueldos.GetLength(0);
            int fila;
            float acumulador = 0;
            string sueldo;
            float salida = 0;
            bool flag;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Escriba el sueldo del operario " + (fila + 1) + ": ");
                    sueldo = Console.ReadLine();
                    flag = ValidarFloat(sueldo, ref salida);

                } while (flag == false);

                sueldos[fila] = salida;
                acumulador += sueldos[fila];
            }

            Console.WriteLine("Total de sueldos pagados: " + acumulador);
        }

        public bool ValidarFloat(string numero, ref float salida)
        {
            bool flag = false;

            if (!float.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato numérico.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un número mayor que cero.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        string[,] alumnos3 = new string[5, 2];
        public void Ejercicio3()
        {

            int ultimaFila = alumnos3.GetLength(0);
            string nombre;
            string registro;
            int salida = 0;
            int fila;
            bool flag;
            string acumulador = "";
            int pos;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Por favor escriba el nombre del alumno " + (fila + 1) + ":");
                    nombre = Console.ReadLine();
                    flag = ValidarVacio(nombre, "Nombre");

                } while (flag == false);

                do
                {
                    Console.Write("Por favor escriba el número de registro del alumno " + (fila + 1) + ": ");
                    registro = Console.ReadLine();
                    flag = ValidarInt(registro, ref salida);

                } while (flag == false);

                alumnos3[fila, 0] = nombre;
                alumnos3[fila, 1] = registro;

                acumulador += "Nombre " + alumnos3[fila, 0] + " - " + "Registro " + alumnos3[fila, 1] + System.Environment.NewLine;
            }

            Console.WriteLine(acumulador);

            //Ejercicio4
            registro = Console.ReadLine();
            pos = BuscarAlumno(registro);

            if (pos == -1)
            {
                Console.WriteLine("No existe el alumno con número de registro " + registro);
            }
            else
            {
                Console.WriteLine("Nombre " + alumnos3[pos, 0] + " - " + "Registro " + alumnos3[pos, 1]);
            }
        }

        public bool ValidarInt(string numero, ref int salida)
        {
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato numérico.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un número mayor que cero.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public int BuscarAlumno(string registro)
        {
            int pos = -1;
            int fila;
            int ultimaFila = alumnos3.GetLength(0);

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (alumnos3[fila, 1] == registro)
                {
                    pos = fila;
                }

            }

            return pos;
        }

        string[] personas = new string[5];
        public void Ejercicio5()
        {
            int fila;
            int ultimaFila = personas.GetLength(0);
            string nombre;
            bool flag;
            string acumulador = "";

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Ingrese nombre de la persona" + (fila + 1) + ": ");
                    nombre = Console.ReadLine();
                    flag = ValidarExistenciaNombre(nombre);

                } while (flag == false);

                personas[fila] = nombre;
                acumulador += "Nombre: " + personas[fila] + System.Environment.NewLine;
            }

            Console.WriteLine("Los nombres de la lista son: " + System.Environment.NewLine + acumulador);
        }

        private bool ValidarExistenciaNombre(string nombre)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("No puede estar vacio.");
            }
            else if (BuscarNombre(nombre) != -1)
            {
                Console.WriteLine("El nombre ya existe en la lista.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private int BuscarNombre(string nombre)
        {
            int pos = -1;
            int fila;

            for (fila = 0; fila < personas.Length; fila++)
            {
                if (personas[fila] == nombre)
                {
                    pos = fila;
                }
            }

            return pos;
        }

        public void Ejercicio6()
        {
            float[] sueldos = new float[8];
            int fila;
            int ultimaFila = sueldos.GetLength(0);
            float acumulador = 0;
            bool flag;
            string sueldo;
            float salida = 0;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                do
                {
                    Console.Write("Por favor escriba el sueldo del operario " + (fila + 1) + ": ");
                    sueldo = Console.ReadLine();
                    flag = ValidarDecimal(sueldo, ref salida);
                } while (flag == false);

                sueldos[fila] = salida;
                acumulador += sueldos[fila];

            }

            Console.WriteLine("El total de sueldos es " + acumulador + " y el promedio es " + acumulador / ultimaFila + ".");

        }

        public void Ejercicio7()
        {
            float[] sueldosMañana = new float[4];
            float[] sueldosTarde = new float[4];
            string sueldo;
            bool flag;
            int fila;
            float salidaM = 0;
            float salidaT = 0;
            string acumuladorM = "";
            string acumuladorT = "";

            for (fila = 0; fila < sueldosMañana.GetLength(0); fila++)
            {
                do
                {
                    Console.Write("Por favor ingrese el sueldo del operario " + (fila + 1) + " del turno mañana: ");
                    sueldo = Console.ReadLine();
                    flag = ValidarDecimal(sueldo, ref salidaM);
                } while (flag == false);

                sueldosMañana[fila] = salidaM;
                acumuladorM += "$" + sueldosMañana[fila] + System.Environment.NewLine;

            }

            Console.WriteLine("Los sueldos del turno mañana son:" + System.Environment.NewLine + acumuladorM);

            for (fila = 0; fila < sueldosTarde.GetLength(0); fila++)
            {
                do
                {
                    Console.Write("Por favor ingrese el sueldo del operario " + (fila + 1) + " del turno tarde: ");
                    sueldo = Console.ReadLine();
                    flag = ValidarDecimal(sueldo, ref salidaT);
                } while (flag == false);


                sueldosTarde[fila] = salidaT;
                acumuladorT += "$" + sueldosTarde[fila] + System.Environment.NewLine;
            }

            Console.WriteLine("Los sueldos del turno tarde son:" + System.Environment.NewLine + acumuladorT);
        }

        public void Ejercicio8()
        {
            float[,] alumnos = new float[30, 4];
            int ultimaFila = alumnos.GetLength(0);
            int fila;
            float t1;
            float p1;
            float t2;
            float p2;

            float acumuladorG = 0;
            float acumuladorT = 0;
            float acumuladorP = 0;

            float sumaActual;
            float promedioActual;

            int promocionados = 0;
            int regularizados = 0;
            int desaprobados = 0;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                Console.Write("Ingrese 1er nota teorica del alumno {0}: ", fila + 1);
                t1 = Convert.ToSingle(Console.ReadLine());
                alumnos[fila, 0] = t1;

                Console.Write("Ingrese 1er nota practica del alumno {0}: ", fila + 1);
                p1 = Convert.ToSingle(Console.ReadLine());
                alumnos[fila, 1] = p1;

                Console.Write("Ingrese 2da nota teorica del alumno {0}: ", fila + 1);
                t2 = Convert.ToSingle(Console.ReadLine());
                alumnos[fila, 2] = t2;

                Console.Write("Ingrese 2da nota practica del alumno {0}: ", fila + 1);
                p2 = Convert.ToSingle(Console.ReadLine());
                alumnos[fila, 3] = p2;

                sumaActual = t1 + p1 + t2 + p2;
                promedioActual = Convert.ToSingle(Math.Round(sumaActual / 4));

                acumuladorG += (sumaActual / 4);
                acumuladorT += ((t1 + t2) / 2);
                acumuladorP += ((p1 + p2) / 2);

                if (promedioActual >= 7)
                {
                    promocionados++;
                }
                else if (promedioActual >= 4)
                {
                    regularizados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine(
                "Promedio general: {0}" + System.Environment.NewLine +
                "Promedio teorico: {1}" + System.Environment.NewLine +
                "Promedio practico: {2}" + System.Environment.NewLine +
                "Porcentaje Promocionados: %{3}" + System.Environment.NewLine +
                "Porcentaje Regularizados: %{4}" + System.Environment.NewLine +
                "Porcentaje Desaprobados: %{5}" + System.Environment.NewLine,
                Math.Round(acumuladorG / ultimaFila),
                Math.Round(acumuladorT / ultimaFila),
                Math.Round(acumuladorP / ultimaFila),
                promocionados * 100 / ultimaFila,
                regularizados * 100 / ultimaFila,
                desaprobados * 100 / ultimaFila
            );
        }

        string[,] productos = new string[2, 3];
        public void Ejercicio9()
        {
            int ultimaFila = productos.GetLength(0);
            int fila;

            string nombre;
            string cantidadKg;
            string precioProducto;

            bool flag;
            float salidaQ = 0;
            float salidaP = 0;
            float valorTotal = 0;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                Console.Write("Ingrese el nombre del producto " + (fila + 1) + ": ");
                nombre = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese el precio del producto: " + (fila + 1) + ": ");
                    precioProducto = Console.ReadLine();
                    flag = ValidarDecimal(precioProducto, ref salidaP);

                } while (flag == false);


                do
                {
                    Console.Write("Ingrese la cantidad en Kg del producto: " + (fila + 1) + ": ");
                    cantidadKg = Console.ReadLine();
                    flag = ValidarDecimal(cantidadKg, ref salidaQ);

                } while (flag == false);

                productos[fila, 0] = nombre;
                productos[fila, 2] = salidaP.ToString();
                productos[fila, 1] = salidaQ.ToString();

                valorTotal += (salidaP * salidaQ);
            }

            Console.WriteLine("El valor total del stock es: " + valorTotal);
        }

        private bool ValidarDecimal(string precioProducto, ref float salida)
        {
            bool flag = false;

            if (!float.TryParse(precioProducto, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if (salida < 0)
            {
                Console.WriteLine("Usted debe ingresar un numero igual o mayor a cero.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio10()
        {
            string nombre;
            int pos;

            Console.Write("Ingrese el nombre del producto para calcular el precio: ");
            nombre = Console.ReadLine();

            pos = BuscarProducto(nombre);

            if (pos == -1)
            {
                Console.WriteLine("El producto no existe.");
            }
            else
            {
                Console.WriteLine("El precio de venta del producto es: " + (Convert.ToInt32(productos[pos, 1]) * 1.1));
            }
        }

        private int BuscarProducto(string nombre)
        {
            int fila;
            int ultimaFila = productos.GetLength(0);
            int pos = -1;

            for (fila = 0; fila < ultimaFila; fila++)
            {
                if (productos[fila, 0] == nombre)
                {
                    pos = fila;
                }
            }

            return pos;
        }

        public void Ejercicio11()
        {
            string nombre;
            string stock;
            string costo;
            string costoAnterior;
            float costoFinal;
            float salidaStock = 0;
            float salidaCosto = 0;
            int pos;
            bool flag;

            Console.Write("Ingrese el nombre del producto para actualizar el stock: ");
            nombre = Console.ReadLine();

            pos = BuscarProducto(nombre);

            if (pos == -1)
            {
                Console.WriteLine("El producto no existe.");
            }
            else
            {
                do
                {
                    Console.Write("Ingrese el nuevo stock del producto: ");
                    stock = Console.ReadLine();
                    flag = ValidarDecimal(stock, ref salidaStock);
                } while (flag == false);

                do
                {
                    Console.Write("Ingrese el nuevo costo del producto: ");
                    costo = Console.ReadLine();
                    flag = ValidarDecimal(costo, ref salidaCosto);
                } while (flag == false);

                productos[pos, 1] = salidaStock.ToString(); //Asigno el nuevo stock

                if (salidaStock > 0)
                {
                    costoAnterior = productos[pos, 1];
                    costoFinal = (Convert.ToSingle(costoAnterior) + salidaCosto) / 2;
                    productos[pos, 1] = costoFinal.ToString(); //Asigno el nuevo costo
                }

                Console.WriteLine("Se actualizaron los valores del producto.");

            }
        }
    }
}
