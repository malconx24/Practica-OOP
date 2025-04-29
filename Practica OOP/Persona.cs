using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    public class Persona
    {
        // Atributos
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        // Constructor
        public Persona(string nombre, DateTime fechaNacimiento, string ciudad)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }

        // Método para calcular la edad en años
        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;

            // Ajuste si aún no ha cumplido años este año
            if (FechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
        // Método para mostrar la información
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Ciudad: " + Ciudad);
            Console.WriteLine("Edad: " + CalcularEdad() + " años");
        }
    }
}