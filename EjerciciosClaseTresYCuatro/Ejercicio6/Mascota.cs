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

        public Mascota createPet(Mascota mascota)
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

        public int alimentar(string name, int energy)
        {
            Console.WriteLine("Se alimentó a " + name);

            return this.energy += (energy * 30) / 100;
        }


    }
}
