using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Clase_04_09
{
    internal class Condicionales
    {
        public void Ejercicio3()
        {
            byte nota = 8;
            string situacion = "";

            if (nota < 4)
                situacion = "Desaprobado";
            else if (nota < 7)
                situacion = "Regularizado";
            else
                situacion = "Promocionado";

            Console.WriteLine(situacion);
        }

        public void Ejercicio4()
        {
            byte nota = 10;
            string situacion = "";

            if (nota < 1 || nota > 10)
            {
                Console.WriteLine("La nota esta en el rango");
            }
            else if (nota < 4)
                situacion = "Desaprobado";
            else if (nota < 7)
                situacion = "Regularizado";
            else
                situacion = "Promocionado";

            Console.WriteLine(situacion);
        }

        public void Ejercicio5()
        {
            int nota;
            string situacion;
            string situacionTP;

            Console.Write("Ingrese su nota: ");
            nota = Convert.ToByte(Console.ReadLine());
            Console.Write("Ingrese su nota del TP(Aprobado/Desaprobado): ");
            situacionTP = Console.ReadLine();

            if (nota < 4)
                situacion = "Desaprobado";
            else if (nota < 7)
                situacion = "Regularizado";
            else
                situacion = "Promocionado";

            if (situacion != "Desaprobado" && situacionTP == "Aprobado")
                Console.WriteLine("Promocionado");
        }

        public void Ejercicio6()
        {
            int nota;
            string estado;

            Console.Write("Ingrese su nota: ");
            nota = Convert.ToByte(Console.ReadLine());

            switch (nota)
            {
                case 1:
                case 2:
                case 3:
                    estado = "Nefasto, ponete a estudiar";
                    break;
                
                case 4:
                case 5:
                case 6:
                    estado = "Muy bien, segui metiendole";
                    break;

                case 7:
                case 8:
                case 9:
                    estado = "Clave, promocionado";
                    break;

                case 10:
                    estado = "Promocionado nivel GodLike";
                    break;

                default:
                    estado = "Nota fuera de rango";
                    break;
            }

            Console.WriteLine(estado);
        }

        public void Ejercicio7()
        {
            int monto;
            int acumulador = 0;
            string condicionSalida;

            do
            {
                Console.Write("Ingerse un monto: ");
                monto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Desea seguir sumando? (S/N): ");
                condicionSalida = Console.ReadLine();
                acumulador = acumulador + monto;

            } while (condicionSalida == "S");

            Console.WriteLine("hasta luego! El monto total es: " + acumulador);
        }

        public void Ejercicio8()
        {
            int nota;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese una nota: ");
                nota = Convert.ToInt16(Console.ReadLine());
                Console.Write(nota);

                if (i == 4)
                {
                    Console.WriteLine("Numero de iteraciones maximo alcanzado: " + (i + 1));
                    break;
                }
            }

            Console.WriteLine("\nHasta luego");
        }
    }
}
