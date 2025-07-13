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

        public string Nombre { get => nombre; set => nombre = value; }
        public long Cuit { get => cuit; set => cuit = value; }

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
