using EjerciciosClaseTresYCuatro.Ejercicio10;
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
        public bool canHasPet { get; set; }
        public bool hasPet { get; set; }

        public PersonaAutomovil() { }
        public PersonaAutomovil createPersona()
        {
            PersonaAutomovil p = new PersonaAutomovil();
            int day = 0, month = 0, year = 0;
            bool _isOk = true;

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
                _isOk = true;
                try
                {

                    Console.WriteLine("Ingrese día: ");
                    day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese mes: ");
                    month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese año: ");
                    year = int.Parse(Console.ReadLine());

                    p._dateOfBirth = new DateTime(year, month, day);

                }
                catch (FormatException)
                {
                    _isOk = false;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Ingrese valores numéricos");
                    Console.WriteLine("-----------------------------------------");
                }
                catch (ArgumentOutOfRangeException)
                {
                    _isOk = false;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Ingrese fechas correctas.");
                    Console.WriteLine("-----------------------------------------");
                }

            } while (!_isOk);


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

            string pax = "", morePax = "";

            PersonaAutomovil chofer = new PersonaAutomovil();
            chofer = chofer.createPersona();
            //Console.WriteLine("Ingrese nombre conductor/a");
            //chofer._name = Console.ReadLine().ToUpper();
            //chofer.canHasPet = false;
            //chofer.drive= true;

            passengers.Add(chofer);

            do
            {
                Console.WriteLine("¿Subir pasajero? s/n");
                pax = Console.ReadLine().ToLower();

                if (pax != "s" && pax != "n")
                {
                    Console.WriteLine("Ingrese una opción correcta (s/n)");
                }

            } while (pax != "s" && pax != "n");


            if (pax == "s")
            {
                do
                {
                    PersonaAutomovil p = new PersonaAutomovil();

                    Console.WriteLine("Ingrese nombre pasajero/a");

                    p._name = Console.ReadLine().ToUpper();
                    p.canHasPet = true;
                    p.drive = false;

                    passengers.Add(p);

                    do
                    {

                        Console.WriteLine("¿Ingresar más pasajeros ? s/n");
                        morePax = Console.ReadLine();

                        if ((morePax != "s" && morePax != "n"))
                        {
                            Console.WriteLine("Ingrese una opción correcta (s/n)");
                        }


                    } while (morePax != "s" && morePax != "n");



                } while (morePax == "s");


            }

            return passengers;
        }



        //while (more == "s" || ((more != "s" && more != "n") && pax == "s") || pax == "")
        //{
        //    PersonaAutomovil p = new PersonaAutomovil();

        //    Console.WriteLine("Ingrese nombre pasajero/a");
        //    p._name = Console.ReadLine().ToUpper();
        //    p.canHasPet = true;
        //    p.drive = false;
        //    passengers.Add(p);

        //    Console.WriteLine("¿Ingresar más pasajeros ? s/n");
        //    more = Console.ReadLine().ToLower();





        public string ToString(PersonaAutomovil p)
        {

            return "Nombre: " + p._name + "\nTiene una mascota encima: " + p.hasPet + "\n--------------------------------------";
        }
    }






}
