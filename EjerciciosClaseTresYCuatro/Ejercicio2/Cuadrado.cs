using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Crear una clase Cuadrado con método para calcular el área del mismo.


namespace EjerciciosClaseTresYCuatro.Ejercicio2
{
    internal class Cuadrado
    {
        //public double _side { get; set; }
        public double _side { get; set; }



        public Cuadrado() { }

        public double squareArea(double _side)
        {
            return Math.Pow(_side, 2); ;
        }


    }
}
