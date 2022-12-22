using EjerciciosClaseTresYCuatro.Ejercicio_9;
using EjerciciosClaseTresYCuatro.Ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Crear una clase Auto con un método para encender y apagar el motor. Todo
// auto debe tener un modelo, marca y color.

namespace EjerciciosClaseTresYCuatro.Ejercicio5
{
    internal class Auto
    {
        public string _carBrand { get; set; }
        public string _model{ get; set;}

        public string _color { get; set;}

        public bool _isOn { get; set; }

        public Auto()
        {

        }

        public Auto createCar(Auto car)
        {

            Console.WriteLine("Registro de Vehículo");
            Console.WriteLine("Ingrese marca.");
            car._carBrand = Console.ReadLine();

            Console.WriteLine("Ingrese modelo.");
            car._model = Console.ReadLine();

            Console.WriteLine("Ingrese color.");
            car._color = Console.ReadLine();

            car._isOn = false;

            Console.WriteLine("Marca: " + car._carBrand + "\nModelo: " + car._model + "\nColor: " + car._color + "\n¿Está encendido?: " + car._isOn);

            return car;
        }



        public bool startEngine(bool isOn)
        {
            Console.WriteLine("El vehículo está encendido.");
            _isOn = true;

            return _isOn;
        }

        public bool stopEngine(bool _isOn)
        {
            Console.WriteLine("El vehículo está apagado.");
            _isOn = false;
            return _isOn;
        }

    }
}
