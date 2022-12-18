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

        public void startEngine()
        {
            Console.WriteLine("El vehículo está encendido.");
            _isOn = true;
        }

        public void stoptEngine()
        {
            Console.WriteLine("El vehículo está apagado.");
            _isOn = false;
        }

    }
}
