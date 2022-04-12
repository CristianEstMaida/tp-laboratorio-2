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
        /// <summary>
        /// El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando c1 = new Operando(labelResultado.Text);
            string bin = labelResultado.Text;
            labelResultado.Text = c1.BinarioDecimal(bin);
        }
        /// <summary>
        /// El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando c2 = new Operando(labelResultado.Text);
            string dec = labelResultado.Text;
            labelResultado.Text = c2.DecimalBinario(dec);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            string operador="+";
            string numero1 = "0";
            string numero2 = "0";

            if (cmbOperador.Text!="")
            {
                operador = cmbOperador.Text;
            }
            
          
            labelResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, operador).ToString();

            if(txtNumero1.Text!="")
            {
                numero1 = txtNumero1.Text;
            }
            if (txtNumero2.Text != "")
            {
                numero2 = txtNumero2.Text;
            }
            lstOperaciones.Items.Add(numero1 + operador + numero2 + "=" + labelResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// El método Limpiar será llamado por el evento click del botón btnLimpiar y borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = -1;
            labelResultado.Text = "0";
        }
        /// <summary>
        /// El método Operar será estático recibirá los dos números y el operador para luego llamar al método Operar de Calculadora y retornar el resultado al método de evento del botón btnOperar que reflejará el resultado en el Label txtResultado.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
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

        /// <summary>
        /// El evento Load del formulario deberá llamar al método Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
