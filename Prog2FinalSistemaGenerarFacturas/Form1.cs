using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalSistemaGenerarFacturas
{
    public partial class Form1 : Form
    {
        Items pu = new ProdUnitario(100, "Cable Bipolar", "Metro", 100, 200);
        Items sv = new Servicio(404, "Programador", 20, 8);
        Factura f;
     
        Empresa empresa = new Empresa("UTN", 505);
        Stack<Factura> facturas = new Stack<Factura>();
        public Form1()
        {
            InitializeComponent();

            cb1.Items.Add(pu.Descripcion());

            cb1.Items.Add(sv.Descripcion());
        }

        private void bttGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (empresa.ObtenerLista().Count == 0)
                {
                    GenerarFacturas gf = new GenerarFacturas();
                    if (gf.ShowDialog() == DialogResult.OK)
                    {
                        string nomnbre = gf.textBox1.Text;
                        long cuit = Convert.ToInt64(gf.textBox2.Text);
                        Persona p = new Persona(nomnbre, cuit);
                        cb2Clientes.Items.Add(p);
                        empresa.AgregarCliente(p);

                    }
                    gf.Dispose();
                }
                else
                {
                    Persona cliente = cb2Clientes.SelectedItem as Persona;
                    f = new Factura(cliente);
                    Items i = cb1.SelectedItem as Items;
                    f.AgregarItems(i);
                    empresa.AgregarFactura(f);
                }

                 
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fl = new FileStream("ListaCliente.bat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                facturas = bf.Deserialize(fl) as Stack<Factura>;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                if (fl != null) fl.Close(); // o fl.Dispose()
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fl = new FileStream("ListaCliente.bat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {

                bf.Serialize(fl, facturas);
            }
            catch (Exception s)
            {

                MessageBox.Show("Error: " + s.Message);
            }
            finally
            {
                if (fl != null)
                {
                    fl.Close();
                    fl.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("listaFacturas.bat", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                

                Stack<Factura> facturas = empresa.ObtenerFacturas();

                foreach (Factura factura in facturas)
                {
                    sw.WriteLine(Factura.NroFactura + ";" +
                        factura.GetCliente().GetCuit() + ";" +
                        factura.GetFecha().Date + ";" +
                        factura.GetFecha().TimeOfDay + ";" +
                        factura.precioTotal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bttImportar_Click(object sender, EventArgs e)
        {
            FileStream fl = new FileStream("ListaCliente.bat",FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            try
            {
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] campos = linea.Split(';');

                    int nroFactura= int.Parse(campos[0]);
                    long cuit = long.Parse(campos[1]);
                    DateTime fecha = DateTime.Parse(campos[2]);
                    DateTime fechehora = DateTime.Parse(campos[3]);
                    double total = double.Parse(campos[4]);
                    
                    //Tengo dudas con este apartado si lo hice bien, no entendi si es lo que buscaban a la hora de importar o exportar.
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
