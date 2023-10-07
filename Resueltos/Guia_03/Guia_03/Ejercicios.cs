using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_03
{
    class Ejercicios
    {
        public void Ejercicio1()
        {
            int ingreso = 30;

            ProcedimientoPorValor(ingreso);
            Console.WriteLine("El valor de la variable 'Ingreso' por valor es " + ingreso);

            ProcedimientoPorReferencia(ref ingreso);
            Console.WriteLine("El valor de la variable 'Ingreso' por referencia es " + ingreso);
        }

        public void ProcedimientoPorValor(int ingreso)
        {
            ingreso = 40;
        }
		
        private void ProcedimientoPorReferencia(ref int ingreso)
        {
            ingreso = 40;
        }

        public void Ejercicio2()
        {
            string numero1;
            float salida1 = 0;
            string numero2;
            float salida2 = 0;
            float resultado;
            bool flag;

            do
            {
                flag = false;
                Console.Write("Ingrese el 1er numero: ");
                numero1 = Console.ReadLine();
                flag = ValidarFloat(numero1, ref salida1);
            } while (flag == false);

            do
            {
                flag = false;
                Console.Write("Ingrese el 2do numero: ");
                numero1 = Console.ReadLine();
                flag = ValidarFloat(numero1, ref salida2);
            } while (flag == false);


            resultado = CalcularSuma(salida1, salida2);

            Console.WriteLine("La suma es " + resultado);
        }

        private bool ValidarFloat(string numero, ref float salida)
        {
            bool flag = false;

            if (!float.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio3()
        {
            int var1;
            int var2;

            Console.Write("Ingrese el valor de la variable 1: ");
            var1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor de la variable 2: ");
            var2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Var1: " + var1 + ", Var2: " + var2);

            Console.WriteLine("Ahora se intercambiarán los valores.");

            IntercambiarValores(ref var1, ref var2);

            Console.WriteLine("Var1: " + var1 + ", Var2: " + var2);
        }

        private void IntercambiarValores(ref int variable1, ref int variable2)
        {
            int aux;

            aux = variable1;

            variable1 = variable2;
            variable2 = aux;
        }

        public void Ejercicio4()
        {
            int numero;

            //numero = IngresarNumeroA(); NO RECOMENDADO
            numero = IngresarNumeroB();

            Console.WriteLine("El número ingresado es: " + numero);
        }

        private int IngresarNumeroA()
        {
            string numero;
            bool flag = false;
            int salida;

            do
            {
                Console.Write("Ingrese un número del 1 al 10: ");
                numero = Console.ReadLine();

                if (!int.TryParse(numero, out salida))
                {
                    Console.WriteLine("Usted debe ingresar un dato númerico.");
                }
                else if (salida < 1 || salida > 10)
                {
                    Console.WriteLine("Usted ingreso un número fuera de rango.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            return salida;
        }

        private int IngresarNumeroB()
        {
            string numero;
            bool flag;
            int salida = 0;

            do
            {
                Console.Write("Ingrese un número del 1 al 10: ");
                numero = Console.ReadLine();
                flag = ValidarNumero(numero, ref salida);

            } while (flag == false);

            return salida;
        }

        private bool ValidarNumero(string numero, ref int salida)
        {
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if (salida < 1 || salida > 10)
            {
                Console.WriteLine("Usted ingreso un número fuera de rango.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio5()
        {
            int salida1 = 0, salida2 = 0, producto;
            string n1, n2;
            bool flag;

            do
            {

                Console.Write("Ingrese el numero 1: ");
                n1 = Console.ReadLine();
                flag = ValidarValor(n1, ref salida1);

            } while (flag == false);

            do
            {
                Console.Write("Ingrese el numero 2: ");
                n2 = Console.ReadLine();
                flag = ValidarValor(n2, ref salida2);

            } while (flag == false);


            producto = CalcularProducto(salida1, salida2);

            Console.WriteLine("El producto es: " + producto);
        }

        public int CalcularProducto(int n1, int n2)
        {
            return n1 * n2;
        }

        public bool ValidarValor(string numero, ref int salida)
        {
            bool flag = false;

            if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("Solo datos numericos enteros.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Solo se permiten numeros enteros positivos.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public void Ejercicio6()
        {
            int articulo;
            string descripcion = "";
            float precio = 0;

            articulo = IngresarArticulo();
            IngresarDescripcion(articulo, ref descripcion);
            IngresarPrecio(articulo, ref precio);
            MostrarDatos(articulo, descripcion, precio);
        }

        private int IngresarArticulo()
        {
            bool flag;
            string articulo;
            int salida = 0;

            do
            {
                Console.Write("Por favor ingrese un número de artículo entre 1 y 999: ");
                articulo = Console.ReadLine();
                flag = ValidarArticulo(articulo, ref salida);

            } while (flag == false);

            return salida;
        }

        private bool ValidarArticulo(string articulo, ref int salida)
        {
            bool flag = false;

            if (!int.TryParse(articulo, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if (salida < 1 || salida > 999)
            {
                Console.WriteLine("Usted ingreso un número fuera de rango.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private void IngresarDescripcion(int articulo, ref string descripcion)
        {
            bool flag;

            do
            {
                Console.Write("Por favor ingrese la descripción del artículo " + articulo + ": ");
                descripcion = Console.ReadLine();
                flag = ValidarDescripcion(descripcion);

            } while (flag == false);
        }

        private bool ValidarDescripcion(string texto)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("La descripcion no debe ser vacia.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private void IngresarPrecio(int articulo, ref float precio)
        {
            bool flag;
            string strPrecio;

            do
            {
                Console.Write("Por favor ingrese el precio del artículo " + articulo + ": ");
                strPrecio = Console.ReadLine();
                flag = ValidarMonto(strPrecio, ref precio);

            } while (flag == false);
        }

        private bool ValidarMonto(string precio, ref float salida)
        {
            bool flag = false;

            if (!float.TryParse(precio, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if (salida <= 0)
            {
                Console.WriteLine("Usted debe ingresar un numero positivo.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private void MostrarDatos(int articulo, string descripcion, float precio)
        {
            string mensaje;

            mensaje = "Articulo: " + articulo + System.Environment.NewLine +
                      "Descripción: " + descripcion + System.Environment.NewLine +
                      "Precio: " + precio;

            Console.WriteLine(mensaje);
        }

        public void Ejercicio7()
        {
            float monto = 0;
            float descuento;
            float montoFinal;
            string strMonto;
            bool flag;

            do
            {
                Console.Write("Por favor ingrese el monto de la venta: ");
                strMonto = Console.ReadLine();
                flag = ValidarMonto(strMonto, ref monto);

            } while (flag == false);

            descuento = CalcularDescuento(monto);

            montoFinal = monto - descuento;

            Console.WriteLine("El monto final es: " + montoFinal);
        }

        private float CalcularDescuento(float monto)
        {
            float descuento;

            if (monto < 1000)
            {
                descuento = monto * 0.10f;
            }
            else if (monto < 10000)
            {
                descuento = monto * 0.15f;
            }
            else if (monto <= 100000)
            {
                descuento = monto * 0.20f;
            }
            else
            {
                descuento = monto * 0.25f;
            }

            return descuento;
        }

        public void Ejercicio8()
        {
            string opcion;
            float valor1;
            float valor2;
            float resultado;

            do
            {
                Console.WriteLine("Eliga una de las siguientes opciones: " + System.Environment.NewLine +
                "Ingresar 1 para suma." + System.Environment.NewLine +
                "Ingresar 2 para resta." + System.Environment.NewLine +
                "Ingresar 3 para multiplicacion." + System.Environment.NewLine +
                "Ingresar 4 para division." + System.Environment.NewLine +
                "Ingresar 5 para potenciacion." + System.Environment.NewLine +
                "Ingresar 9 para salir." + System.Environment.NewLine);

                opcion = Console.ReadLine();

                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5")
                {
                    valor1 = IngValOperando(-1000, 1000);
                    valor2 = IngValOperando(-100, 100);
                    resultado = CalcularOperacion(opcion, valor1, valor2);
                    MostrarResultado(opcion, valor1, valor2, resultado);
                }

            } while (opcion != "9");

        }

        private float IngValOperando(int rango1, int rango2)
        {
            bool flag = false;
            string input;
            float valor;

            do
            {
                Console.Write("Ingrese un valor numerico:");
                input = Console.ReadLine();

                if (!float.TryParse(input, out valor))
                {
                    Console.WriteLine("Debe ingresar un valor numerico.");
                }
                else if (valor < rango1 || valor > rango2)
                {
                    Console.WriteLine("Debe ingresar un valor entre  " + rango1 + " y " + rango2);
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            return valor;
        }

        private float CalcularOperacion(string opcion, float valor1, float valor2)
        {
            float resultado = 0;

            switch (opcion)
            {
                case "1":
                    resultado = valor1 + valor2;
                    break;
                case "2":
                    resultado = valor1 - valor2;
                    break;
                case "3":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case "4":
                    resultado = valor1 * valor2;
                    break;
                case "5":
                    resultado = Convert.ToSingle(Math.Pow(valor1, valor2));
                    break;
            }

            return resultado;
        }

        private void MostrarResultado(string opcion, float oper1, float oper2, float resultado)
        {
            string msj = "";

            switch (opcion)
            {
                case "1":
                    msj = oper1 + "+" + oper2 + "=" + resultado;
                    break;
                case "2":
                    msj = oper1 + "-" + oper2 + "=" + resultado;
                    break;
                case "3":
                    if (oper2 == 0)
                    {
                        msj = "Division por cero";
                    }
                    else
                    {
                        msj = oper1 + "/" + oper2 + "=" + resultado;
                    }
                    break;
                case "4":
                    msj = oper1 + "*" + oper2 + "=" + resultado;
                    break;               
                case "5":
                    msj = oper1 + "^" + oper2 + "=" + resultado;
                    break;
            }

            Console.WriteLine(msj);
        }

        public void Ejercicio9()
        {
            string opcion;
            float valor1;
            float valor2;
            float resultado = 0;

            do
            {
                Console.WriteLine("Eliga una de las siguientes opciones: " + System.Environment.NewLine +
                "Ingresar 1 para suma." + System.Environment.NewLine +
                "Ingresar 2 para resta." + System.Environment.NewLine +
                "Ingresar 3 para multiplicacion." + System.Environment.NewLine +
                "Ingresar 4 para division." + System.Environment.NewLine +
                "Ingresar 5 para potenciacion." + System.Environment.NewLine +
                "Ingresar 9 para salir." + System.Environment.NewLine);

                opcion = Console.ReadLine();

                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5")
                {
                    valor1 = IngValOperando(-1000, 1000);
                    valor2 = IngValOperando(-100, 100);

                    switch (opcion)
                    {
                        case "1":
                            resultado = CalcularSuma(valor1, valor2);
                            break;
                        case "2":
                            resultado = CalcularResta(valor1, valor2);
                            break;
                        case "3":
                            resultado = CalcularMultiplicacion(valor1, valor2);
                            break;
                        case "4":
                            if (valor2 != 0)
                            {
                                resultado = CalcularDivision(valor1, valor2);
                            }
                            break;
                        case "5":
                            resultado = CalcularPotenciacion(valor1, valor2);
                            break;
                    }

                    MostrarResultado(opcion, valor1, valor2, resultado);
                }



            } while (opcion != "9");
        }

        private float CalcularSuma(float n1, float n2)
        {
            return n1 + n2;
        }

        private float CalcularResta(float n1, float n2)
        {
            return n1 - n2;
        }

        private float CalcularMultiplicacion(float n1, float n2)
        {
            return n1 * n2;
        }

        private float CalcularDivision(float n1, float n2)
        {
            return n1 / n2;
        }

        private float CalcularPotenciacion(float n1, float n2)
        {
            return Convert.ToSingle(Math.Pow(n1, n2));
        }
    }
}
