using System;
using System.Collections.Generic;
using System.Text;

namespace UF10_EX6
{
    public class Libro : ILibro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }

        public Libro(string iSBN, string titulo, string autor, int numPaginas)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            NumPaginas = numPaginas;
        }

        public override string ToString()
        {
            return @$"El libro {Titulo} con ISBN {ISBN} creado por el autor {Autor} tiene {NumPaginas} páginas.";
        }

    }
}
