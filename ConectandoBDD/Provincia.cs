using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoBDD
{
    public class Provincia
    {
        private int? id;
        private string nombre;
        private int poblacion;

        public Provincia(int? id, string nombre, int poblacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.poblacion = poblacion;
        }

        public override string ToString()
        {
            return this.nombre + "(# " + this.id + ") - " + this.poblacion + " habitantes";
        }
    }
}
