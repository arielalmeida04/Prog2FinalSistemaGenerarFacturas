namespace Prog2FinalSistemaGenerarFacturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttGenerarFactura = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb2Clientes = new System.Windows.Forms.ComboBox();
            this.bttImportar = new System.Windows.Forms.Button();
            this.bttExportarClientes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttGenerarFactura
            // 
            this.bttGenerarFactura.Location = new System.Drawing.Point(273, 35);
            this.bttGenerarFactura.Name = "bttGenerarFactura";
            this.bttGenerarFactura.Size = new System.Drawing.Size(75, 44);
            this.bttGenerarFactura.TabIndex = 0;
            this.bttGenerarFactura.Text = "Generar Factura";
            this.bttGenerarFactura.UseVisualStyleBackColor = true;
            this.bttGenerarFactura.Click += new System.EventHandler(this.bttGenerarFactura_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(43, 35);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(175, 21);
            this.cb1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exportar Facturas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb2Clientes
            // 
            this.cb2Clientes.FormattingEnabled = true;
            this.cb2Clientes.Location = new System.Drawing.Point(43, 71);
            this.cb2Clientes.Name = "cb2Clientes";
            this.cb2Clientes.Size = new System.Drawing.Size(175, 21);
            this.cb2Clientes.TabIndex = 3;
            // 
            // bttImportar
            // 
            this.bttImportar.Location = new System.Drawing.Point(273, 152);
            this.bttImportar.Name = "bttImportar";
            this.bttImportar.Size = new System.Drawing.Size(135, 23);
            this.bttImportar.TabIndex = 4;
            this.bttImportar.Text = "Importar Productos";
            this.bttImportar.UseVisualStyleBackColor = true;
            this.bttImportar.Click += new System.EventHandler(this.bttImportar_Click);
            // 
            // bttExportarClientes
            // 
            this.bttExportarClientes.Location = new System.Drawing.Point(273, 123);
            this.bttExportarClientes.Name = "bttExportarClientes";
            this.bttExportarClientes.Size = new System.Drawing.Size(135, 23);
            this.bttExportarClientes.TabIndex = 5;
            this.bttExportarClientes.Text = "Exportar Clientes";
            this.bttExportarClientes.UseVisualStyleBackColor = true;
            this.bttExportarClientes.Click += new System.EventHandler(this.bttExportarClientes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 147);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttExportarClientes);
            this.Controls.Add(this.bttImportar);
            this.Controls.Add(this.cb2Clientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.bttGenerarFactura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttGenerarFactura;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb2Clientes;
        private System.Windows.Forms.Button bttImportar;
        private System.Windows.Forms.Button bttExportarClientes;
        private System.Windows.Forms.ListBox listBox1;
    }
}

