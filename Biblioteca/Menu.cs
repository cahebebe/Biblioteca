//
// Autor: Carlos Bermúdez - 2022
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Menu
    {
        public int MenuPrincipal()
        {
            Console.WriteLine("Bibioteca Universidad");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Agregar usuario");
            Console.WriteLine("2. Listar Usuarios");
            Console.WriteLine("3. Borrar Usuario");
            Console.WriteLine("4. Ver Usuario");
            Console.WriteLine("5. Agregar Libro a la Biblioteca");
            Console.WriteLine("6. Listar Libros de la Biblioteca");
            Console.WriteLine("7. Borrar Libro");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");
            return int.Parse(Console.ReadLine());
        }

        public Usuario MenuUsuario(Usuario usuario, List<Libro> libros)
        {
            int valor = 0;

            do
            {
                Console.WriteLine("Usuario " + usuario.Nombre);
                Console.WriteLine("1. Prestar Libro");
                Console.WriteLine("2. Devolver Libro");
                Console.WriteLine("3. Ver libros prestados al usuario");
                Console.WriteLine("4. Regresar");

                valor = int.Parse(Console.ReadLine());

                switch(valor)
                {
                    case 1:
                        Console.Write("Prestar: Ingrese el ID de Libro a Prestar: ");
                        usuario.AsignarLibro(libros[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Libro asignado con exito");
                        break;
                    case 2:
                        Console.WriteLine("Devolver: Ingrese el ID del libro: ");
                        usuario.DevolverLibro(usuario.LibrosAsignados[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("Libro devuelto con exito");
                        break;
                    case 3:
                        Console.WriteLine("Lista de Libros prestados");
                        foreach(Libro libro in usuario.LibrosAsignados)
                        {
                            Console.WriteLine("Libro: " + libro.Nombre);
                        }
                        break;

                }
            } while (valor != 4);
            return usuario;
        }

    }
}
