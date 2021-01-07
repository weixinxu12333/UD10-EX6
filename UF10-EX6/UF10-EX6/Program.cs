using System;

namespace UF10_EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("9878978987987", "Star Wars 1", "Alguien", 300);
            Libro libro2 = new Libro("456545654556", "The Ring", "Alguien", 450);

            Console.WriteLine(libro);
            Console.WriteLine(libro2);

            if (libro.NumPaginas > libro2.NumPaginas)
                Console.WriteLine("Libro 1 tiene más pàginas: " + libro.NumPaginas);
            else
                Console.WriteLine("Libro 2 tiene más pàginas: " + libro2.NumPaginas);

        }
    }
}
