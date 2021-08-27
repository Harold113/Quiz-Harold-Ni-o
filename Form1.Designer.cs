
namespace Home
{
    partial class Fmcompra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Listado = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btcarga = new System.Windows.Forms.Button();
            this.Btreport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AccessibleDescription = "";
            this.Listado.AccessibleName = "";
            this.Listado.FormattingEnabled = true;
            this.Listado.ItemHeight = 15;
            this.Listado.Location = new System.Drawing.Point(427, 28);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(351, 349);
            this.Listado.TabIndex = 1;
            this.Listado.Tag = "";
            this.Listado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 338);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btcarga
            // 
            this.btcarga.Location = new System.Drawing.Point(61, 338);
            this.btcarga.Name = "btcarga";
            this.btcarga.Size = new System.Drawing.Size(75, 23);
            this.btcarga.TabIndex = 5;
            this.btcarga.Text = "Cargar ";
            this.btcarga.UseVisualStyleBackColor = true;
            this.btcarga.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btreport
            // 
            this.Btreport.Location = new System.Drawing.Point(182, 338);
            this.Btreport.Name = "Btreport";
            this.Btreport.Size = new System.Drawing.Size(75, 23);
            this.Btreport.TabIndex = 6;
            this.Btreport.Text = "Reporte ";
            this.Btreport.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 8;
            // 
            // LbTexto
            // 
            this.LbTexto.AutoSize = true;
            this.LbTexto.Location = new System.Drawing.Point(61, 121);
            this.LbTexto.Name = "LbTexto";
            this.LbTexto.Size = new System.Drawing.Size(243, 15);
            this.LbTexto.TabIndex = 9;
            this.LbTexto.Text = "Escriba los productos para generar un listado";
            // 
            // Fmcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbTexto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btreport);
            this.Controls.Add(this.btcarga);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Listado);
            this.Name = "Fmcompra";
            this.Text = "Lista de Compras ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Listado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btcarga;
        private System.Windows.Forms.Button Btreport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbTexto;
    }
}

