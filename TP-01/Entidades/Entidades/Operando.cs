using System;

namespace WinFormsApp1
{
    public class Operando
    {
        /// <summary>
        /// El atributo numero es privado.
        /// </summary>
        private double numero;

        /// <summary>
        /// El constructor por defecto (sin parámetros) asignará valor 0 al atributo numero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
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
        /// <summary>
        /// La propiedad Numero asignará un valor al atributo número, previa validación. En este lugar será el único en todo el código que llame al método ValidarOperando.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// El método BinarioDecimal validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// El método DecimalBinario convertirá un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido". Reutilizar código
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            Operando op = new Operando();
            int num = (int)Math.Abs(numero);
            string resto = "";

            for (; num >= 2;)
            {
                resto += num % 2;
                num = num / 2;

            }
            resto += num;
            char[] r = resto.ToCharArray();
            Array.Reverse(r);
            resto = "";
            for (int i=0; i < r.Length ; i++)
            {
                resto += r[i];
            }
            bool prueba = int.TryParse(resto, out int restoPrueba);

            if (prueba && restoPrueba < int.MaxValue)
            {
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

            return DecimalBinario(num);
            
        }

        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>

        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length -1; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// El operador - realizará la operación resta entre dos números.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// El operador * realizará la operación multiplición entre dos números.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// El operador / realizará la operación división entre dos números. Si se tratara de una división por 0, retornará double.MinValue.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
        /// <summary>
        /// ValidarOperando comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
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

