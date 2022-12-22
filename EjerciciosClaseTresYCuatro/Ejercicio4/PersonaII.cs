using EjerciciosClaseTresYCuatro.Ejercicio_9;
using EjerciciosClaseTresYCuatro.Ejercicio3;
using EjerciciosClaseTresYCuatro.Ejercicio8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjerciciosClaseTresYCuatro.Ejercicio_9.AutoII;

namespace EjerciciosClaseTresYCuatro.Ejercicio4
{
    internal class PersonaII : Persona
    {


        public DateTime _dateOfBirth { get; set; }

        public PersonaII() { }


        public int age(DateTime _dateOfBirth)
        {
            int age = DateTime.Today.AddTicks(-_dateOfBirth.Ticks).Year - 1;
            Console.WriteLine("Edad: " + age);
            return age;
        }


    }
}
