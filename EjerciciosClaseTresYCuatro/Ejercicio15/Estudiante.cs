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
    internal class Estudiante : Persona
    {
        public List<Libro> libros { get; set; }
        public Estudiante() { }

        public Estudiante createEstudent()
        {
            Estudiante estudiante = new Estudiante();

            Console.WriteLine("Registro de estudiante.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ingresar nombre");
            estudiante._name = Console.ReadLine();

            Console.WriteLine("Ingresar apellido");
            estudiante._lastname = Console.ReadLine();

            return estudiante;
        }

        public List<Libro> createBooksList()
        {

            List<Libro> libros = new List<Libro>();
            Libro libro = new Libro();
            string res = "";

            libros.Add(libro.createLibro());

            do
            {
                Console.WriteLine("¿Añadir otro libro? s/n");
                res = Console.ReadLine().ToLower();

                if (res != "s" && res != "n")
                {
                    Console.WriteLine("Ingrese una opción correcta");
                }

                if (res == "s")
                {
                    libros.Add(libro.createLibro());
                    Console.WriteLine("----------------------");
                }
                else if (res == "n")
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Lista de libros creada");
                    Console.WriteLine("----------------------");
                }

            } while ((res != "s" && res != "n") || res == "s");


            return libros;
        }
        public List<Libro> addBook(List<Libro> libros)
        {
            Libro libro = new Libro();

            libro = libro.createLibro();
            libros.Add(libro);

            return libros;
        }

        public List<Libro> deleteBook(List<Libro> libros)
        {
            string title = "";
            bool exists = false;

            Console.WriteLine("Borrar libro");

            title = Console.ReadLine().ToUpper();

            foreach (var item in libros)
            {
                if (item.name.Equals(title))
                {
                    exists = true;
                    libros.Remove(item);
                    Console.WriteLine("-------------------\nLibro eliminado\n-------------------");
                    break;
                }
            }
            if (!exists)
            {
                Console.WriteLine("No se encontró el libro");
            }
            return libros;
        }

        public void showBooksList(List<Libro> libros)
        {
            Console.WriteLine("Lista completa de libros: ");
            foreach (var item in libros)
            {
                if (item.name!=null)
                {
                    Console.WriteLine(item.ToString(item));
                    Console.WriteLine("-------------------------");
                }
            }
        }



        public void showReadBooks(List<Libro> libros)
        {
            Console.WriteLine("Libros leidos:");
            foreach (var item in libros)
            {
                if (item.wasRead && item.name!=null)
                {
                    Console.WriteLine(item.ToString(item));
                    Console.WriteLine("-------------------------");
                }
            }
        }

        public void showUnreadBooks(List<Libro> libros)
        {
            Console.WriteLine("Libros no leidos:");

            foreach (var item in libros)
            {
                if (!item.wasRead && item.name!=null)
                {
                    Console.WriteLine("- " + item.ToString(item));
                    Console.WriteLine("-------------------------");
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
                    Console.WriteLine("Libro: " + aux.name + "\nCantidad de páginas: " + aux.pages);
                    totalPages += aux.pages;
                }
            }
            Console.WriteLine("Cantidad total de páginas leídas: " + totalPages);
        }

        public List<Libro> readBook(List<Libro> libros)
        {
            string title = "";
            bool exists = false;

            Console.WriteLine("leer libro");
            title = Console.ReadLine().ToUpper();

            foreach (var item in libros)
            {
                if (item.name.Equals(title))
                {
                    item.wasRead = true;
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                Console.WriteLine("No se encontró el libro");
            }
            return libros;
        }
    }
}
