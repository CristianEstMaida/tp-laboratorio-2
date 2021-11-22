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
            //listBox1.Items.Add("Nota\tNombre\tMateria");
        }

        public List<float> lista = new List<float>();
        public float cantidadAprobados = 0;
        public float cantidadDesaprobados = 0;
        public float sumatoria = 0;
        public float sumaAprobadosMatematica = 0;
        public float sumaAprobadosProgramacion = 0;
        public float sumaHombres = 0;
        public float sumaMujeres = 0;
        public float sumaHombresAprobados = 0;
        public float sumaMujeresAprobadas = 0;
        public float sumaHombresDesaprobados = 0;
        public float sumaMujeresDesaprobadas = 0;
        public float sumaNoBinarios = 0;
        public float sumaNoBinariosAprobados = 0;
        public float sumaNoBinariosDesaprobados = 0;

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
            lista.Add(Convert.ToSingle(textBox1.Text));
            
            label17.Text = lista.Count.ToString();
            
            lista[lista.Count - 1]--;

            if (lista[lista.Count-1] >= 6)
            {
                cantidadAprobados++;
            }
            if (lista[lista.Count-1] < 6)
            {
                cantidadDesaprobados++;
            }

            sumatoria = sumatoria + lista[lista.Count - 1];

            //for (int i = 0; i < lista.Count; i++)
            //{
                if (comboBox2.Text == "Matemática" && lista[lista.Count - 1] >= 6)
                {
                    sumaAprobadosMatematica = sumaAprobadosMatematica + lista[lista.Count - 1];
                }
                if (comboBox2.Text == "Programación" && lista[lista.Count - 1] >= 6)
                {
                    sumaAprobadosProgramacion = sumaAprobadosProgramacion + lista[lista.Count - 1];
                }

                if (comboBox1.Text == "Masculino")
                {
                    sumaHombres = sumaHombres + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "Masculino" && lista[lista.Count - 1] >= 6)
                {
                    sumaHombresAprobados = sumaHombresAprobados + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "Masculino" && lista[lista.Count - 1] < 6)
                {
                    sumaHombresDesaprobados = sumaHombresDesaprobados + lista[lista.Count - 1];
                }

                if (comboBox1.Text == "Femenino")
                {
                    sumaMujeres = sumaMujeres + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "Femenino" && lista[lista.Count - 1] >= 6)
                {
                    sumaMujeresAprobadas = sumaMujeresAprobadas + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "Femenino" && lista[lista.Count - 1] < 6)
                {
                    sumaMujeresDesaprobadas = sumaMujeresDesaprobadas + lista[lista.Count - 1];
                }

                if (comboBox1.Text == "No binario")
                {
                    sumaNoBinarios = sumaNoBinarios + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "No binario" && lista[lista.Count - 1] >= 6)
                {
                    sumaNoBinariosAprobados = sumaNoBinariosAprobados + lista[lista.Count - 1];
                }
                if (comboBox1.Text == "No binario" && lista[lista.Count - 1] < 6)
                {
                    sumaNoBinariosDesaprobados = sumaNoBinariosDesaprobados + lista[lista.Count - 1];
                }
                //listBox2.Items.Add(lista[i]);
                //listBox2.Items.Add(listas[i]);
                // sumatoria = sumatoria + lista[i];
            //}

            

            label18.Text = cantidadAprobados.ToString();
            label19.Text = cantidadDesaprobados.ToString();

            //listas.Add(textBox1.Text);

            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Empresa empresa = new Empresa();

            //textBox2.Text = "Hola" + empresa.Información();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < lista.Count; i++)
            //{
                
            //}
            //Muestro el promedio
            listBox2.Items.Add(sumatoria / lista.Count);
            listBox2.Items.Add(sumaAprobadosMatematica / lista.Count);
            listBox2.Items.Add(sumaAprobadosProgramacion / lista.Count);

            label1.Text = (sumatoria / lista.Count).ToString();
            label15.Text = (sumaAprobadosMatematica / lista.Count).ToString();
            label16.Text = (sumaAprobadosProgramacion / lista.Count).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < lista.Count; i++)
            //{
                
            //}
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
            //for (int i = 0; i < lista.Count; i++)
            //{
                
            //}
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
            //for (int i = 0; i < lista.Count; i++)
            //{
                
            //}
            //Muestro el promedio de no binarios
            listBox2.Items.Add(sumaNoBinarios / lista.Count);
            listBox2.Items.Add(sumaNoBinariosAprobados / lista.Count);
            listBox2.Items.Add(sumaNoBinariosDesaprobados / lista.Count);
            label12.Text = (sumaNoBinarios / lista.Count).ToString();
            label10.Text = (sumaNoBinariosAprobados / lista.Count).ToString();
            label11.Text = (sumaNoBinariosDesaprobados / lista.Count).ToString();

        }
    }
}
