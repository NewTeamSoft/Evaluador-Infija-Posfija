#region    Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluadorInfijaPosfija.Clases;

#endregion Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

namespace EvaluadorInfijaPosfija
{
    public static class ClassConfiguracionTecla
    {
        #region    Procedimiento Estatico Publico Captura la Pulsasiones del Teclado

        /// <summary>
        /// Procedimiento Estatico Publico. Captura las pulsasiones.
        /// </summary>
        /// <param name="stringKeyChar"></param>
        /// <param name="textBox"></param>
        public static void pulsacionTecla(string stringKeyChar, TextBox textBox)
        {
            if (textBox.Text == "0") textBox.Text = "";

            switch (stringKeyChar)
            {
                case "1":
                    textBox.Text = textBox.Text + "1";
                    break;
                case "2":
                    textBox.Text = textBox.Text + "2";
                    break;
                case "3":
                    textBox.Text = textBox.Text + "3";
                    break;
                case "4":
                    textBox.Text = textBox.Text + "4";
                    break;
                case "5":
                    textBox.Text = textBox.Text + "5";
                    break;
                case "6":
                    textBox.Text = textBox.Text + "6";
                    break;
                case "7":
                    textBox.Text = textBox.Text + "7";
                    break;
                case "8":
                    textBox.Text = textBox.Text + "8";
                    break;
                case "9":
                    textBox.Text = textBox.Text + "9";
                    break;
                case "0":
                    textBox.Text = textBox.Text + "0";
                    break;
                case "+":
                    textBox.Text = textBox.Text + "+";
                    break;
                case "-":
                    textBox.Text = textBox.Text + "-";
                    break;
                case "*":
                    textBox.Text = textBox.Text + "*";
                    break;
                case "/":
                    textBox.Text = textBox.Text + "/";
                    break;
                case "^":
                    textBox.Text = textBox.Text + "^";
                    break;
                case "(":
                    textBox.Text = textBox.Text + "(";
                    break;
                case ")":
                    textBox.Text = textBox.Text + ")";
                    break;
                default:
                    break;
            }

            #endregion Procedimiento Estatico Publico Captura la Pulsasiones del Teclado

        }

        #region    Procedimiento Estatico Publico Agrega Numero a la Expresion Aritmetica

        /// <summary>
        /// Procedimiento Estatico Publico Agrega Numero a la Expresion Aritmetica
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="stringoperando"></param>
        public static void asignarNumeroTextBox(TextBox textBox, string stringoperando)
        {
            if (textBox.Text == "0") textBox.Text = "";
            textBox.Text = textBox.Text + stringoperando;
        }

        #endregion Procedimiento Estatico Publico Agrega Numero a la Expresion Aritmetica

    }
}
