using EjerciciosClaseTresYCuatro.Ejercicio4;
using EjerciciosClaseTresYCuatro.Ejercicio8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ejercicio 10
//10.Agregar a la clase Persona la posibilidad de tener un Smartphone.

namespace EjerciciosClaseTresYCuatro.Ejercicio10
{
    internal class PersonaIII : PersonaII
    {
        public Smartphone smart { get; set; }
        public bool drive { get; set; }

        public PersonaIII()
        {


        }


        public PersonaIII createPersona()
        {
            PersonaIII p = new PersonaIII();
            int day = 0, month = 0, year = 0;
            bool _isOk = false;

            Console.WriteLine("Registro de persona.");
            Console.WriteLine("Ingrese nombre de la persona");
            p._name = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese apellido.");
            p._lastname = Console.ReadLine().ToUpper();
            Console.WriteLine("Fecha de nacimiento");

            do
            {
                try
                {


                    Console.WriteLine("Ingrese día: ");
                    day = int.Parse(Console.ReadLine());
                     
                    Console.WriteLine("Ingrese mes: ");
                    month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese año: ");
                    year = int.Parse(Console.ReadLine());


                    _isOk = true;
                }
                catch (FormatException)
                {
                    _isOk = false;
                    Console.WriteLine("Ingrese valores numéricos");
                }
            } while (!_isOk);

            if (_isOk)
            {
                p._dateOfBirth = new DateTime(year, month, day);
            }

            return p;
        }



        public bool driveCar(PersonaIII p)
        {
            string res = "";

            do
            {
                Console.WriteLine("¿Subirse al vehículo? s/n");
                res = Console.ReadLine().ToLower();

                if (res != "s" && res != "n")
                {
                    Console.WriteLine("Ingrese una opción válida");
                }

            } while (res != "s" && res != "n");

            if (res == "s")
            {
                p.drive = true;

            }
            else
            {
                Console.WriteLine(p._name + " no desea conducir. ");
                p.drive = false;
            }

            return p.drive;
        }




    }


}
