using System;
using System.Collections.Generic;
using System.Text;

namespace UF10_EX6
{
    public interface ILibro
    {
        string ISBN { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
        int NumPaginas { get; set; }

        string ToString();
    }
}
