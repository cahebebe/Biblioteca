/*
 * En la universidad requieren que se desarrolle un software para la biblioteca en su sede de Bogota 
 * la cual  permita administrar la entrega de libros a sus usuarios, para lo cual debe permitir la 
 * entrega, devolución y conocer qué libros tiene determinado cliente.
 * 
 * Autor: Carlos Bermúdez
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("800123456-5", "Jose Celestino Mutis");
            Menu menu = new Menu();
            int valor = 0;
            string nomb, ident = "";

            do
            {
                valor = menu.MenuPrincipal();
                switch (valor)
                {
                    case 1:
                        Console.Write("Agregar: Ingrese Identificación: ");
                        ident = Console.ReadLine();
                        Console.Write("Ingrese Nombre: ");
                        nomb = Console.ReadLine();
                        biblioteca.AgregarUsuario(new Usuario(ident, nomb));
                        Console.WriteLine("Usuario agregado con éxito!");
                        break;
                    case 2:
                        Console.WriteLine("Lista de Usuarios");
                        foreach (Usuario usuario in biblioteca.ListarUsuarios())
                        {
                            Console.WriteLine("Usuario: " + usuario.Nombre);
                        }
                        break;
                    case 3:
                        Console.Write("Borrar: Ingrese ID de Usuario: ");
                        biblioteca.BorrarUsuario(biblioteca.Usuarios[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Usuario eliminado con éxito!");
                        break;
                    case 4:
                        Console.Write("Ver Usuario: Ingrese el ID de Usuario: ");
                        valor = int.Parse(Console.ReadLine());
                        biblioteca.Usuarios[valor] = menu.MenuUsuario(biblioteca.Usuarios[valor], biblioteca.Libros);
                        break;
                    case 5:
                        Console.Write("Agregar Libro - Id del libro: ");
                        ident = Console.ReadLine();
                        Console.Write("Nombre del Libro: ");
                        nomb = Console.ReadLine();
                        biblioteca.AgregarLibro(new Libro(int.Parse(ident), nomb));
                        Console.WriteLine("Libro agregado con exito");
                        break;
                    case 6:
                        Console.WriteLine("Lista de Libros en la Biblioteca");
                        foreach (Libro libro in biblioteca.Libros)
                        {
                            Console.WriteLine("Libro: " + libro.Nombre);
                        }
                        break;
                    case 7:
                        Console.Write("Borrar Libro: Ingrese ID de Libro: ");
                        biblioteca.BorrarLibro(biblioteca.Libros[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Libro eliminado con exito");
                        break;
                }
            } while (valor != 8);
        }
    }
}
