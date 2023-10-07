using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_02
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            int numero;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es mayor que 0.");
            }
            else
            {
                Console.WriteLine("El número es menor que 0.");
            }

        }

        public void Ejercicio2()
        {
            float acumulador = 0;
            float monto;
            bool esValido;

            do
            {
                Console.Write("Ingrese el total de la venta o ´0´ para salir: ");
                monto = Convert.ToSingle(Console.ReadLine());
                acumulador += monto;

                if (monto == 0)
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

            } while (esValido == true);

            Console.WriteLine("El total es: " + acumulador);
        }

        public void Ejercicio3()
        {
            //entrada
            string condicion;
            bool esValido;

            //proceso
            do
            {
                Console.Write("¿Desea continuar en el sistema? (S/N): ");
                condicion = Console.ReadLine();

                if (condicion != "N" && condicion != "S")
                {
                    Console.WriteLine("Condicion invalida, debe ser S o N.");
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }

            } while (condicion == "S" || esValido == false);
        }

        public void Ejercicio4()
        {
            string opcion;
            byte duracion = 0;
            bool flag = true;

            Console.WriteLine("Seleccione el medio de transporte:" + Environment.NewLine +
               "Colectivo" + Environment.NewLine +
               "Subterráneo" + Environment.NewLine +
               "Bicicleta");

            opcion = Console.ReadLine();

            if (opcion == "Colectivo")
            {
                duracion = 30;
            }
            else if (opcion == "Subterráneo")
            {
                duracion = 15;
            }
            else if (opcion == "Bicicleta")
            {
                duracion = 45;
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("Usted eligió: " + opcion + " y tardará " + duracion + " minutos");
            }
            else
            {
                Console.WriteLine("Datos incorrecto");
            }
        }

        public void Ejercicio5A()
        {
            string opcion;
            string msj;
            bool flagDatoIncorrecto;

            do
            {
                flagDatoIncorrecto = false;

                Console.WriteLine("Seleccione la Operación a Realizar:" + Environment.NewLine +
                "1- Altas" + Environment.NewLine +
                "2- Bajas" + Environment.NewLine +
                "3- Modificaciones" + Environment.NewLine +
                "4- Salir");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    msj = "Usted seleccionó Altas";
                }
                else if (opcion == "2")
                {
                    msj = "Usted seleccionó Bajas";

                }
                else if (opcion == "3")
                {
                    msj = "Usted seleccionó Modificaciones";
                }
                else if (opcion == "4")
                {
                    msj = "Usted seleccionó Salir";
                }
                else
                {
                    msj = "Usted ingreso un Dato Erróneo." + Environment.NewLine + "Ingresar la opción nuevamente.";
                    flagDatoIncorrecto = true;
                }

                Console.WriteLine(msj);

            } while (flagDatoIncorrecto == true);
        }

        public void Ejercicio5B()
        {
            string opcion;
            string msj;
            bool flagDatoIncorrecto;

            do
            {
                flagDatoIncorrecto = false;

                Console.WriteLine("Seleccione la Operación a Realizar:" + Environment.NewLine +
                "1- Altas" + Environment.NewLine +
                "2- Bajas" + Environment.NewLine +
                "3- Modificaciones" + Environment.NewLine +
                "4- Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        msj = "Usted seleccionó Altas";
                        break;
                    case "2":
                        msj = "Usted seleccionó Bajas";
                        break;
                    case "3":
                        msj = "Usted seleccionó Medificaciones";
                        break;
                    case "4":
                        msj = "Usted seleccionó Salida";
                        break;
                    default:
                        msj = "Usted ingreso un Dato Erróneo." + Environment.NewLine + "Ingresar la opción nuevamente.";
                        flagDatoIncorrecto = true;
                        break;
                }

                Console.WriteLine(msj);

            }
            while (flagDatoIncorrecto == true);
        }


        public void Ejercicio6()
        {
            int numero1;
            int numero2;

            Console.Write("Por favor ingrese el 1er número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingrese el 2do número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales.");
            }
            else
            {
                Console.WriteLine("Los numeros son distintos.");
            }

        }

        public void Ejercicio7()
        {
            //Declaro variables
            bool flag;
            string lado;
            int lado1;
            int lado2;
            int lado3;

            do
            {
                flag = false;
                Console.Write("Ingrese los cm del lado1: ");
                lado = Console.ReadLine();

                //valido tipo de dato que sea int
                if (!int.TryParse(lado, out lado1))
                {
                    Console.WriteLine("Debe ingresar un numero.");
                }

                //valido que no ingrese un numero negativo
                else if (lado1 < 0)
                {
                    Console.WriteLine("Usted debe ingresar un valor positivo.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            do
            {
                flag = false;
                Console.Write("Ingrese los cm del lado2: ");
                lado = Console.ReadLine();

                //valido tipo de dato que sea int
                if (!int.TryParse(lado, out lado2))
                {
                    Console.WriteLine("Debe ingresar un numero.");
                }

                //valido que no ingrese un numero negativo
                else if (lado2 < 0)
                {
                    Console.WriteLine("Usted debe ingresar un valor positivo.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            do
            {
                flag = false;
                Console.Write("Ingrese los cm del lado3: ");
                lado = Console.ReadLine();

                //valido tipo de dato que sea int
                if (!int.TryParse(lado, out lado3))
                {
                    Console.WriteLine("Debe ingresar un numero.");
                }

                //valido que no ingrese un numero negativo
                else if (lado3 < 0)
                {
                    Console.WriteLine("Usted debe ingresar un valor positivo.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);


            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo es equilátero.");
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("El triangulo es escaleno.");
            }
            else
            {
                Console.WriteLine("El triangulo es isósceles.");
            }
        }

        public void Ejercicio8()
        {
            bool flag;
            string ingreso;
            int numero;
            int contador = 0;
            int acumulador = 0;
            float promedio;
            int valorMax = 0, valorMin = 0;

            do
            {
                do
                {
                    flag = false;
                    Console.Write("Ingrese un número entero o 0 para finalizar: ");
                    ingreso = Console.ReadLine();

                    if (!int.TryParse(ingreso, out numero))
                    {
                        Console.WriteLine("Debe ingresar un valor numérico");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("Debe ingresar un valor positivo");
                    }
                    else
                    {
                        flag = true;
                    }

                } while (flag == false);

                //En la primer pasada, seteamos los valores max y min
                if (contador == 0)
                {
                    valorMax = numero;
                    valorMin = numero;
                }

                //Cuando el numero es diferente a 0, sumo al contador, y acumulo en el acumulador y verifico maximos y minimos
                if (numero != 0)
                {
                    contador++;
                    acumulador += numero;

                    if (numero > valorMax)
                    {
                        valorMax = numero;
                    }

                    if (numero < valorMin)
                    {
                        valorMin = numero;
                    }

                }

            } while (numero != 0);

            promedio = (float)acumulador / contador;

            Console.WriteLine("La cantidad de numeros ingresados fue: " + contador);
            Console.WriteLine("La suma de numeros ingresados fue: " + acumulador);
            Console.WriteLine("El promedio de numeros ingresados fue: " + promedio);
            Console.WriteLine("El numero máximo ingresado fue: " + valorMax);
            Console.WriteLine("El numero mínimo ingresado fue: " + valorMin);
        }


        public void Ejercicio9()
        {
            string numero;
            int salida;
            bool bandera;
            int contador = 0;

            do
            {
                bandera = false;

                Console.Write("Ingrese un número entero menor a 100: ");
                numero = Console.ReadLine();


                if (!int.TryParse(numero, out salida))
                {
                    Console.WriteLine("Usted debe ingresar un dato numérico");
                }
                else if (salida < 0)
                {
                    Console.WriteLine("Usted debe ingresar un número positivo");
                }
                else if (salida >= 100)
                {
                    Console.WriteLine("Usted debe ingresar un número menor a 100");
                }
                else
                {
                    bandera = true;
                }

            } while (bandera == false);


            for (int i = 1; i <= salida; i++)
            {
                if (salida % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine(salida + " es primo");
            }
            else
            {
                Console.WriteLine(salida + " no es primo");
            }
        }
        public void Ejercicio10A()
        {
            int contador = 0;
            int acumulador = 0;
            bool flag;
            string alumnos;
            int salida;

            do
            {
                contador++;

                do
                {
                    flag = false;
                    Console.Write("Ingrese la cantidad de alumnos del curso " + contador + ": ");
                    alumnos = Console.ReadLine();

                    //valido tipo de dato que sea int 
                    if (!int.TryParse(alumnos, out salida))
                    {
                        Console.WriteLine("Usted debe ingresar un dato númerico.");
                    }
                    //valido que no ingrese un numero negativo
                    else if (salida < 0)
                    {
                        Console.WriteLine("Usted debe ingresar un valor positivo.");
                    }
                    else
                    {
                        flag = true;
                        acumulador += salida;
                    }

                } while (flag == false);

            } while (salida != 0);

            Console.WriteLine("La cantidad de alumnos de todos los cursos es " + acumulador);
        }

        public void Ejercicio10B()
        {
            int contador = 0;
            int acumulador = 0;
            bool flag;
            string alumnos;
            int salida;

            do
            {
                contador++;

                do
                {
                    flag = false;
                    Console.Write("Ingrese la cantidad de alumnos del curso " + contador + ": ");
                    alumnos = Console.ReadLine();

                    //valido tipo de dato que sea int 
                    if (!int.TryParse(alumnos, out salida))
                    {
                        Console.WriteLine("Usted debe ingresar un dato númerico.");
                    }
                    //valido que no ingrese un numero negativo ni 0
                    else if (salida <= 0)
                    {
                        Console.WriteLine("Usted debe ingresar un valor positivo.");
                    }
                    else
                    {
                        flag = true;
                        acumulador += salida;
                    }

                } while (flag == false);

            } while (salida <= 99);

            Console.WriteLine("La cantidad de alumnos de todos los cursos es " + acumulador);
        }

        public void Ejercicio11()
        {
            int edad;
            string ingreso1, ingreso2;
            bool flag;
            bool flagNC;
            int g1 = 5, g2 = 15, g3 = 22;

            do
            {
                flag = false;

                do
                {
                    flag = false;
                    Console.Write("Ingrese su edad para saber el valor de la cuota: ");
                    ingreso1 = Console.ReadLine();

                    if (!int.TryParse(ingreso1, out edad))
                    {
                        Console.WriteLine("Ingrese un valor numérico");
                    }
                    else if (edad <= 0)
                    {
                        Console.WriteLine("Ingrese un valor positivo");
                    }
                    else
                    {
                        flag = true;
                    }

                } while (flag == false);


                if (edad < 10)
                {
                    Console.WriteLine("La cuota a pagar es de: " + g1);
                }
                else if (edad < 18)
                {
                    Console.WriteLine("La cuota a pagar es de: " + g2);
                }
                else
                {
                    Console.WriteLine("La cuota a pagar es de: " + g3);
                }


                do
                {
                    flagNC = false;
                    Console.Write("¿Desea realizar una nueva consulta? (SI / NO): ");
                    ingreso2 = Console.ReadLine();

                    if (ingreso2 != "SI" && ingreso2 != "NO")
                    {
                        Console.WriteLine("Debe ingresar SI o NO");
                    }
                    else
                    {
                        flagNC = true;
                    }

                } while (flagNC == false);

            } while (ingreso2 == "SI");
        }

        public void Ejercicio12()
        {
            float monto;
            float acumulador = 0;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un monto o 0 para salir: ");
                monto = Convert.ToSingle(Console.ReadLine());

                if (monto != 0)
                {
                    acumulador += monto;
                    contador++;
                }

            } while (monto != 0);

            Console.WriteLine("Realizo " + contador + " ventas y el total de ellas es de: " + acumulador);
        }

        public void Ejercicio13()
        {
            float promedioActual;
            float ranking;
            byte cantMateriasAprobadas;
            byte cantMateriasRendidas;
            byte cantMateriasFaltantes;
            byte bonificacionMatFaltantes;

            Console.Write("Por favor ingrese la Cantidad Total de Materias aprobadas: ");
            cantMateriasAprobadas = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese la Cantidad Total de Materias rendidas: ");
            cantMateriasRendidas = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese la Cantidad Total de Materias faltantes: ");
            cantMateriasFaltantes = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese su promedio actual: ");
            promedioActual = Convert.ToSingle(Console.ReadLine());

            if (cantMateriasFaltantes == 1)
            {
                bonificacionMatFaltantes = 90;
            }
            else if (cantMateriasFaltantes == 2)
            {
                bonificacionMatFaltantes = 60;
            }
            else if (cantMateriasFaltantes == 3)
            {
                bonificacionMatFaltantes = 45;
            }
            else if (cantMateriasFaltantes == 4)
            {
                bonificacionMatFaltantes = 30;
            }
            else if (cantMateriasFaltantes == 5)
            {
                bonificacionMatFaltantes = 25;
            }
            else if (cantMateriasFaltantes == 6)
            {
                bonificacionMatFaltantes = 20;
            }
            else if (cantMateriasFaltantes == 7)
            {
                bonificacionMatFaltantes = 15;
            }
            else if (cantMateriasFaltantes == 8)
            {
                bonificacionMatFaltantes = 10;
            }
            else if (cantMateriasFaltantes == 9)
            {
                bonificacionMatFaltantes = 5;
            }
            else
            {
                bonificacionMatFaltantes = 0;
            }

            ranking = cantMateriasAprobadas / cantMateriasRendidas * 100 + cantMateriasAprobadas * 3 + promedioActual * 3 + bonificacionMatFaltantes;

            Console.WriteLine("Su ranking es: " + ranking);

        }


        public void Ejercicio14()
        {
            // PROGRAMA PARA SUPERMERCADO
            string precio;
            float salida = 0;
            int contador = 0;
            float acumulador = 0;
            float total;
            float descuento;
            bool flag;

            do
            {
                do
                {
                    Console.Write("Ingrese el precio o -1 para salir: ");
                    precio = Console.ReadLine();
                    flag = ValidarPrecio(precio, ref salida);

                } while (flag == false);

                if (salida != -1)
                {
                    contador++;
                    acumulador += salida;
                }

            } while (salida != -1);

            if (acumulador >= 300)
            {
                descuento = acumulador * 0.07f;
            }
            else if (acumulador >= 200)
            {
                descuento = acumulador * 0.05f;
            }
            else if (acumulador >= 100)
            {
                descuento = acumulador * 0.03f;
            }
            else if (contador >= 10)
            {
                descuento = acumulador * 0.015f;
            }
            else
            {
                descuento = 0;
            }

            total = acumulador - descuento;

            Console.WriteLine("TOTAL A PAGAR: $ " + total);
            Console.WriteLine("TOTAL DESCUENTO: $ " + descuento);
            Console.WriteLine("CANTIDAD DE PRODUCTOS: " + contador);
        }

        private bool ValidarPrecio(string precio, ref float Salida)
        {
            bool flag = false;

            if (!float.TryParse(precio, out Salida))
            {
                Console.WriteLine("Debe ingresar un valor numerico");
            }
            else if (Salida > 50)
            {
                Console.WriteLine("El precio no puede ser mayor a 50");
            }
            else if (Salida <= 0 && Salida != -1)
            {
                Console.WriteLine("El precio debe ser positivo");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
