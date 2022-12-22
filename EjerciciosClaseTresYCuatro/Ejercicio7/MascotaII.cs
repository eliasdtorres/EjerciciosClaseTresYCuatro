using EjerciciosClaseTresYCuatro.Ejercicio6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Agregar a la Mascota un método para correr. Cada vez que la mascota corre, gasta un 10% de su energía. Solamente puede correr si su nivel de energía
//es superior al 20%.

namespace EjerciciosClaseTresYCuatro.Ejercicio7
{
    internal class MascotaII : Mascota
    {
        public MascotaII() { }

        public MascotaII createPet(MascotaII mascota)
        {

            mascota.energy = 50;

            Console.WriteLine("Registro de mascota.\n--------------------------------");

            Console.WriteLine("Ingrese el nombre.");
            mascota.name = Console.ReadLine();

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

            mascota.energy = 60;
            Console.WriteLine("\n--------------------------------\n" + "Nombre: " + mascota.name +
                "\nTipo: " + mascota.typePet + "\nEnergía: " + mascota.energy + "\n" + "--------------------------------" + "");

            return mascota;
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
