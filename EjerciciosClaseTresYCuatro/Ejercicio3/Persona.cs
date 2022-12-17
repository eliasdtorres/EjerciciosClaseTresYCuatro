using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//3. Crear una clase Persona que tenga un método para devolver el nombre completo. (Nombre más Apellido).

namespace EjerciciosClaseTresYCuatro.Ejercicio3
{
    internal class Persona
    {
        public string _name { get; set; }
        public string _lastname { get; set; }
        public Persona() { }
        public Persona(string _name, string _lastname)
        {
            this._name = _name;
            this._lastname = _lastname;
        }

        public void fullname(string _name, string _lastname)
        {


            Console.WriteLine("Nombre completo: " + _name + " " + _lastname);


        }

    }
}
