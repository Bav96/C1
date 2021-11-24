using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBiblioteca
{
    public class Libro
    {
        // Atributos.
        private string Titulo;
        private string Autor;
        private string Editorial;
        private string RutaImagen;
        private readonly bool EsNuevo;

        // Constructores.    
        public Libro(string titulo, string autor, string editorial, string rutaImagen, bool esNuevo)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            RutaImagen = rutaImagen;
            EsNuevo = esNuevo;
        }

        // Getters.
        public string GetTitulo()
        {
            return Titulo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public string GetEditorial()
        {
            return Editorial;
        }

        public string GetRutaImagen()
        {
            return RutaImagen;
        }

        public override string ToString()
        {
            return string.Format("Titulo: {0}\nAutor: {1}\nEditorial: {2}\nEsNuevo: {3}\nRutaImagen: {4}",
                                Titulo, Autor, Editorial, EsNuevo, RutaImagen);
        }
    }
}
