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
            FileStream fl = new FileStream("ListaCliente.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
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
            FileStream fl = new FileStream("ListaCliente.txt", FileMode.Create, FileAccess.Write);
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
            FileStream fs = new FileStream("listaFacturas.txt", FileMode.Create, FileAccess.Write);
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
            FileStream fl = new FileStream("listaItems.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fl);
            try
            {
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] campos = linea.Split(';');

                    int codigo = int.Parse(campos[0]);
                    string nombre = campos[1];
                    string unidadDemedida = campos[2];
                    double preciounidad = double.Parse(campos[3]);
                    int cantidad = int.Parse(campos[4]);

                    Items p = new ProdUnitario(codigo, nombre, unidadDemedida, preciounidad, cantidad);
                    f.AgregarItems(p);

                    empresa.AgregarFactura(f);
                    listBox1.Items.Add(p.Descripcion());  

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttExportarClientes_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("listaClientes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                Queue<Persona> clientes = empresa.ObtenerLista();

                foreach (Persona item in clientes)
                {
                    sw.WriteLine(item.Cuit + ';' + item.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

        }
    }
}
