using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una persona
            Persona persona1 = new Persona("Juan", new DateTime(1990, 6, 24), "Santo Domingo");

            // Mostrar su información
            persona1.MostrarInformacion();
        }
    }
}
