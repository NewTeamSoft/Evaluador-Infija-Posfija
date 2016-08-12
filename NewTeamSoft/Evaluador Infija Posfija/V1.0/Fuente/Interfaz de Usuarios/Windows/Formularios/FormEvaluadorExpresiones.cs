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

            ClassEvaluadorInfijoPostfija evaluar = new ClassEvaluadorInfijoPostfija();
            evaluar.evaluador(textBoxInfija.Text);

            double resultado = evaluar.obtenerPostfija();
            textBoxPostfija.Text = evaluar.PostFija;

            textBoxResultado.Text = resultado.ToString();
        }
    }
}
