using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal class Persona
    {
        string nombre;
        long cuit;

        public Persona(string nombre, long cuit)
        {
            this.nombre = nombre;
            this.cuit = cuit;
        }
        public override string ToString()
        {
            return nombre+" "+cuit;
        }

        public long GetCuit()
        {
            return cuit;
        }
    }
}
