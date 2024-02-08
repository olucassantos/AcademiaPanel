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


        private void numPesoCalorias_ValueChanged(object sender, EventArgs e)
        {
            CalculaCaloriasGastas();
        }

        private void CalculaCaloriasGastas()
        {
            decimal peso = numPesoCalorias.Value;
            DateTime horaDuracao = dateDuracao.Value;
            int atividade = cmbAtividade.SelectedIndex;

            int horas = horaDuracao.Hour;
            int minutos = horaDuracao.Minute;

            decimal duracaoAtividade = (horas * 60) + minutos;

            decimal met = 0;

            if (atividade == 0)
                met = 3;
            else if (atividade == 1)
                met = 8.3m;
            else if (atividade == 2)
                met = 6;
            else if (atividade == 3)
                met = 6;
            else if (atividade == 4)
                met = 5;
            else if (atividade == 5)
                met = 7;

            decimal calorias = met * peso * (duracaoAtividade / 60);

            lblResultadoCalorias.Text = calorias.ToString("f2");
        }

        private void numPesoHidratacao_ValueChanged(object sender, EventArgs e)
        {
            decimal peso = numPesoHidratacao.Value;

            decimal hidratacao = (peso * 35) / 1000;

            lblResultadoHidratacao.Text = hidratacao.ToString() + "L";
        }
    }
}
