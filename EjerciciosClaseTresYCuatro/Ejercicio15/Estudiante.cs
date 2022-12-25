using EjerciciosClaseTresYCuatro.Ejercicio10;
using EjerciciosClaseTresYCuatro.Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class Estudiante : PersonaIII
    {
        public List<Libro>libros { get; set; }


        public List<Libro> addBook(List<Libro>libros)
        {
            Libro book = new Libro();
            libros.Add(book);
            return libros;
        }

        public List<Libro> deleteBook(List<Libro> libros)
        {

            return libros;
        }



        public void showReadBooks(List<Libro> libros)
        { 
            Console.WriteLine("Libros leidos:");
            foreach (var aux in libros)
            {
                if (aux.wasRead)
                {
                    Console.WriteLine("- " + aux.ToString);
                }
            }
        }

        public void showUnreadBooks(List<Libro> libros)
        {
            Console.WriteLine("Libros no leidos:");
            foreach (var aux in libros)
            {
                if (!aux.wasRead)
                {
                    Console.WriteLine("- " + aux.ToString);
                }
            }

        }

        public void showTotalPagesRead(List<Libro> libros)
        {
            int totalPages = 0;
            foreach (var aux in libros)
            {
                if (aux.wasRead)
                {
                    Console.WriteLine("Libro: " + aux.name + "\nCantidad de páginas: "+ aux.pages);
                    totalPages += aux.pages;
                }
            }
            Console.WriteLine("Cantidad total de páginas leídas: " + totalPages);
        }

        





    }
}
