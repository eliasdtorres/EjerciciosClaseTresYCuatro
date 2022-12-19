
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


            // Ejercicio 6 : Alimentar mascota && Ejercicio 7 : agregar método correr();

            MascotaII mascota = new MascotaII();
            string res = "";

            mascota.createPet(mascota);

            Console.WriteLine("¿Qué desea hacer con su mascota?");

            do
            {
                Console.WriteLine("1 - Alimentar\n2 - Jugar\n3 - Nada");
                res = Console.ReadLine().ToLower();



                if (res == "1" || res == "alimentar")
                {

                    if (mascota.energy > 100)
                    {
                        Console.WriteLine("Tu mascota ya comió demasiado.");
                        Console.WriteLine("Energía actual: " + mascota.energy);
                        res = "default";
                    }
                    else
                    {

                        mascota.alimentar(mascota.name, mascota.energy);
                    }
                }
                else if (res == "2" || res == "jugar")
                {

                    if (mascota.energy <= 20)
                    {
                        Console.WriteLine("Tu mascota no tiene suficiente energía.");
                        Console.WriteLine("Energía restante: " + mascota.energy);
                        res = "nada";
                    }
                    else
                    {
                        mascota.correr(mascota.energy);
                    }
                }
                else if (res == "3" || res == "nada")
                {
                    res = "nada";
                }
                else
                {
                    Console.WriteLine("Seleccione una opción válida");
                    res = "default";
                }

               

            } while (res == "default" || res != "nada");

            if (res == "nada")
            {
                Console.WriteLine(mascota.name + " se retiró sileciosamente");
            }
















          

        }

    }
}