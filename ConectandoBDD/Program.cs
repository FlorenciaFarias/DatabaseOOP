using System;
using System.Collections.Generic;

namespace ConectandoBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            IProvinciaDatabase database = new ProvinciaFakeDatabase();


            Provincia nuevaProvincia = new Provincia(null, "Corrientes", 155000);
            Provincia provincia = database.Insert(nuevaProvincia);
            Console.WriteLine("Se creó la provincia " + provincia.ToString());
            //Mostrar por pantalla todas las provincias

            List<Provincia> provincias = database.RetrieveAll();

            foreach(Provincia provinciaActual in provincias)
            {
                Console.WriteLine(provinciaActual.ToString());
            }

        }
    }
}
