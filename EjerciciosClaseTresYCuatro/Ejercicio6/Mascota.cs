using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//6. Crear una clase Mascota con un método que sirva para alimentarlo. Por cada
//alimento ingerido, incrementa su energía en un 30%. La Mascota debe tener
//nombre, y tipo (gato o perro).
namespace EjerciciosClaseTresYCuatro.Ejercicio6
{
    internal class Mascota
    {
        public string name { get; set; }
        public int energy { get; set; }
        public string typePet { get; set; }


        public Mascota() { }

        public int alimentar(string name, int energy )
        {
            Console.WriteLine("Se alimentó a " + name);

            return this.energy += (energy * 30) / 100;
        }




}
}
