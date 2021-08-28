using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Fmcompra : Form
    {

        public Fmcompra()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ltlis.Items.Add("durazno");
            Ltlis.Items.Add("pera");
        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2(TBlista.Text);

            forma2.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(Ltlis.SelectedIndex != -1)
               lblfrutas.Text = (String)Ltlis.Items[Ltlis.SelectedIndex];
        }

        private void LbTexto_Click(object sender, EventArgs e)
        {

        }

        private void BtIngresar_Click(object sender, EventArgs e)
        {
            Ltlis.Items.Add(TBlista.Text);

            TBlista.Text = "";
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            int indice= Ltlis.SelectedIndex;

            if (indice != -1)
            {
                Ltlis.Items.RemoveAt(indice);
            }
        }

        private void lblfrutas_Click(object sender, EventArgs e)
        {
            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                tlabrir.Text = openFileDialog1.FileName;
            }
        }

        private void tlsalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                tlsalvar.Text = saveFileDialog1.FileName;
            }
        }
    }
}
