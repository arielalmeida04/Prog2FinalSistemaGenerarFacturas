using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal class ProdUnitario:Items
    {
        string nombre;
        string unidadDeMedida;
        public double Cantidad { get; set; }
        public double PrecioUnidad { get; set; }


        public ProdUnitario(int codigo,string nombre, string unidadDeMedida,double precioUnidad,int cantidad):base(codigo)
        {
            PrecioUnidad=precioUnidad;
            this.nombre = nombre;
            this.unidadDeMedida = unidadDeMedida;
        }

        

        public override string Descripcion()
        {
            return Codigo + " " + nombre + " " + unidadDeMedida + " " + PrecioUnidad + " " + Cantidad;
        }

        public override double Precio()
        {
            return PrecioUnidad * Cantidad + (PrecioUnidad * 0.007);
        }

        
    }
}
