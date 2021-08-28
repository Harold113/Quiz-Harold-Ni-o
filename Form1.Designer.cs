
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
            this.components = new System.ComponentModel.Container();
            this.Ltlis = new System.Windows.Forms.ListBox();
            this.Btreport = new System.Windows.Forms.Button();
            this.TBlista = new System.Windows.Forms.TextBox();
            this.LbTexto = new System.Windows.Forms.Label();
            this.BtIngresar = new System.Windows.Forms.Button();
            this.lblfrutas = new System.Windows.Forms.Label();
            this.bteliminar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlabrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlabrir,
            this.tlsalvar});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // tlabrir
            // 
            this.tlabrir.Name = "tlabrir";
            this.tlabrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tlabrir.Size = new System.Drawing.Size(180, 22);
            this.tlabrir.Text = "Abrir ";
            this.tlabrir.ToolTipText = "Use para buscar un archivo";
            this.tlabrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            this.tlabrir.MouseEnter += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // tlsalvar
            // 
            this.tlsalvar.Name = "tlsalvar";
            this.tlsalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tlsalvar.Size = new System.Drawing.Size(180, 22);
            this.tlsalvar.Text = "Salvar ";
            this.tlsalvar.Click += new System.EventHandler(this.tlsalvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fmcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlabrir;
        private System.Windows.Forms.ToolStripMenuItem tlsalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

