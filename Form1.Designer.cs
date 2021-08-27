
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
            this.Ltlis = new System.Windows.Forms.ListBox();
            this.Btreport = new System.Windows.Forms.Button();
            this.TBlista = new System.Windows.Forms.TextBox();
            this.LbTexto = new System.Windows.Forms.Label();
            this.BtIngresar = new System.Windows.Forms.Button();
            this.lblfrutas = new System.Windows.Forms.Label();
            this.bteliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ltlis
            // 
            this.Ltlis.AccessibleDescription = "";
            this.Ltlis.AccessibleName = "";
            this.Ltlis.FormattingEnabled = true;
            this.Ltlis.ItemHeight = 15;
            this.Ltlis.Items.AddRange(new object[] {
            "Manzana",
            "fresa ",
            "Granada ",
            "Kiwi"});
            this.Ltlis.Location = new System.Drawing.Point(408, 118);
            this.Ltlis.MultiColumn = true;
            this.Ltlis.Name = "Ltlis";
            this.Ltlis.Size = new System.Drawing.Size(351, 259);
            this.Ltlis.TabIndex = 1;
            this.Ltlis.Tag = "";
            this.Ltlis.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Btreport
            // 
            this.Btreport.Location = new System.Drawing.Point(155, 354);
            this.Btreport.Name = "Btreport";
            this.Btreport.Size = new System.Drawing.Size(75, 23);
            this.Btreport.TabIndex = 6;
            this.Btreport.Text = "Reporte ";
            this.Btreport.UseVisualStyleBackColor = true;
            this.Btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // TBlista
            // 
            this.TBlista.Location = new System.Drawing.Point(61, 153);
            this.TBlista.Multiline = true;
            this.TBlista.Name = "TBlista";
            this.TBlista.Size = new System.Drawing.Size(265, 23);
            this.TBlista.TabIndex = 8;
            this.TBlista.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LbTexto
            // 
            this.LbTexto.AutoSize = true;
            this.LbTexto.Location = new System.Drawing.Point(61, 121);
            this.LbTexto.Name = "LbTexto";
            this.LbTexto.Size = new System.Drawing.Size(221, 15);
            this.LbTexto.TabIndex = 9;
            this.LbTexto.Text = "Escriba los productos que desee agregar ";
            this.LbTexto.Click += new System.EventHandler(this.LbTexto_Click);
            // 
            // BtIngresar
            // 
            this.BtIngresar.Location = new System.Drawing.Point(61, 294);
            this.BtIngresar.Name = "BtIngresar";
            this.BtIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtIngresar.TabIndex = 10;
            this.BtIngresar.Text = "ingresar";
            this.BtIngresar.UseVisualStyleBackColor = true;
            this.BtIngresar.Click += new System.EventHandler(this.BtIngresar_Click);
            // 
            // lblfrutas
            // 
            this.lblfrutas.AutoSize = true;
            this.lblfrutas.Location = new System.Drawing.Point(408, 61);
            this.lblfrutas.Name = "lblfrutas";
            this.lblfrutas.Size = new System.Drawing.Size(191, 45);
            this.lblfrutas.TabIndex = 11;
            this.lblfrutas.Text = "\r\n\r\nSelecione alguno de los productos ";
            this.lblfrutas.Click += new System.EventHandler(this.lblfrutas_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(251, 294);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 12;
            this.bteliminar.Text = "eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // Fmcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.lblfrutas);
            this.Controls.Add(this.BtIngresar);
            this.Controls.Add(this.LbTexto);
            this.Controls.Add(this.TBlista);
            this.Controls.Add(this.Btreport);
            this.Controls.Add(this.Ltlis);
            this.Name = "Fmcompra";
            this.Text = "Lista de Compras ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Ltlis;
        private System.Windows.Forms.Button Btreport;
        private System.Windows.Forms.TextBox TBlista;
        private System.Windows.Forms.Label LbTexto;
        private System.Windows.Forms.Button BtIngresar;
        private System.Windows.Forms.Label lblfrutas;
        private System.Windows.Forms.Button bteliminar;
    }
}

