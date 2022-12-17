using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseTresYCuatro.Ejercicio4
{
    internal class PersonaII
    {


        public string _name { get; set; }
        public string _lastname { get; set; }

        public DateTime _dateOfBirth { get; set; }

        public PersonaII() { }
        public PersonaII(string name, string lastname, DateTime dateOfBirth)
        {
            _name = name;
            _lastname = lastname;
            _dateOfBirth = dateOfBirth;
        }

        public void fullname(string _name, string _lastname)
        {


            Console.WriteLine("Nombre completo: " + _name + " " + _lastname);


        }

        public void age(DateTime _dateOfBirth)
        {
            int age = DateTime.Today.AddTicks(-_dateOfBirth.Ticks).Year - 1;
            Console.WriteLine("Edad: "+age);
        }
    }
}
