using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8. Crear una clase Smartphone con los siguientes métodos:
//a.para encender y apagar el mismo
//b. subir y bajar el volumen,
//c. poner en silencio,
//d. bajar o subir el brillo de la pantalla.
//e. Además de properties para marca y modelo.

namespace EjerciciosClaseTresYCuatro.Ejercicio8
{
    internal class Smartphone
    {
        public string _brand { get; set; }
        public string _model { get; set; }

        public int _vol { get; set; }
        public int display { get; set; }
        public bool isOn { get; set; }


        public Smartphone() { }


        public Smartphone createSmartphone(Smartphone smart)
        {
            Console.WriteLine("Registro de Smartphone");
            Console.WriteLine("Ingrese marca.");
            smart._brand = Console.ReadLine();

            Console.WriteLine("Ingrese modelo.");
            smart._model = Console.ReadLine();

            Console.WriteLine("Marca: " + smart._brand + "\nModelo: " + smart._model);
            smart.display = 50;
            smart.isOn = false;
            smart._vol = 50;
            return smart;
        }

        public Smartphone turnOn(Smartphone smart)
        {
            string res = "";
            if (smart.isOn)
            {

                Console.WriteLine("El smartphone ya se encuentra encendido");
            }
            else
            {
                Console.WriteLine("Se encendió el smartphone");
                smart.isOn = true;
            }

            return smart;
        }

        public Smartphone turnOff(Smartphone smart)
        {
            string res = "";
            if (!smart.isOn)
            {
                Console.WriteLine("El smartphone ya se encuentra apagado");
            }
            else
            {
                Console.WriteLine("Se apagó el smartphone");
                smart.isOn = false;
            }

            return smart;
        }



      

        public Smartphone volUp(Smartphone smart)
        {

            if (smart._vol == 0)
            {
                Console.WriteLine("Se desactivó el silencio");
                smart._vol += 10;

                return smart;

            }
            else if (smart._vol < 100)
            {
                smart._vol += 10;

                if (smart._vol > 100)
                {
                   smart._vol = 100;
                }

                Console.WriteLine("Nivel de volúmen: "+ smart._vol);
                return smart;
            }
            else
            {
                Console.WriteLine("El volúmen ya se encuentra al máximo");
                return smart;
            }





        }


        public Smartphone volDown(Smartphone smart)
        {
            if (smart._vol <= 100 && smart._vol > 0)
            {
                smart._vol -= 10;

                if (smart._vol <= 0)
                {
                    smart._vol = 0;
                    Console.WriteLine("El smarphone se silenció.");
                }
                Console.WriteLine("Nivel de volúmen: " + smart._vol);
                return smart;
            }
            else
            {
                Console.WriteLine("El volúmen ya se encuentra al mínimo");
                return smart;
            }

        }

        public Smartphone mute(Smartphone smart)
        {

            if (smart._vol > 0)
            {

                Console.WriteLine("Se silenció");
                smart._vol = 0;
                return smart;
            }
            else
            {
                Console.WriteLine("El smartphone ya se encuentra silenciado.");
                return smart;
            }
        }

        public Smartphone unMute(Smartphone smart)
        {

            if (_vol == 0)
            {

                Console.WriteLine("Se quitó el silecio");
                smart._vol = 10;
                return smart;
            }
            else
            {
                Console.WriteLine("El smartphone ya se encuentra con el silecion desactivado.");
                return smart;
            }
        }

        public Smartphone brightUp(Smartphone smart)
        {
            if (smart.display < 100 || smart.display >= 1)
            {
                Console.WriteLine("Se subió el brillo.");
                smart.display += 10;
                if (smart.display >= 100)
                {
                    Console.WriteLine("El brillo se encuentra al máximo");

                }
                Console.WriteLine("Nivel de brillo: " +     smart.display);
                return smart;

            }
            else
            {
                Console.WriteLine("El brillo ya está al máximo");
                return smart;
            }

        }


        public Smartphone brightDown(Smartphone smart)
        {

            if (smart.display <= 1)
            {
                Console.WriteLine("El brillo se encuentra al mínimo.");

                return smart;
            }
            else
            {
                Console.WriteLine("Se bajó el brillo.");
                smart.display -= 10;
                if (smart.display <= 1)
                {
                    Console.WriteLine("El brillo ya se encuentra al mínimo");
                    smart.display = 1;
                }
                Console.WriteLine("Nivel de brillo: " + smart.display);
                return smart;
            }

        }



    }


}
