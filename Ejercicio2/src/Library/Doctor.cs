using System;

namespace Library

{
class Doctor

{
    private string nombredeldoctor{get;set;}

    private string lugardeatencion{get;set;}

    private string especializacion{get;set;}

    public Doctor(string name1,string esoecialidad,string lugar)
    {
        this.nombredeldoctor=name1;
        this.especializacion=esoecialidad;
        this.lugardeatencion=lugar;
    }
    
    public void devolverdatos()
    {
        Console.WriteLine($"El nombre del doctor es{nombredeldoctor} la especializacion es ")
    }
}

}