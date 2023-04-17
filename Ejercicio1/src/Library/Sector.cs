using System;
using System.Collections.Generic;

namespace SRP;

public class SECTOR
{
    private string _sector{get;set;}

    public List<Shelve> Estanterias=new List<Shelve>();

    public SECTOR(string sectordelalibreria)
    {
        this._sector=sectordelalibreria;
    }

    public void añadirestanterias(Shelve estanteriaagregar)
    {
        Estanterias.Add(estanteriaagregar);
    }

    public void obtenerestanterias()
    {
        Console.WriteLine($"Las id de estanterias que hay son");
        foreach(Shelve item in Estanterias)
        {
            Console.WriteLine(item.Id);
        }
    }

}