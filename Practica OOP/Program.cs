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
            Estudiante estudiante = new Estudiante(
                "Juan Manuel",
                new DateTime(1990, 6, 23),
                "Santo Domingo Norte",
                "Informatica",
                "ID100065890"
            );

            estudiante.MostrarInformacion();
        }
    }
}