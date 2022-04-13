using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        private string identificacion;
        private string nombre;
        private List<Libro> librosAsignados;

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Libro> LibrosAsignados { get => librosAsignados; set => librosAsignados = value; }

        public Usuario(string ident, string nomb)
        {
            identificacion = ident;
            nombre = nomb;
            librosAsignados = new List<Libro>();
        }

        public void AsignarLibro(Libro libro)
        {
            librosAsignados.Add(libro);
        }

        public void DevolverLibro(Libro libro)
        {
            librosAsignados.Remove(libro);
        }
    }
}
