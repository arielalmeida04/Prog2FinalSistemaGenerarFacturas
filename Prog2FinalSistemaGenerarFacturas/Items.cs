using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal abstract class Items
    {
       public int Codigo{ get; set; }

        public Items(int codigo)
        {
            Codigo = codigo;
        }
        public abstract string Descripcion();
        public abstract double Precio();

    }
}
