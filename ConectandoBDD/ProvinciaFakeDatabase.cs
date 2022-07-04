using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoBDD
{
    class ProvinciaFakeDatabase : IProvinciaDatabase
    {
        private List<Provincia> provincias;

        public  ProvinciaFakeDatabase()
        {
          this.provincias = new List<Provincia>();
        }
        public Provincia Insert(Provincia provincia)
        {
            this.provincias.Add(provincia);
            return provincia;
        }

        public List<Provincia> RetrieveAll()
        {
            return this.provincias;
        }
    }
}
