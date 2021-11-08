using System;

namespace WinFormsApp1
{
    public class Operando
    {
        private double numero;

        public string Numero
        {

            get
            {
                return this.numero.ToString();
            }
            set
            {
                Numero = ValidarOperando(numero.ToString()).ToString();
            }
        }
        public string BinarioDecimal(string binario)
        {
            Operando op = new Operando();
            int valor = 0;
            Array.Reverse(binario.ToCharArray());

            if (op.EsBinario(numero.ToString()))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1')
                    {
                        valor += (int)Math.Pow(2, i);
                    }
                }
                return valor.ToString();
            }
            else
            {
                return "Valor inválido";
            }

        }
        public string DecimalBinario(double numero)
        {
            Operando op = new Operando();
            int num = (int)Math.Abs(numero);
            string resto = "";

            if (op.EsBinario(numero.ToString()))
            {
                for (; num >= 2;)
                {
                    resto += num % 2;
                    num = num / 2;

                }
                resto += num;

                Array.Reverse(resto.ToCharArray());

                return resto;
            }
            else
            {
                return "Valor inválido";
            }
        }
        public string DecimalBinario(string numero)
        {
            Operando op = new Operando();
            double num;
            double.TryParse(numero, out num);
            if (op.EsBinario(numero.ToString()))
            {
                return DecimalBinario(num);
            }
            else
            {
                return "Valor inválido";
            }

        }
        bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length - 1; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }
        public static double operator +(Operando n1, Operando n2)
        {

            return n1.numero + n2.numero;
        }
        public Operando() : this(0)
        {
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            double num;
            double.TryParse(strNumero, out num);
            this.numero = num;
        }
        double ValidarOperando(string strNumero)
        {
            double num;

            if (double.TryParse(strNumero, out num))
            {
                return num;
            }
            else
            {
                return 0;
            }
        }

    }
}

