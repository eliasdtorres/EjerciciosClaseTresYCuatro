using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//15.Crear una clase Libro, que contenga Nombre, Autor, Cantidad de Páginas, y
//una property llamada WasRead, que diga si el libro fue leído o no (boolean).
//Crear una clase Estudiante, que hereda de Persona (la clase de los puntos
//anteriores). El estudiante debe contener una lista de Libros, los cuales puede
//ser que los haya leído o no. (Se pueden crear dos listas diferentes si se
//complica mucho. Una lista con todos los libros, leídos o no, y otra lista sólo
//con los libros leídos) Debe haber un método que muestre la lista de libros
//leídos, y además otro método que permita calcular la suma de la cantidad de
//páginas leídas totales, de todos los libros leídos. Y un método que permita
//saber cuántos libros quedan sin leer. Otro método que permite agregar o
//quitar libros de la lista de libros (dos métodos diferentes).

namespace EjerciciosClaseTresYCuatro.Ejercicio15
{
    internal class Libro
    {
        public string name;
        public string author;
        public int pages;
        public bool wasRead { get; set; }

        public Libro() { } 

        public Libro createLibro() {

            bool isOk = true;
            Libro libro = new Libro();

            Console.WriteLine("Registro.");
            Console.WriteLine("Nombre del libro.");
            libro.name = Console.ReadLine();

            Console.WriteLine("Autor del libro.");
            libro.author = Console.ReadLine();

            do
            {
                try
                {
                    isOk = true;
                    Console.WriteLine("Cantidad de páginas.");
                    libro.pages = Console.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un valor numérico.");
                    isOk = false;
                }
            } while (!isOk);
            
            
            return libro;
        }
    }













}
