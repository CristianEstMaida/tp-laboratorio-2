using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading;

namespace WinFormsAppEscuela
{
    public partial class Form1 : Form
    {
        private const string archivoPath = "notasAlumnos.json";

        private List<Juego> juegos;
        private bool ejecutando;
        private JsonFiler<List<Juego>> json;

        private CancellationTokenSource source;
        private CancellationToken token;

        public Form1()
        {
            InitializeComponent();
            this.juegos = new List<Juego>();
            this.json = new JsonFiler<List<Juego>>();
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

   

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ejecutando)
            {
                this.source = new CancellationTokenSource();
                this.token = source.Token;
                // Iniciar hilos
                foreach (Juego p in this.juegos)
                {
                    Task.Run(() => p.IniciarCarrusel(token));
                }

                this.ejecutando = true;
            }
            else
            {
                this.FinalizarTasks();
            }

            listBox1.Items.Add(textBox1.Text + "\t" + textBox2.Text + "\t"+ textBox3.Text + "\t" + comboBox2.Text/*txtBinario.Text + operador + txtDecimal.Text + "=" + label1.Text*/);

            lista.Add(Convert.ToSingle(textBox1.Text));
            
            label17.Text = lista.Count.ToString();
            
            if (lista[lista.Count-1] >= 6)
            {
                cantidadAprobados++;
            }
            if (lista[lista.Count-1] < 6)
            {
                cantidadDesaprobados++;
            }

            sumatoria = sumatoria + lista[lista.Count - 1];

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

            label18.Text = cantidadAprobados.ToString();
            label19.Text = cantidadDesaprobados.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Muestro el promedio
            listBox2.Items.Add("Promedio\tPromedio de aprobados en Matemática\tPromedio de aprobados en Programación");
            listBox2.Items.Add((sumatoria / lista.Count).ToString()+"\t"+(sumaAprobadosMatematica / lista.Count).ToString()+"\t"+(sumaAprobadosProgramacion / lista.Count).ToString());

            label1.Text = (sumatoria / lista.Count).ToString();
            label15.Text = (sumaAprobadosMatematica / lista.Count).ToString();
            label16.Text = (sumaAprobadosProgramacion / lista.Count).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestro el promedio de hombres
            listBox2.Items.Add("Promedio de hombres\tPromedio de hombres aprobados\tPromedio de hombres desaprobados");
            listBox2.Items.Add((sumaHombres / lista.Count).ToString()+"\t"+(sumaHombresAprobados / lista.Count).ToString()+"\t"+(sumaHombresDesaprobados / lista.Count));
            
            label6.Text = (sumaHombres / lista.Count).ToString();
            label8.Text = (sumaHombresAprobados / lista.Count).ToString();
            label9.Text = (sumaHombresDesaprobados / lista.Count).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            //Muestro el promedio de mujeres
            listBox2.Items.Add("Promedio de mujeres\tPromedio de mujeres aprobadas\tPromedio de mujeres desaprobadas");
            listBox2.Items.Add((sumaMujeres / lista.Count).ToString()+"\t"+(sumaMujeresAprobadas / lista.Count).ToString()+"\t"+ (sumaMujeresDesaprobadas / lista.Count).ToString());
            
            label7.Text = (sumaMujeres / lista.Count).ToString();
            label14.Text = (sumaMujeresAprobadas / lista.Count).ToString();
            label13.Text = (sumaMujeresDesaprobadas / lista.Count).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            //Muestro el promedio de no binarios
            listBox2.Items.Add("Promedio de no binarios\tPromedio de no binarios aprobados\tPromedio de no binarios desaprobados");
            listBox2.Items.Add((sumaNoBinarios / lista.Count).ToString()+"\t"+(sumaNoBinariosAprobados / lista.Count).ToString()+"\t"+(sumaNoBinariosDesaprobados / lista.Count).ToString());
            label12.Text = (sumaNoBinarios / lista.Count).ToString();
            label10.Text = (sumaNoBinariosAprobados / lista.Count).ToString();
            label11.Text = (sumaNoBinariosDesaprobados / lista.Count).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Leo mis juegos del archivo
            if (this.json.ExisteArchivo(archivoPath))
            {
                this.Text += "Maida Cristian Esteban";
                this.json.Leer(archivoPath, out this.juegos);
            }
            //this.InitializeJuegos();

            foreach (Juego p in this.juegos)
            {
                // Asociar Evento
                p.InformarAvance += AvanceJuegos;

                PictureBox pic = (PictureBox)p.ControlVisual;
                pic.Location = this.CalcularUbicacion(pic.Location, p./*Ubicacion*/Avanzar());
                this.Controls.Add(pic);
            }
        
        }

        private Point CalcularUbicacion(Point posicion, short avance)
        {
            int x = 0;
            int y = avance;
            
            return new Point(x, y);
        }

        private void AvanceJuegos(object sender, short movimiento)
        {
            PictureBox pic = (PictureBox)((Juego)sender).ControlVisual;

            // Invocación del hilo principal

            if (pic.InvokeRequired)
            {
                InformacionDeAvance del = new InformacionDeAvance(this.AvanceJuegos);
                object[] objs = new object[] { sender, movimiento };
                pic.Invoke(del, objs);
            }
            else
            {
                pic.Location = this.CalcularUbicacion(pic.Location, movimiento);
            }

        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.FinalizarTasks();

            // Guardo mis juegos del archivo
            this.json.Guardar(archivoPath, this.juegos);
        }
        private void FinalizarTasks()
        {
            if (this.ejecutando)
            {
                // Cancelar hilos
                this.source.Cancel();
                this.ejecutando = false;//!this.ejecutando;
                //this.FinalizarTasks();
               
            }
        }
    }
}
