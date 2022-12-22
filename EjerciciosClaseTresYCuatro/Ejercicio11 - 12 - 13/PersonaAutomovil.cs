using EjerciciosClaseTresYCuatro.Ejercicio_9;
using EjerciciosClaseTresYCuatro.Ejercicio10;
using EjerciciosClaseTresYCuatro.Ejercicio3;
using EjerciciosClaseTresYCuatro.Ejercicio4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseTresYCuatro.Ejercicio11
{
    internal class PersonaAutomovil : PersonaIII
    {
        public string _name { get; set; }
        public string _lastname { get; set; }
        public DateTime _dateOfBirth { get; set; }
        public bool drive { get; set; }

        public PersonaAutomovil() { }

        //public void fullname(string _name, string _lastname)
        //{


        //    Console.WriteLine("Nombre completo: " + _name + " " + _lastname);


        //}

        //public int age(DateTime _dateOfBirth)
        //{
        //    int age = DateTime.Today.AddTicks(-_dateOfBirth.Ticks).Year - 1;
        //    Console.WriteLine("Edad: " + age);
        //    return age;
        //}





        public PersonaAutomovil createPersona()
        {
            PersonaAutomovil p = new PersonaAutomovil();
            int day = 0, month = 0, year = 0;
            bool _isOk = false;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Registro de persona.");
            Console.WriteLine("Ingrese nombre de la persona");
            p._name = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese apellido.");
            p._lastname = Console.ReadLine().ToUpper();
            Console.WriteLine("Fecha de nacimiento");
            Console.WriteLine("------------------------------");

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



        public bool driveCar(PersonaAutomovil p)
        {
            string res = "";

            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("¿Subirse al vehículo? s/n");
                res = Console.ReadLine().ToLower();

                if (res != "s" && res != "n")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Ingrese una opción válida");
                }

            } while (res != "s" && res != "n");

            if (res == "s")
            {
                p.drive = true;

            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(p._name + " no desea conducir. ");
                p.drive = false;
            }

            return p.drive;
        }

        public List<PersonaAutomovil> createPassengers()
        {

            List<PersonaAutomovil> passengers = new List<PersonaAutomovil>();
            int res = 0;
            string name = "";
            bool isOk =false;
            try
            {

                Console.WriteLine("Cantidad de pasajeros");
                res = int.Parse(Console.ReadLine());
                isOk = true;
            }
            catch (FormatException)
            {
                isOk = false;
                throw;
            }
            PersonaAutomovil p = new PersonaAutomovil();

            Console.WriteLine("Ingrese nombre conductor/a");
            p._name = Console.ReadLine();

            passengers.Add(p);

            while (passengers.Count <= res)
            {
                PersonaAutomovil p1 = new PersonaAutomovil();
                
                Console.WriteLine("Ingrese nombre pasajero/a");
                p._name = Console.ReadLine();
                passengers.Add(p1);
            }


            return passengers;
        }




    }
}
