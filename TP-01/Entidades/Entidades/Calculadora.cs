using System;

namespace WinFormsApp1
{
    public static class Calculadora
    {
        /// <summary>
        /// El método Operar será de clase: validará y realizará la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// El método ValidarOperador será privado y estático. Deberá validar que el operador recibido sea +, -, / o *. Caso contrario retornará +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>

        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

    }
}