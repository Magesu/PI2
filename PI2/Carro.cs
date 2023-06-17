using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI2
{
    public partial class Carro : UserControl
    {
        public float peso_total;
        public float Peso_Total
        {
            get { return peso_total; }
            set
            {
                peso_total = value;
                AtualizarPesoRodas();
            }
        }
        private bool rodas_dianteiras_assimetricas = false;
        private bool rodas_traseiras_assimetricas = false;
        private List<Roda> rodas = new List<Roda>();

        public Carro()
        {
            InitializeComponent();

            rodas.Add(roda1);
            rodas.Add(roda2);
            rodas.Add(roda3);
            rodas.Add(roda4);

            foreach(Roda r in rodas)
            {
                r.Carro_Parente = this;
            }

            rodas.ElementAt(1).Visible = false;
            rodas.ElementAt(3).Visible = false;
            rodas.ElementAt(0).GroupBoxText = "Rodas Dianteiras";
            rodas.ElementAt(2).GroupBoxText = "Rodas Traseiras";
            rodas.ElementAt(0).Eh_Par_Rodas = true;
            rodas.ElementAt(1).Eh_Par_Rodas = false;
            rodas.ElementAt(2).Eh_Par_Rodas = true;
            rodas.ElementAt(3).Eh_Par_Rodas = false;
        }

        public List<Roda> GetRodas()
        {
            return new List<Roda>(rodas);
        }

        private void AtualizarPesoRodas()
        {
            foreach(Roda r in rodas)
            {
                r.ForcarAtualizarPeso();
            }
        }

        private void TextBox_peso_total_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Peso_Total = parsedValue;
                }
                else
                {
                    peso_total = -1;
                }
            }
        }

        private void CheckBox_rodas_dianteiras_assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    rodas_dianteiras_assimetricas = true;
                    rodas.ElementAt(1).Visible = true;
                    rodas.ElementAt(0).GroupBoxText = "Roda Dianteira Direita";
                    rodas.ElementAt(1).GroupBoxText = "Roda Dianteira Esquerda";
                    rodas.ElementAt(0).Eh_Par_Rodas = false;
                    rodas.ElementAt(1).CopiarAtributos(rodas.ElementAt(0));
                }
                else
                {
                    rodas_dianteiras_assimetricas = false;
                    rodas.ElementAt(1).Visible = false;
                    rodas.ElementAt(0).GroupBoxText = "Rodas Dianteiras";
                    rodas.ElementAt(0).Eh_Par_Rodas = true;
                }
            }
        }

        private void CheckBox_rodas_traseiras_assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    rodas_traseiras_assimetricas = true;
                    rodas.ElementAt(3).Visible = true;
                    rodas.ElementAt(2).GroupBoxText = "Roda Traseira Direita";
                    rodas.ElementAt(3).GroupBoxText = "Roda Traseira Esquerda";
                    rodas.ElementAt(2).Eh_Par_Rodas = false;
                    rodas.ElementAt(3).CopiarAtributos(rodas.ElementAt(2));
                }
                else
                {
                    rodas_traseiras_assimetricas = false;
                    rodas.ElementAt(3).Visible = false;
                    rodas.ElementAt(2).GroupBoxText = "Rodas Dianteiras";
                    rodas.ElementAt(2).Eh_Par_Rodas = true;
                }
            }
        }
    }
}
