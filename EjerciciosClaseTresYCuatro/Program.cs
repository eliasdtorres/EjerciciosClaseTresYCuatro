
using EjerciciosClaseTresYCuatro.Ejercicio2;
using EjerciciosClaseTresYCuatro.Ejercicio3;
using EjerciciosClaseTresYCuatro.Ejercicio4;
using EjerciciosClaseTresYCuatro.Ejercicio5;
using EjerciciosClaseTresYCuatro.Ejercicio6;
using EjerciciosClaseTresYCuatro.Ejercicio7;
using System;
using System.IO.IsolatedStorage;

namespace EjerciciosClaseTresYCuatro
{
    class Program
    {
        public static void Main(string[] args)
        {

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 2 : área de un cuadrado

            //Cuadrado square = new Cuadrado();
            //Console.WriteLine("Tamaño lado:");
            //try
            //{
            //    square._side = int.Parse(Console.ReadLine());
            //    Console.WriteLine("El área de un cuadrado de lado: " + square._side +
            //    " es de: " + square.squareArea(square._side));
            //}
            //catch (FormatException) 
            //{

            //    Console.WriteLine("No es un número.");
            //}

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 3 : Mostrar nombre y apellido

            //Persona p = new Persona();
            //p._name = "Juan";
            //p._lastname = " Pérez";

            //Persona p = new Persona("Pablo", "Keinkater");

            //p.fullname( p._name, p._lastname);

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 4 : Mostrar nombre, apellido y edad

            //PersonaII p = new PersonaII();
            //p._name = "Juan";
            //p._lastname = " Pérez";
            //p._dateOfBirth = new DateTime(2000,1,1);

            //PersonaII p = new PersonaII("Pablo", "Keinkater",new DateTime(2000,1,1));

            //p.fullname( p._name, p._lastname);
            //p.age(p._dateOfBirth);

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 5 : encender Auto

            //Auto car = new Auto();
            //car._carBrand = "Ford";
            //car._model = "Mustang";
            //car._color = "Red";

            //Console.WriteLine("Marca del vehículo: " + car._carBrand + "\nModelo: " + car._model + "\nColor: " + car._color);
            //string res = "";

            //if (car._isOn)
            //{
            //    do
            //    {
            //        Console.WriteLine("¿Apagar vehículo? s/n ");
            //        res = Console.ReadLine().ToLower();

            //    } while (res != "s" && res != "n");

            //    if (res == "s")
            //    {
            //        car.stoptEngine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("El vehículo continúa en marcha.");
            //    }
            //}
            //else
            //{
            //    do
            //    {
            //        Console.WriteLine("¿Encender el vehículo? s/n ");
            //        res = Console.ReadLine().ToLower();

            //    } while (res != "s" && res != "n");

            //    if (res == "s")
            //    {
            //        car.startEngine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("El vehículo continúa con el motor detenido.");
            //    }
            //}


            //---------------------------------------------------------------------------------------------------


            // Ejercicio 6 : Alimentar mascota

            //Mascota mascota = new Mascota();
            //mascota.name = "Pelusa";
            //mascota.energy = 60;
            //mascota.typePet = "gato";
            //string res = "";
            //int count = 0;

            //do
            //{
            //    do
            //    {

            //        Console.WriteLine("¿Alimentar a " + mascota.name + "?");
            //        res = Console.ReadLine().ToLower();



            //        count++;

            //    } while (mascota.energy < 100 && res != "s" && res != "n" && count <= 3);


            //    if (res == "s")
            //    {
            //        mascota.alimentar(mascota.name, mascota.energy);
            //        Console.WriteLine("Energía actual: " + mascota.energy + "%.");
            //        if (mascota.energy > 100)
            //        {
            //            Console.WriteLine(mascota.name + " debe ir a gastar energía.");
            //        }



            //    }
            //    else if (count > 3)
            //    {
            //        Console.WriteLine(mascota.name + " se cansó de esperar y se fue.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se alimentó a " + mascota.name);
            //        Console.WriteLine("Energía actual: " + mascota.energy + "%.");
            //    }

            //} while (mascota.energy<100);


            // Ejercicio 7 : Al ejercicio 6 añadir método correr.

            //MascotaII mascota = new MascotaII();
            //mascota.name = "Pelusa";
            //mascota.energy = 50;
            //mascota.typePet = "gato";
            //string res = "";
            //int count = 0;
            //bool mustRun = false;

            //do
            //{
            //    do
            //    {

            //        Console.WriteLine("¿Alimentar a " + mascota.name + "?");
            //        res = Console.ReadLine().ToLower();



            //        count++;

            //    } while (mascota.energy < 100 && res != "s" && res != "n" && count <= 3);


            //    if (res == "s")
            //    {
            //        mascota.alimentar(mascota.name, mascota.energy);
            //        Console.WriteLine("Energía actual: " + mascota.energy + "%.");

            //        if (mascota.energy > 100)
            //        {
            //            Console.WriteLine(mascota.name + " debe ir a gastar energía.");
            //            mustRun = true;
            //        }



            //    }
            //    else if (count > 3)
            //    {
            //        Console.WriteLine(mascota.name + " se cansó de esperar y se fue.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se alimentó a " + mascota.name);
            //        Console.WriteLine("Energía actual: " + mascota.energy + "%.");
            //    }

            //} while (mascota.energy < 100);

            //if (mustRun)
            //{
            //    do
            //    {
            //        mascota.correr(mascota.energy);
            //        Console.WriteLine(mascota.name + " fué a correr, gastó 10% de energía.\nEnergía actual: " +
            //            mascota.energy);
            //    } while (mascota.energy > 20);
            //    mustRun = false;

            //}
            //Console.WriteLine(mascota.name + " tiene " + mascota.energy + "% de energía, no quiere hacer mas nada. Se va a dormir.");

        }

    }
}