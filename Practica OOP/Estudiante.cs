using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP
{
    public class Estudiante : Persona
    {
        public string Carrera;
        public string Matricula;

        public Estudiante(string nombre, DateTime fechaNacimiento, string ciudad, string carrera, string matricula)
            : base(nombre, fechaNacimiento, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); // Muestra info de Persona
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Matrícula: " + Matricula);
        }
    }
}
