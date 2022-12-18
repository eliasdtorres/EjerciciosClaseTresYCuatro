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

        public int silence( int _vol)
        {
            return this._vol =0;
        }

        public int screenBrightness(int display, bool up)
        {
            
        }

    }


}
