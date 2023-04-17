using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            book1.Devolverlibro();
            Shelve estanteria1=new Shelve(150,3000);
            SECTOR sectorx=new SECTOR("A");
            estanteria1.AgregarLibros(book1);
            estanteria1.AgregarLibros(book2);
            estanteria1.MostrarLibros();
            sectorx.añadirestanterias(estanteria1);
            sectorx.obtenerestanterias();

        }
    }
}