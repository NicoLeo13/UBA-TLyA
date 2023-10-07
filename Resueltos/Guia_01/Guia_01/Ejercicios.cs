using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_01
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            Console.WriteLine("Hola Mundo!");
        }

        public void Ejercicio2A()
        {
            string nombre = "Mariano";
            string pais = "Argentina";
            byte edad = 30;

            Console.WriteLine("Su nombre es " + nombre + ", su pais es " + pais +
                " y su edad es " + edad);
        }

        public void Ejercicio2B()
        {
            string nombre;
            string pais;
            byte edad;

            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su Pais: ");
            pais = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Su nombre es " + nombre + ", su pais es " + pais +
                " y su edad es " + edad);
        }

        public void Ejercicio3()
        {
            string nombre;
            string apellido;
            byte edad;
            string carrera;

            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("Su nombre es " + nombre + ", su apellido es " + apellido +
                ", su edad es " + edad + " y su carrera es " + carrera);

            Console.WriteLine("Nombre: " + nombre + System.Environment.NewLine +
                              "Apellido: " + apellido + System.Environment.NewLine +
                              "Edad: " + edad + System.Environment.NewLine +
                              "Carrera:" + carrera);
        }

        public void Ejercicio4A()
        {
            byte materias;
            byte aprobadas;
            int faltantes;

            Console.Write("Por favor escriba la cantidad de materias: ");
            materias = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor escriba la cantidad de materias que aprobó: ");
            aprobadas = Convert.ToByte(Console.ReadLine());

            faltantes = materias - aprobadas;

            Console.WriteLine("La cantidad de materias faltantes para recibirse es de " + faltantes);

        }

        public void Ejercicio4B()
        {
            const byte materias = 32;
            byte aprobadas;
            int faltantes;

            Console.Write("Por favor escriba la cantidad de materias que aprobó: ");
            aprobadas = Convert.ToByte(Console.ReadLine());

            faltantes = materias - aprobadas;

            Console.WriteLine("La cantidad de materias faltantes para recibirse es de " + faltantes);

        }

        public void Ejercicio5()
        {
            int a;
            int b;
            int c;
            int d;

            Console.Write("Por favor escriba el primer número:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor escriba el segundo número:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor escriba el tercer número:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor escriba el cuarto número:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("el cuarto número es " + d + " , el tercer número es " + c + " , el segundo número es " + b + " y el primer número es " + a + ".");
        }

        public void Ejercicio6()
        {
            float baseRectangulo;
            float alturaRectangulo;
            float areaRectangulo;

            Console.Write("Por favor ingrese lo que mide la base del rectángulo:");
            baseRectangulo = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese lo que mide la altura del rectángulo:");
            alturaRectangulo = Convert.ToSingle(Console.ReadLine());

            areaRectangulo = (baseRectangulo * alturaRectangulo) / 2;
            Console.WriteLine("El área del rectángulo es " + areaRectangulo);
        }

        public void Ejercicio7()
        {
            float baseRectangulo;
            float alturaRectangulo;
            float perimetroRectangulo;
            float areaRectangulo;


            Console.Write("Por favor ingrese lo que mide la base del rectángulo:");
            baseRectangulo = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese lo que mide la altura del rectángulo:");
            alturaRectangulo = Convert.ToSingle(Console.ReadLine());

            perimetroRectangulo = 2 * baseRectangulo + 2 * alturaRectangulo;
            areaRectangulo = baseRectangulo * alturaRectangulo;
            Console.WriteLine("El perímetro del rectángulo es " + perimetroRectangulo);
            Console.WriteLine("El área del rectángulo es " + areaRectangulo);
        }

        public void Ejercicio8()
        {
            float carerra;
            float teorico1;
            float teorico2;
            float practico1;
            float practico2;

            Console.Write("Por favor ingrese el promedio de la carrera:");
            carerra = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese la nota del primer parcial teórico de la materia TEORÍA DE LOS LENGUAJES Y ALGORITMOS:");
            teorico1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese la nota del segundo parcial teórico de la materia TEORÍA DE LOS LENGUAJES Y ALGORITMOS:");
            teorico2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese la nota del primer parcial práctico de la materia TEORÍA DE LOS LENGUAJES Y ALGORITMOS:");
            practico1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese la nota del segundo parcial práctico de la materia TEORÍA DE LOS LENGUAJES Y ALGORITMOS:");
            practico2 = Convert.ToSingle(Console.ReadLine());

            float promedioTeorico;
            float promedioPractico;
            float promedioMateria;
            float promedioGeneral;

            promedioTeorico = (teorico1 + teorico2) / 2;
            promedioPractico = (practico1 + practico2) / 2;
            promedioMateria = (teorico1 + teorico2 + practico1 + practico2) / 4;
            promedioGeneral = (carerra + promedioMateria) / 2;

            Console.WriteLine("El promedio de la teoría es " + promedioTeorico);
            Console.WriteLine("El promedio de la práctica es " + promedioPractico);
            Console.WriteLine("El promedio de la materia es " + promedioMateria);
            Console.WriteLine("El promedio general de la carrera es " + promedioGeneral);
        }

        public void Ejercicio9()
        {
            int acumulador = 0;

            Console.Write("Ingrese el primer numero:");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercero numero:");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero:");
            acumulador += Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es " + acumulador);
        }

        public void Ejercicio10()
        {
            int aprobadas;
            int rendidas;
            float promedio;
            float ranking;

            Console.Write("Por favor ingrese la cantidad de materias aprobadas:");
            aprobadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor ingrese la cantidad de materias rendidas:");
            rendidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor ingrese el promedio:");
            promedio = Convert.ToSingle(Console.ReadLine());

            ranking = (aprobadas / rendidas) * 100 + aprobadas * 3 + promedio * 3;
            Console.WriteLine("El ranking del estudiante es " + ranking);
        }

        public void Ejercicio11()
        {
            float precio1 = 300.00f;
            float precio2 = 500.50f;
            float precio3 = 800.90f;
            float total;

            int UnidadesDelproducto1;
            int UnidadesDelproducto2;
            int UnidadesDelproducto3;

            Console.Write("Por favor ingrese la cantidad de unidades compradas del producto 1:");
            UnidadesDelproducto1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Por favor ingrese la cantidad unidades compradas del producto 2:");
            UnidadesDelproducto2 = Convert.ToByte(Console.ReadLine());
            Console.Write("Por favor ingrese la cantidad unidades compradas del producto 3:");
            UnidadesDelproducto3 = Convert.ToByte(Console.ReadLine());

            total = UnidadesDelproducto1 * precio1 + UnidadesDelproducto2 * precio2 + UnidadesDelproducto3 * precio3;
            Console.WriteLine("El importe total a pagar es " + total);
        }
    }
}
