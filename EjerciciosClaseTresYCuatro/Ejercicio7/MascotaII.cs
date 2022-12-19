using EjerciciosClaseTresYCuatro.Ejercicio6;
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



        public MascotaII createPet(MascotaII mascota)
        {

            mascota.energy = 50;

            Console.WriteLine("Registro de mascota.\n--------------------------------");

            Console.WriteLine("Ingrese el nombre.");
            mascota.name = Console.ReadLine().ToUpper();

            Console.WriteLine("\n--------------------------------\nEs : \n1- Gato\n2- Perro\n--------------------------------");
            mascota.typePet = Console.ReadLine().ToUpper();

            if (mascota.typePet == "gato" || mascota.typePet == "1")
            {
                mascota.typePet = "Gato";
            }
            else if (mascota.typePet == "perro" || mascota.typePet == "2")
            {
                mascota.typePet = "Perro";
            }

            mascota.energy = 70;
            Console.WriteLine("\n--------------------------------\n" + "Nombre: " + mascota.name +
                "\nTipo: " + mascota.typePet + "\nEnergía: " + mascota.energy + "\n" + "--------------------------------" + "");

            return mascota;
        }








        public int alimentar(string name, int energy)
        {
            energy = this.energy += (energy * 30) / 100;
            Console.WriteLine("Se alimentó a " + name);
            Console.WriteLine("Energía restante: " + energy);

            return energy;
        }



        public int correr(int energy)
        {
            energy = this.energy -= (energy * 10) / 100;
            Console.WriteLine("Tu mascota fue a correr.");
            Console.WriteLine("Energía restante: " +energy);
            return energy;
        }




    }
}
