using EjerciciosClaseTresYCuatro.Ejercicio_9;
using EjerciciosClaseTresYCuatro.Ejercicio11___12___13;
using EjerciciosClaseTresYCuatro.Ejercicio4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjerciciosClaseTresYCuatro.Ejercicio4.PersonaII;
// Ejercicio 11 : Agregar a la clase Auto, la posibilidad de tener una Persona como conductor.

// Siendo que ahora el auto no puede encender su motor si no hay un conductor presente.Además el Conductor debe tener 18 años como mínimo.
//12.Agregar a la clase Auto la posibilidad de llevar Pasajeros. (de 0 a la
//capacidad que tenga el auto). Considere agregar una property Capacidad

//13.Añadir a la clase Auto, la posibilidad de poder llevar una Mascota, pero sólo si hay un conductor presente. La mascota puede o no contar como pasajero
//dependiendo del Tamaño de la mascota. por lo que el número de lugares disponibles puede verse reducido. Además, si no hay lugares disponibles en
//el vehículo, la mascota no podrá subir al auto. Si la Mascota es pequeña, irá en el regazo de algún pasajero, pero no del conductor. Agregar un método
//que permita saber en el regazo de quién va la Mascota. Además otro método para que la Mascota se mueva al regazo de otro pasajero.

namespace EjerciciosClaseTresYCuatro.Ejercicio11
{
    internal class Automovil : AutoII
    {

        public int capacity { get; set; }

        public bool canGetPet { get; set; }




        public Automovil createCar(Automovil car)
        {
            int res = 0;
            bool _isOk = false;
            Console.WriteLine("Registro de Vehículo");

            do
            {

                



                try
                {
                    Console.WriteLine("Elija tipo de vehículo");
                    Console.WriteLine("1- Automovil\n2-SUV\n3-PickUp");
                    res = int.Parse(Console.ReadLine());
                    _isOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Elija una opción válida");
                    _isOk = false;
                }


            } while (!_isOk);

            switch (res)
            {
                case 1:
                    car.capacity = 5;
                    break;
                case 2:
                    car.capacity = 7;
                    break;
                case 3:
                    car.capacity = 2;
                    break;
                default:
                    break;
            }


            Console.WriteLine("------------------------------");
            Console.WriteLine("Ingrese marca.");
            car._carBrand = Console.ReadLine();

            Console.WriteLine("Ingrese modelo.");
            car._model = Console.ReadLine();

            Console.WriteLine("Ingrese color.");
            car._color = Console.ReadLine();
            Console.WriteLine("------------------------------");

            car.velocity = 0;
            car._isOn = false;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Marca: " + car._carBrand + "\nModelo: " + car._model + "\nColor: "  + car._color + "\nCapacidad: " + car.capacity + "\n¿Está encendido?: " + car._isOn);
            Console.WriteLine("------------------------------");
            return car;
        }



        public bool startEngine(PersonaAutomovil p)
        {

            if (p.drive)
            {
                if (p.age(p._dateOfBirth) >= 18)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Es mayor de edad, puede conducir");
                    Console.WriteLine("El vehículo está encendido.");
                    Console.WriteLine("------------------------------");
                    return _isOn = true;
                }
                else
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("No es mayor de edad, no puede conducir");
                    Console.WriteLine("El vehículo está apagado.");
                    Console.WriteLine("------------------------------");
                    return _isOn = false;
                }
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("No hay conductor en el vehículo");
                Console.WriteLine("El vehículo está apagado.");
                Console.WriteLine("------------------------------");
                return _isOn = false;
            }

        }

        public bool stopEngine(bool _isOn)
        {
            Console.WriteLine("El vehículo está apagado.");
            _isOn = false;
            return _isOn;
        }


        public double acelerate(Automovil car)
        {
            if (car._isOn && car.velocity <= 0)
            {
                car.velocity = 40;
                Console.WriteLine("Se aceleró el vehículo.");
                return car.velocity;
            }
            else
            {
                car.velocity += car.velocity * 0.1;
                Console.WriteLine("Se aceleró el vehículo.");
                if (car.velocity > 130)
                {
                    Console.WriteLine("Se llegó a la velocidad máxima permitida.");
                    return car.velocity = 130;
                }
                return car.velocity;
            }
        }


        public double decelerate(Automovil car)
        {
            if (car._isOn && car.velocity > 0)
            {
                car.velocity -= car.velocity * 0.2;
                Console.WriteLine("Se desaceleró el vehículo.");
                if (car.velocity < 1)
                {
                    Console.WriteLine("El vehículo se detuvo");
                    return car.velocity = 0;
                }
                return car.velocity;
            }
            else
            {
                return car.velocity;
            }

        }

        public int getPassenger(Automovil car, List<PersonaAutomovil> passengers)
        {
            bool canGoUp = false;
            if (passengers.Count >= car.capacity)
            {
                canGoUp = true;
            }
            else
            {
                Console.WriteLine("La cantidad de pasajeros es mayor a la capacidad del vehículo");
                canGoUp = false;
            }

            return 0;
        }

        public bool getPet(MascotaAutomovil mascota, Automovil car)
        {
            if (mascota.sizePet == "Chica")
            {
                car.canGetPet = true;
            }
            return false;
        }
    }
}
