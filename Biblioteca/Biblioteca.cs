using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca: Universidad
    {
        private string nombre;
        private List<Usuario> usuarios;
        private List<Libro> libros;

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<Libro> Libros { get => libros; set => libros = value; }

        public Biblioteca(string ident, string nombr)
        {
            nombre = nombr;
            this.Identificacion = ident;
            usuarios = new List<Usuario>();
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void BorrarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void BorrarUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
        }
    }
}
