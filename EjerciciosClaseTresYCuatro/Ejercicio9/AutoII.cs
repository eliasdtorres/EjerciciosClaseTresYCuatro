using EjerciciosClaseTresYCuatro.Ejercicio4;
using EjerciciosClaseTresYCuatro.Ejercicio5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjerciciosClaseTresYCuatro.Ejercicio4.PersonaII;
//9. Añadir a la clase Auto un método para acelerar y para frenar. Cada vez que el
//auto acelera incrementa su velocidad en un 10%. Y cada vez que frena
//reduce su velocidad en un 20%. Se debe encender el motor del auto para
//poder acelerar. Agregar métodos para conocer la Velocidad y la Aceleración en cualquier momento.

namespace EjerciciosClaseTresYCuatro.Ejercicio_9
{
    internal class AutoII : Auto
    {

        public double velocity { get; set; }


        public AutoII createCar(AutoII car)
        {

            Console.WriteLine("Registro de Vehículo");
            Console.WriteLine("Ingrese marca.");
            car._carBrand = Console.ReadLine();

            Console.WriteLine("Ingrese modelo.");
            car._model = Console.ReadLine();

            Console.WriteLine("Ingrese color.");
            car._color = Console.ReadLine();

            car.velocity = 0;
            car._isOn = false;

            Console.WriteLine("Marca: " + car._carBrand + "\nModelo: " + car._model + "\nColor: " + car._color + "\n¿Está encendido?: " + car._isOn);

            return car;
        }



        public double acelerate(AutoII car)
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


        public double decelerate(AutoII car)
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


    }
}
