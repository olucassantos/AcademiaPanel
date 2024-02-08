using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaPanel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculaImc()
        {
            decimal peso = numPeso.Value;
            decimal altura = numAltura.Value;

            // Se o pesou ou altura estiverem zeradas o calculo não é feito
            if (peso == 0 || altura == 0)
            {
                return;
            }

            decimal imc = peso / (altura * altura);

            lblResultadoImc.Text = imc.ToString("f2");
        }

        private void numPeso_ValueChanged(object sender, EventArgs e)
        {
            CalculaImc();
        }
    }
}
