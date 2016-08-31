
#region    Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluadorInfijaPosfija.Clases;
using EvaluadorInfijaPosfija;

#endregion Librerias de Clase que Utiliza el Evaluador de Expresiones Aritmetica

namespace WindowsFormsApplication1
{
    public partial class FormEvaluadorExpresiones : Form
    {
        public FormEvaluadorExpresiones()
        {
            InitializeComponent();
        }

        private void buttonEvaluarExpresiones_Click(object sender, EventArgs e)
        {
            try
            {
                ClassEvaluadorInfijoPostfija evaluarInfijaPostfija = new ClassEvaluadorInfijoPostfija();
                evaluarInfijaPostfija.evaluador(textBoxInfija.Text);

                double resultado = evaluarInfijaPostfija.obtenerPostfija();
                textBoxPostfija.Text = evaluarInfijaPostfija.PostFija;

                textBoxResultado.Text = resultado.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error de evaluación. Por favor de verificar la expresión ingresada e intente nuevamente. Si el problema persiste póngase en contacto con el soporte. Para más información diríjase al siguiente enlace https://NewTeamSoft/EvaluadorInfijoPostfijo/suport ",
                    "Evaluador de infijo a postfijo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBoxInfija_KeyPress(object sender, KeyPressEventArgs e)
        {
           ClassConfiguracionTecla.pulsacionTecla(e.KeyChar.ToString(), textBoxInfija);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "9");
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "+");
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "-");
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "*");
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "/");
        }

        private void buttonExponentes_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "^");
        }

        private void buttonParentesisAbierto_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, "(");
        }

        private void buttonParentesisCerrado_Click(object sender, EventArgs e)
        {
            ClassConfiguracionTecla.asignarNumeroTextBox(textBoxInfija, ")");
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCln_Click(object sender, EventArgs e)
        {
            textBoxInfija.Text = "0";
            textBoxPostfija.Clear();
            textBoxResultado.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(textBoxInfija.Text != "0")
            {
                textBoxInfija.Text = textBoxInfija.Text.Remove(textBoxInfija.TextLength - 1);
            }

        }
    }
}
