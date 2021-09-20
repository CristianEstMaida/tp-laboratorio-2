using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            
            Operando c1 = new Operando(label1.Text);
            string bin= label1.Text;
            label1.Text = c1.BinarioDecimal(bin);
        }
        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            Operando c2= new Operando(label1.Text);
            string dec = label1.Text;
            label1.Text = c2.DecimalBinario(dec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operando c1 = new Operando(txtBinario.Text); 
            Operando c2 = new Operando(txtDecimal.Text);

            string o = comboBox1.Text;
            char operador=' ';
            if (o != "")
            {
                operador = o[0];
            }
            label1.Text = Calculadora.Operar(c1, c2, operador).ToString();
            listBox1.Items.Add(txtBinario.Text + operador + txtDecimal.Text + "=" + label1.Text);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }
        private void Limpiar()
        {
            txtBinario.Text = "";
            txtDecimal.Text = "";
            comboBox1.SelectedIndex = -1;
            label1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir ? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cleans the App from old data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            grpConvert.Enabled = false;
            txtNumero1.Focus();
        }*/
    }
}
