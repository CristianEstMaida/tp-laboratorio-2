using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEscuela
{
    public class Empresa
    {
        //public int contador = 0, sumatoria = 0, a = 0;
        public Empresa()
        {
            //Empresa empresa = new Empresa();
            //sumatoria += Empresa.Sumatoria(this.a);
        }

        public int A {
            get;
           // {
                //return;
                //A+0; 
            //}
            set; //{
                //A = 0+Sumatoria(A); 
            //}
        }
        //private
        //    String[,] tipo, proyecto, objetivos, interesado;
        //String[] empresa, nombre;
        //String resultado;
        //int[,] código, horas, preferencia;
        //int[] ofertados, dni, proyectos;
        //float[] promedio;
        //int i = 0, empresas, ofrecidos, ofertas = 0, alumnos, interés, intereses = 0, j, prioridad, k, distinto = 0;
        //bool igual = true;
        public static int Sumatoria(int a)
        {

            Empresa empresa= new Empresa();
            //empresa.A += a;
            //empresa.sumatoria += a;
            //sumatoria += a;
            return a;/*empresa.*///sumatoria;
        }
        public static string Información(int a, string b, string c)
        {
            //Empresa empresa = new Empresa();
            string promedio = "";
            //empresa.contador++;

            //empresa.sumatoria = Sumatoria(a);

            //promedio = ( empresa.sumatoria / empresa.contador).ToString();
            return promedio;
            /*("Ingrese cantidad empresas que ofrencen proyectos: ");
            empresas = Convert.ToInt32();
            empresa = new String[empresas];
            ofertados = new int[empresas];
            for (; i < empresas; i++)
            {
                ("Ingrese nombre de la empresa: ");
                empresa[i] = Convert.ToString();
                Console.Write("Ingrese cantidad de proyectos ofertados: ");
                ofertados[i] = Convert.ToInt32();
                ofrecidos = ofertados[i];
                ofertas += ofrecidos;
                if (i == 0)
                {
                    tipo = new String[empresas, ofrecidos];
                    código = new int[empresas, ofrecidos];
                    proyecto = new String[empresas, ofrecidos];
                    objetivos = new String[empresas, ofrecidos];
                    horas = new int[empresas, ofrecidos];
                }
                for (j = 0; j < ofrecidos; j++)
                {
                    ("Ingrese tipo de proyecto: ");
                    tipo[i, j] = Convert.ToString();
                    Console.Write("Ingrese código: ");
                    código[i, j] = Convert.ToInt32();
                    Console.Write("Ingrese nombre del proyecto: ");
                    proyecto[i, j] = Convert.ToString();
                    Console.Write("Ingrese objetivos: ");
                    objetivos[i, j] = Convert.ToString();
                    ("Ingrese horas estimadas de dedicación al proyecto: ");
                    horas[i, j] = Convert.ToInt32();
                }
            }
            do
            {
                ("Ingrese cantidad de alumnos que desean participar en el programa: ");
                alumnos = Convert.ToInt32();
            } while (alumnos > ofertas);
            dni = new int[alumnos];
            nombre = new String[alumnos];
            promedio = new float[alumnos];
            proyectos = new int[alumnos];
            for (i = 0; i < alumnos; i++)
            {
                Console.Write("Ingrese DNI: ");
                dni[i] = Convert.ToInt32();
                Console.Write("Ingrese nombre: ");
                nombre[i] = Convert.ToString();
                Console.Write("Ingrese nota promedio: ");
                promedio[i] = Convert.ToSingle();
                do
                {
                    do
                    {
                        Console.Write("Ingrese cantidad de proyectos en los cuales está interesado: ");
                        proyectos[i] = Convert.ToInt32();
                    } while (proyectos[i] > ofertas);
                    interés = proyectos[i];
                    intereses += interés;
                } while (intereses > ofertas);
                if (i == 0)
                {
                    interesado = new String[alumnos, interés];
                    preferencia = new int[alumnos, interés];
                }
                for (j = 0; j < interés; j++)
                {
                    do
                    {
                        do
                        {
                            Console.Write("Ingrese preferencia: ");
                            preferencia[i, j] = Convert.ToInt32();
                        } while (preferencia[i, j] < 1 || preferencia[i, j] > interés);
                        if (!igual)
                        {
                            igual = true;
                        }
                        for (k = 0; k < j; k++)
                        {
                            if (preferencia[i, j] != preferencia[i, k])
                            {
                                distinto++;
                            }
                            if (distinto == j - 1)
                            {
                                if (igual)
                                {
                                    igual = false;
                                }
                            }
                        }
                    } while (!igual);
                    prioridad = preferencia[i, j] - 1;
                    do
                    {
                        Console.Write("Ingrese proyecto: ");
                        interesado[i, prioridad] = Convert.ToString();
                        if (!igual)
                        {
                            igual = true;
                        }
                        distinto = 0;
                        for (k = 0; k < alumnos; k++)
                        {
                            if (interesado[i, prioridad] != proyecto[i, k])
                            {
                                distinto++;
                            }
                            if (distinto == alumnos)
                            {
                                if (igual)
                                {
                                    igual = false;
                                }
                            }
                        }
                    } while (!igual);

                }
            }
            Array.Sort(promedio);
            for (i = 0; i < alumnos; i++)
            {
                ("Promedio {0}\tAlumno {1}\t", promedio[i], nombre[i]);
                resultado = resultado + promedio[i].ToString() + "\t" + nombre[i].ToString() + "\t";
                for (j = 0; j < intereses; j++)
                {
                    ("\t Proyecto {2}", interesado[i, j]);
                    resultado = resultado + interesado[i, j].ToString() + "\t";
                }
            }
            return resultado;*/
        }
    }
}