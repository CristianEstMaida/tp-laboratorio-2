using WinFormsApp1;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Entidades;

namespace WinFormsApp1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando c1 = new Operando(labelResultado.Text);
            string bin = labelResultado.Text;
            labelResultado.Text = c1.BinarioDecimal(bin);
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando c2 = new Operando(labelResultado.Text);
            string dec = labelResultado.Text;
            labelResultado.Text = c2.DecimalBinario(dec);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = cmbOperador.Text;
          
            labelResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, operador).ToString();
            lstOperaciones.Items.Add(txtNumero1.Text + operador + txtNumero2.Text + "=" + labelResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = -1;
            labelResultado.Text = "0";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando c1 = new Operando(numero1);
            Operando c2 = new Operando(numero2);
            return Calculadora.Operar(c1, c2, operador[0]);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
