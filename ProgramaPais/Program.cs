using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais = new Pais
            {
                Nombre="Albania",
                PaisId=1
            };
            pais.Nombre = "Ecuador";
            pais.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Guayas";
            var provincia2 = new Provincia();
            provincia2.Nombre = "Manabi";
            pais.Provincias = new List<Provincia>()
            {
                provincia1,
                provincia2
            };
            var canton1 = new Canton();
            canton1.Nombre = "Quito";
            var canton2 = new Canton();
            canton2.Nombre = "Chone";
            provincia2.Cantones = new List<Canton>();
            provincia1.Cantones.Add(canton1);
            provincia2.Cantones.Add(canton2);
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "Nayon";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Zambisa";
            parroquia1.Habitantes = 1000;
            parroquia2.Habitantes = 2000;
            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton2.Parroquias.Add(parroquia2);
            Console.WriteLine($" Numero de Habitantes totales: {pais.ObtenerNumeroDeHabitantes()}");
        }
    }
}
