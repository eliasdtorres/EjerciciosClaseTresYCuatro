﻿
using EjerciciosClaseTresYCuatro.Ejercicio_9;
using EjerciciosClaseTresYCuatro.Ejercicio1;
using EjerciciosClaseTresYCuatro.Ejercicio10;
using EjerciciosClaseTresYCuatro.Ejercicio11;
using EjerciciosClaseTresYCuatro.Ejercicio11___12___13;
using EjerciciosClaseTresYCuatro.Ejercicio15;
using EjerciciosClaseTresYCuatro.Ejercicio2;
using EjerciciosClaseTresYCuatro.Ejercicio3;
using EjerciciosClaseTresYCuatro.Ejercicio4;
using EjerciciosClaseTresYCuatro.Ejercicio5;
using EjerciciosClaseTresYCuatro.Ejercicio6;
using EjerciciosClaseTresYCuatro.Ejercicio7;
using EjerciciosClaseTresYCuatro.Ejercicio8;
using System;
using System.Globalization;
using System.IO.IsolatedStorage;
using static EjerciciosClaseTresYCuatro.Ejercicio_9.AutoII;
using static EjerciciosClaseTresYCuatro.Ejercicio4.PersonaII;

namespace EjerciciosClaseTresYCuatro
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejercicio 1 : Ejercicios de la guía anterior como métodos de una clase ( Funcionan todos ) 
            //EjercicioUno e = new EjercicioUno();
            //e.adivinaNumero2();

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

            //MascotaII mascota = new MascotaII();
            //string res = "";

            //mascota = mascota.createPet(mascota);

            //Console.WriteLine("¿Qué desea hacer con su mascota?");

            //do
            //{
            //    Console.WriteLine("1 - Alimentar\n2 - Jugar\n3 - Nada");
            //    res = Console.ReadLine().ToLower();



            //    if (res == "1" || res == "alimentar")
            //    {


            //        if (mascota.energy > 100)
            //        {
            //            Console.WriteLine("Tu mascota ya comió demasiado.");
            //            Console.WriteLine("Energía actual: " + mascota.energy);
            //            res = "default";
            //        }
            //        else
            //        {

            //            mascota.alimentar(mascota.name, mascota.energy);
            //        }
            //    }
            //    else if (res == "2" || res == "jugar")
            //    {

            //        if (mascota.energy <= 20)
            //        {
            //            Console.WriteLine("Tu mascota no tiene suficiente energía.");
            //            Console.WriteLine("Energía restante: " + mascota.energy);
            //            res = "nada";
            //        }
            //        else
            //        {
            //            mascota.correr(mascota.energy);
            //        }
            //    }
            //    else if (res == "3" || res == "nada")
            //    {
            //        res = "nada";
            //    }
            //    else
            //    {
            //        Console.WriteLine("Seleccione una opción válida");
            //        res = "default";
            //    }



            //} while (res == "default" || res != "nada");

            //if (res == "nada")
            //{
            //    Console.WriteLine(mascota.name + " se retiró sileciosamente");
            //}

            //---------------------------------------------------------------------------------------------------

            //Ejercicio 8 : Smartphone

            //Smartphone smart = new Smartphone();
            //string res = "";
            //string resIsOff = "";

            //smart.createSmartphone(smart);
            //Console.WriteLine("--------------------------------");


            //do
            //{


            //    Console.WriteLine("Acciones: Elija el número de la acción.");



            //    if (smart.isOn)
            //    {

            //        Console.WriteLine("1- Encender \n2- Apagar\n3- Subir volúmen\n4- Bajar volúmen\n5- Silenciar\n6-Quitar silencio\n7- Subir brillo\n8- Bajar brillo\n9- Salir");
            //        Console.WriteLine("--------------------------------");
            //        res = Console.ReadLine();

            //        switch (res)
            //        {
            //            case "1":
            //                Console.WriteLine("--------------------------------");
            //                smart.turnOn(smart);
            //                Console.WriteLine("--------------------------------");

            //                res = "default";
            //                break;
            //            case "2":
            //                Console.WriteLine("--------------------------------");
            //                smart.turnOff(smart);
            //                Console.WriteLine("--------------------------------");

            //                break;
            //            case "3":
            //                smart.volUp(smart);
            //                Console.WriteLine("--------------------------------");
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "4":
            //                Console.WriteLine("--------------------------------");
            //                smart.volDown(smart);
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "5":
            //                Console.WriteLine("--------------------------------");
            //                smart.mute(smart);
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "6":
            //                Console.WriteLine("--------------------------------");
            //                smart.unMute(smart);
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "7":
            //                Console.WriteLine("--------------------------------");
            //                smart.brightUp(smart);
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "8":
            //                Console.WriteLine("--------------------------------");
            //                smart.brightDown(smart);
            //                Console.WriteLine("--------------------------------");
            //                res = "default";
            //                break;
            //            case "9":
            //                break;
            //            default:
            //                Console.WriteLine("Elija una opción válida.");
            //                res = "default";
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("1- Encender\n2- Salir");
            //        Console.WriteLine("--------------------------------");
            //        resIsOff = Console.ReadLine();

            //        switch (resIsOff)
            //        {
            //            case "1": smart.turnOn(smart);
            //                break;
            //            case "2":
            //                smart.isOn = false;
            //                break;
            //            default:
            //                smart.isOn = false;
            //                break;
            //        }


            //    }


            //} while (res == "default" || resIsOff == "1");


            //Console.WriteLine("Programa finalizado");

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 9 : Auto , añadir métodos de acelearación y desaceleración

            //string res = "";
            //AutoII car = new AutoII();
            //car.createCar(car);


            //do
            //{
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine("Seleccione una acción. Elija el número correspondiente");
            //    Console.WriteLine("1- Encender vehiculo\n2- Apagar vehículo\n3- Acelerar\n4- Desacelerar\n5- Salir");
            //    Console.WriteLine("--------------------------------");
            //    res = Console.ReadLine();
            //    switch (res)
            //    {
            //        case "1":
            //            car._isOn = car.startEngine(car._isOn);
            //            res = "default";
            //            Console.WriteLine("--------------------------------");
            //            break;
            //        case "2":
            //            car._isOn = car.stopEngine(car._isOn);
            //            res = "default";
            //            Console.WriteLine("--------------------------------");
            //            break;
            //        case "3":
            //            car.velocity = car.acelerate(car);
            //            Console.WriteLine("Velocidad actual: " + car.velocity + " km/h");
            //            res = "default";
            //            Console.WriteLine("--------------------------------");
            //            break;
            //        case "4":
            //            car.velocity = car.decelerate(car);
            //            Console.WriteLine("Velocidad actual: " + car.velocity + " km/h");
            //            Console.WriteLine("--------------------------------");
            //            res = "default";
            //            break;
            //        case "5":
            //            break;
            //        default:
            //            Console.WriteLine("Elija una opción válida");
            //            res = "default";
            //            Console.WriteLine("--------------------------------");
            //            break;
            //    }
            //} while (res == "default");

            //---------------------------------------------------------------------------------------------------

            //Ejercicio 10 : Agregarle a una persona un Smartphone. Uso de herencia.
            //string res = "";
            //PersonaIII p = new PersonaIII();
            //p = p.createPersona();

            //do
            //{

            //    Console.WriteLine("¿Adquirir Smartphone? S/N");
            //    res = Console.ReadLine().ToLower();


            //    if (res != "s" && res != "n")
            //    {
            //        Console.WriteLine("Elija una opción válida. s/n");
            //    }

            //} while (res != "s" && res != "n");


            //if (res == "s")
            //{
            //    Smartphone smartphone = new Smartphone();

            //    p.smart = smartphone.createSmartphone(smartphone);

            //}
            //else
            //{
            //    Console.WriteLine("No se adquirió ningun smartphone");
            //}

            //---------------------------------------------------------------------------------------------------

            // Ejercicio 11 : Agregar método de validacion de conductor
            //12.Agregar a la clase Auto la posibilidad de llevar Pasajeros.


            // Console.WriteLine("Registro de conductor: ");
            // Console.WriteLine("------------------------------");
            // string res = "";

            // PersonaAutomovil p = new PersonaAutomovil();

            // p = p.createPersona();


            //Automovil car = new Automovil();

            // car = car.createCar(car);

            // p.drive = p.driveCar(p);

            // car.startEngine(p);

            //MascotaII m = new MascotaII();
            //m = m.createPet(m);



            //---------------------------------------------------------------------------------------------------

            //Automovil car = new Automovil();
            //PersonaAutomovil p = new PersonaAutomovil();
            //MascotaAutomovil pet = new MascotaAutomovil();
            //List<PersonaAutomovil> passengers = new List<PersonaAutomovil>();


            //car = car.createCar(car);
            //passengers = p.createPassengers();
            //Console.WriteLine("-------------------------------------------------------------");
            //pet = pet.createPet(pet);
            //Console.WriteLine("-------------------------------------------------------------");
            //car.canGetPassenger = car.GetPassenger(car, passengers);
            //Console.WriteLine("-------------------------------------------------------------");
            //car.canGetPet = car.GetPet(pet, car, passengers, p);
            //Console.WriteLine("-------------------------------------------------------------");
            //car.whoGotThePet(passengers);
            //passengers = pet.move(passengers);
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine("Ahora la mascota la lleva:");
            //car.whoGotThePet(passengers);


            //14.Agregar un método a Auto para bajar a todos los pasajeros.
            //Automovil car = new Automovil();
            //PersonaAutomovil p = new PersonaAutomovil();
            //List<PersonaAutomovil> passengers = new List<PersonaAutomovil>();
            //string descender = "";

            //car = car.createCar(car);
            //passengers = p.createPassengers();
            //car.GetPassenger(car,passengers);

            //passengers[0].drive = passengers[0].driveCar(passengers[0]);
            //Se establece que el conductor quiere y puede conducir el vehículo





            //car.startEngine(passengers[0]);
            //car.acelerate(car);

            //do
            //{
            //    Console.WriteLine("¿Descender pasajeros? s/n");
            //    descender = Console.ReadLine();

            //    if (descender != "s" && descender != "n")
            //    {
            //        Console.WriteLine("Elija opción correcta.");
            //    }

            //} while (descender != "s" && descender != "n");


            //if (descender == "s")
            //{
            //    car.dropPassengers(car, passengers);

            //}
            //else
            //{
            //    Console.WriteLine("No se bajará a ningún pasajero.");
            //}

            //if (!car.canDropPassengers)
            //{
            //    string desacelerar = "";
            //    do
            //    {
            //        Console.WriteLine("¿Detener vehículo? s/n");
            //        desacelerar = Console.ReadLine();

            //        if (desacelerar != "s" && desacelerar != "n")
            //        {
            //            Console.WriteLine("Elija opción correcta.");
            //        }

            //    } while (desacelerar != "s" && desacelerar != "n");



            //    if (desacelerar == "s")
            //    {
            //        while (car.velocity > 0)
            //        {

            //            car.decelerate(car);
            //            Console.WriteLine("Velocidad actual: " + car.velocity + "km/h");
            //        }

            //        Console.WriteLine("---------------------------------------------");
            //        Console.WriteLine("El vehículo está detenido");

            //        car.dropPassengers(car, passengers);

            //        if (car.capacity.Length==1)
            //        {
            //            Console.WriteLine("descendieron todos los pasajeros. ");
            //            Console.WriteLine("Ocupante en el vehículo: ");
            //            Console.WriteLine(passengers[0].ToString(passengers[0],car));
            //        }



            //    }
            //    else
            //    {
            //        Console.WriteLine("El vehículo continúa circulando");
            //    }


            //}

            //Ejercicio 15 : Estudiante con lista de libros
            List<Libro> libros = new List<Libro>();
            Estudiante estudiante = new Estudiante();
            string accion = "";
            bool repeat = true;

            estudiante = estudiante.createEstudent();
            libros = estudiante.createBooksList();

            do
            {

                Console.WriteLine("¿Qué desea hacer? Seleccione acción.");
                Console.WriteLine("1- Agregar libro a la lista\n2- Quitar libro de la lista\n3- Mostrar lista de libros\n4- Leer libro" +
                    "\n5- Mostrar libros leídos\n6- Mostrar libros no leídos\n7- Mostrar cantidad de páginas leídas\n8- Salir");

                accion = Console.ReadLine();

                switch (accion)
                {
                    case "1":
                        libros = estudiante.addBook(libros);
                        break;
                    case "2":
                        libros = estudiante.deleteBook(libros);
                        break;
                    case "3":
                        estudiante.showBooksList(libros);
                        break;
                    case "4":
                        libros = estudiante.readBook(libros);
                        break;
                    case "5":
                        estudiante.showReadBooks(libros);
                        break;
                    case "6":
                        estudiante.showUnreadBooks(libros);
                        break;
                    case "7":
                        estudiante.showTotalPagesRead(libros);
                        break;
                    case "8":
                        Console.WriteLine("Programa finalizado");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Debe elegir una opción dentro del rango 1 - 8");
                        break;
                }
            } while (repeat);


        }

    }
}