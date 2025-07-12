using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal class Factura
    {
        Persona cliente;
        DateTime fechaHora = new DateTime();
        List<Items> ItemsList = new List<Items>();
        public double Iva { get; set; } = 0.21;
        public double precioTotal { get; set; }
        public int CantidadItems { get; set; }
        public static int NroFactura = 0;

        public Factura(Persona clientee)
        {
            cliente = clientee;
            NroFactura++;
            fechaHora = DateTime.Now;
        }
        public void AgregarItems(Items unItems)
        {
            if (unItems != null) ItemsList.Add(unItems);
        }
        public double PrecioSinIva()
        {
            foreach (var item in ItemsList)
            {
                precioTotal += item.Precio();
            }
            return precioTotal;
        }
        public double PrecioTotal()
        {
            foreach (Items i in ItemsList)
            {
                precioTotal += i.Precio();
            }
            return precioTotal * Iva;
        }

        public Items MostrarItems(int indice)
        {
            if (indice > 0) 
            {
                return ItemsList[indice - 1];
            }
            return null;
        }

        public Persona GetCliente()
        {
            return cliente;
        }

        public DateTime GetFecha()
        {
            return fechaHora;
        }

        public override string ToString()
        {
            return NroFactura+" "+fechaHora +" "+cliente.ToString();
        }
    }
}
