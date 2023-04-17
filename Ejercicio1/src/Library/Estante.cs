using System;
using System.Collections.Generic;

namespace SRP;

public class Shelve
{
    
    private int capacidad{get;set;}
    public int Id{get;set;}
    public List<Book> Libros1=new List<Book>();

    public Shelve(int capacidad,int idestante)
        {
            this.capacidad=capacidad;
            this.Id=idestante;
        }

    public void obtenerestanteria()
        {
            Console.WriteLine($"La id de la estanteria es {Id} y la capacidad es {capacidad}");
        }

    public void AgregarLibros(Book libroagregado)
        {
            Libros1.Add(libroagregado);
        }

    public void MostrarLibros()
    {
        Console.WriteLine("Los libros que hay son");
        foreach (Book item in Libros1)
        {
            Console.WriteLine(item._Title);
        }
    }


}