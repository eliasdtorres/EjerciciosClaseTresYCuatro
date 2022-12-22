using EjerciciosClaseTresYCuatro.Ejercicio7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseTresYCuatro.Ejercicio11___12___13
{
    internal class MascotaAutomovil : MascotaII
    {

        //public string name { get; set; }
        //public int energy { get; set; }
        //public string typePet { get; set; }

        public string sizePet { get; set; }


        public MascotaAutomovil() { }



        public MascotaAutomovil createPet(MascotaAutomovil mascota)
        {
            int res = 0;
            bool isOk = false;

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

            do
            {
                try
                {
                    Console.WriteLine("Tamaño de mascota (Elija n° correspondiente):\n1- Chica\n2- Mediana\n3- Grande");
                    res = int.Parse(Console.ReadLine());
                    isOk = true;
                }
                catch (FormatException)
                {
                    isOk = false;
                    throw;
                }

            } while (!isOk);

            switch (res)
            {
                case 1:
                    mascota.sizePet = "Chica";
                    break;
                case 2:
                    mascota.sizePet = "Mediana";
                    break;
                case 3:
                    mascota.sizePet = "Grande";
                    break;
            }


            mascota.energy = 70;
            Console.WriteLine("\n--------------------------------\n" + "Nombre: " + mascota.name +
                "\nTipo: " + mascota.typePet + "\nEnergía: " + mascota.energy + "\n" + "--------------------------------" + "");

            return mascota;
        }





















    }

}

