using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal class Servicio : Items
    {
        string detalle;
        double PrecioHora;

        public Servicio(int codigo,string detalle, double precioHora, int tiempo) :base(codigo)
        {
            this.detalle = detalle;
            PrecioHora = precioHora;
            Tiempo = tiempo;
        }

        public int Tiempo { get; set;}
       


        public override string Descripcion()
        {
            return Codigo + " " + detalle + " " + Tiempo;
        }

        public override double Precio()
        {
            return PrecioHora * Tiempo;
        }
    }
}
