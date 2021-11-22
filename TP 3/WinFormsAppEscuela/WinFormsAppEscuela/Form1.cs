using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;

namespace WinFormsAppEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public List<int> lista = new List<int>();
        public int sumatoria = 0;
        public int sumaHombres = 0;
        public int sumaMujeres = 0;
        public int sumaHombresAprobados = 0;
        public int sumaMujeresAprobadas = 0;
        public int sumaHombresDesaprobados = 0;
        public int sumaMujeresDesaprobadas = 0;
        public int sumaNoBinarios = 0;
        public int sumaNoBinariosMatematica = 0;
        public int sumaNoBinariosProgramacion = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Empresa empresa = new Empresa();
            
            //listBox1.Text = "Hola" + empresa.Información();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Empresa empresa = new Empresa();

            //textBox1.Text = "Hola" + empresa.Información();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Operando c1 = new Operando(txtBinario.Text);
            //Operando c2 = new Operando(txtDecimal.Text);

            //string o = textBox1.Text;
            //char operador = ' ';
            //if (o != "")
            //{
            //operador = o[0];
            //}
            //Empresa empresa = new Empresa();

            //textBox2.Text = "Hola" + empresa.Información();
            
            //int sumatoria=0;
            //label1.Text = "";
            //label1.Text = Empresa.Información(Convert.ToInt32(textBox1.Text) ,textBox2.Text, textBox3.Text);
            //label1.Text = Empresa.Sumatoria(Convert.ToInt32(textBox1.Text)).ToString();
            listBox1.Items.Add(textBox1.Text + "\t" + textBox2.Text + "\t"+ textBox3.Text/*txtBinario.Text + operador + txtDecimal.Text + "=" + label1.Text*/);

            //listBox2.Items.Add(Convert.ToInt32(textBox1.Text));
            //List<int> lista = new List<int>();
            //List<string> listas = new List<string>();
            lista.Add(Convert.ToInt32(textBox1.Text));
            //listas.Add(textBox1.Text);

            //for (int i = 0; i < lista.Count; i++)
            //{
                //listBox2.Items.Add(lista[i]);
                //listBox2.Items.Add(listas[i]);
                // sumatoria = sumatoria + lista[i];
            //}
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Empresa empresa = new Empresa();

            //textBox2.Text = "Hola" + empresa.Información();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lista.Count; i++)
            {
                sumatoria = sumatoria + lista[i];
                
            }
            //Muestro el promedio
            listBox2.Items.Add(sumatoria/ lista.Count);
            label1.Text = (sumatoria / lista.Count).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (comboBox1.Text == "Masculino")
                {
                    sumaHombres = sumaHombres + lista[i];
                }
                if (comboBox1.Text == "Masculino" && lista[i] >= 6)
                {
                    sumaHombresAprobados = sumaHombresAprobados + lista[i];
                }
                if (comboBox1.Text == "Masculino" && lista[i] < 6)
                {
                    sumaHombresDesaprobados = sumaHombresDesaprobados + lista[i];
                }
            }
            //Muestro el promedio de hombres
            listBox2.Items.Add(sumaHombres / lista.Count);
            listBox2.Items.Add(sumaHombresAprobados / lista.Count);
            listBox2.Items.Add(sumaHombresDesaprobados / lista.Count);
            label6.Text = (sumaHombres / lista.Count).ToString();
            label8.Text = (sumaHombresAprobados / lista.Count).ToString();
            label9.Text = (sumaHombresDesaprobados / lista.Count).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (comboBox1.Text == "Femenino")
                {
                    sumaMujeres = sumaMujeres + lista[i];
                }
                if (comboBox1.Text == "Femenino" && lista[i] >= 6)
                {
                    sumaMujeresAprobadas = sumaMujeresAprobadas + lista[i];
                }
                if (comboBox1.Text == "Femenino" && lista[i] < 6)
                {
                    sumaMujeresDesaprobadas = sumaMujeresDesaprobadas + lista[i];
                }
            }
            //Muestro el promedio de mujeres
            listBox2.Items.Add(sumaMujeres / lista.Count);
            listBox2.Items.Add(sumaMujeresAprobadas / lista.Count);
            listBox2.Items.Add(sumaMujeresDesaprobadas / lista.Count);
            label7.Text = (sumaMujeres / lista.Count).ToString();
            label14.Text = (sumaMujeresAprobadas / lista.Count).ToString();
            label13.Text = (sumaMujeresDesaprobadas / lista.Count).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (comboBox1.Text == "No binario")
                {
                    sumaNoBinarios = sumaNoBinarios + lista[i];
                }
                if (comboBox1.Text == "No binario" && comboBox2.Text == "Matemática")
                {
                    sumaNoBinariosMatematica = sumaNoBinariosMatematica + lista[i];
                }
                if (comboBox1.Text == "No binario" && comboBox2.Text == "Programación")
                {
                    sumaNoBinariosProgramacion = sumaNoBinariosProgramacion + lista[i];
                }
            }
            //Muestro el promedio de no binarios
            listBox2.Items.Add(sumaNoBinarios / lista.Count);
            listBox2.Items.Add(sumaNoBinariosMatematica / lista.Count);
            listBox2.Items.Add(sumaNoBinariosProgramacion / lista.Count);
            label12.Text = (sumaNoBinarios / lista.Count).ToString();
            label10.Text = (sumaNoBinariosMatematica / lista.Count).ToString();
            label11.Text = (sumaNoBinariosProgramacion / lista.Count).ToString();

        }
    }
}
