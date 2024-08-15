using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14_04_2024
{
    public class Persona
    {
        public string nombre;
        public double estatura;
        public int edad;

        /* metodo para mostrar la info del usuario
         * metodo para verificar si el usuario es mayor o menor de edad*/

        public void Informacion( string nombre, double estatura, int edad)
        {
            this.nombre = nombre;
            this.estatura = estatura;
            this.edad = edad;
        }

        public void mostrarInfo()
        {
            Console.WriteLine($"Su nombre es: {nombre}");
            Console.WriteLine($"Su estatura es: {estatura}");
            Console.WriteLine($"Su edad es: {edad}");
        }

        public void mostrarEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine($"\n{nombre} tienes {edad} años y es MAYOR DE EDAD");
            }
            else
            {
                Console.WriteLine($"\n{nombre} tienes {edad} años y es MENORDE EDAD");
            }
        }
    }
}
