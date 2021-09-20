using System;

namespace WinFormsApp1
{
    public class Calculadora
    {
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            Calculadora c1 = new Calculadora();
            switch (c1.ValidarOperador(operador))
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if (Operando(num2))
                    {
                        resultado = num1 / num2;
                    }
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

        private static bool Operando(Operando num2)
        {

            return int.Parse(num2.Numero) != 0;
        }

        private char ValidarOperador(char operador)
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