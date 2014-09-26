using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Calculadora
{

    public class Calculos
    {
        //atributos
        public String numeroUm = null;
        public String numeroDois = null;
        public Char opera;

        //construtor

        public Calculos()
        {
        }

        //métodos

        /*Bloco 1
         * este bloco de metodos é responsável por receber dois valores mais a operação,
         * afim de preparar sempre o primeiro cálculo.  
         */

        public void recebeN1(String valor1)
        {
            this.numeroUm = valor1;
        }
        public void recebeN2(String valor2)
        {
            this.numeroDois = valor2;
        }
        public void recebeOpera(Char opera)
        {
            this.opera = opera;
        }

        /*Bloco2
         * Este bloco retorna o resultado conforme a operação.*/
        public String calcula()
        {
            String resultado = "";
            //se os valores tiverem preenchidos
            if (this.numeroUm != null && this.numeroDois != null)
            {
                if (opera == '+')
                {
                    resultado = Convert.ToString(Convert.ToDouble(numeroUm) + Convert.ToDouble(numeroDois));
                    return resultado;
                }
                if (opera == '-')
                {
                    resultado = Convert.ToString(Convert.ToDouble(numeroUm) - Convert.ToDouble(numeroDois)); ;
                    return resultado;
                }
                if (opera == '/')
                {
                    resultado = Convert.ToString(Convert.ToDouble(numeroUm) / Convert.ToDouble(numeroDois)); ;
                    return resultado;
                }
                if (opera == '*')
                {
                    resultado = Convert.ToString(Convert.ToDouble(numeroUm) * Convert.ToDouble(numeroDois)); ;
                    return resultado;
                }
                if (opera == '*')
                {
                    resultado = Convert.ToString((Convert.ToDouble(numeroUm) + Convert.ToDouble(numeroDois)) / 100);
                    return resultado;
                }
                if (opera == '%')
                {
                    resultado = Convert.ToString((Convert.ToDouble(numeroUm)+opera+(Convert.ToDouble(numeroDois)))/100);
                    return resultado;
                }
                if (opera == 'r')
                {
                    resultado = Convert.ToString(Math.Sqrt(Convert.ToDouble(numeroUm)));
                    return resultado;
                }
            }
            else { resultado = null; }

            return resultado;
        }

        /*Este método é responsável por limpar todas variáveispelo botão C*/
        public void clear()
        {
            this.opera = 'v';
            this.numeroUm = null;
            this.numeroDois = null;
        }
    }
}

