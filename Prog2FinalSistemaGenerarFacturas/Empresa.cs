using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalSistemaGenerarFacturas
{
    [Serializable]
    internal class Empresa
    {
        string nombre;
        long cuit;
        int facturacionTotal;
        Persona p;
        Queue<Persona> listCliente = new Queue<Persona>();
        Stack<Factura> listaFactura = new Stack<Factura>();

        public Empresa(string nombre, long cuit)
        {
            p = new Persona(nombre, cuit);
            


        }
        public Queue<Persona> ObtenerLista()
        {
            return listCliente;
        }

        public Stack<Factura> ObtenerFacturas()
        {
            return listaFactura;
        }
        public void AgregarFactura(Factura unFactura)
        {
            if(unFactura!=null) listaFactura.Push(unFactura);
        }
        
        public void AgregarCliente(Persona pers)
        {
            if(pers!=null)
            listCliente.Enqueue(pers);
        }
        public void QuitarCliente()
        {
            listCliente.Dequeue();
        }
        public void QuitarFactura()
        {
            listaFactura.Pop();
        }
    }
}
