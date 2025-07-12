namespace Prog2FinalSistemaGenerarFacturas
{
    partial class GenerarFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttAceptar
            // 
            this.bttAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttAceptar.Location = new System.Drawing.Point(55, 159);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 49);
            this.bttAceptar.TabIndex = 0;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttCancelar.Location = new System.Drawing.Point(177, 159);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 49);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuit";
            // 
            // GenerarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAceptar);
            this.Name = "GenerarFacturas";
            this.Text = "GenerarFacturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttCancelar;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}