using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14_04_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su estatura en metros");
            double estatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            persona.Informacion(nombre, estatura, edad);

            persona.mostrarInfo();

            persona.mostrarEdad();
            
            Console.ReadKey();
        }
    }
}
