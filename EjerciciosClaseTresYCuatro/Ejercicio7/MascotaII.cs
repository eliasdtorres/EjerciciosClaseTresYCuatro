using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseTresYCuatro.Ejercicio7
{
    internal class MascotaII
    {

        public string name { get; set; }
        public int energy { get; set; }
        public string typePet { get; set; }


        public MascotaII() { }

        public int alimentar(string name, int energy)
        {
            Console.WriteLine("Se alimentó a " + name);

            return this.energy += (energy * 30) / 100;
        }

        public int correr(int energy)
        {

            return this.energy -= (energy * 10) / 100;
        }



    }
}
