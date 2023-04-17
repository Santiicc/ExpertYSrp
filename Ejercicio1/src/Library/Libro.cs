using System;

namespace SRP
{
    public class Book
    {
        public string _Title{get;set;}
        private string _Author{get;set;}
        private string _Code{get;set;}
        
        public Book(String title, String author, String code)
        {
            this._Title = title;
            this._Author = author;
            this._Code = code;
        }

        public void Devolverlibro()
        {
            Console.WriteLine($"El nombre del libro es {_Title}, el autor es {_Author}, el Codigo es {_Code}" );
        }
        


    }
}
