using PI2.calculoSuspensaoDataSetTableAdapters;
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
    public partial class Calculadora : Form
    {
        private List<Roda> rodas = new List<Roda>();

        public Calculadora()
        {
            InitializeComponent();
            rodas.Add(roda1);
            rodas.Add(roda2);
            rodas.Add(roda3);
            rodas.Add(roda4);
            roda2.Visible = false;
            roda4.Visible = false;
            roda1.GroupBoxText = "Rodas Dianteiras";
            roda3.GroupBoxText = "Rodas Traseiras";
            roda1.Eh_Par_Rodas = true;
            roda3.Eh_Par_Rodas = true;
        }

        private void peso_total_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (double.TryParse(textBox.Text, out double parsedValue))
                {
                    foreach(Roda r in rodas)
                    {
                       r.Peso_Total = parsedValue;
                    }
                }
            }
        }

        private void rodas_dianteiras_assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    roda2.Visible = true;
                    roda1.GroupBoxText = "Roda Dianteira Direita";
                    roda2.GroupBoxText = "Roda Dianteira Esquerda";
                    roda1.Eh_Par_Rodas = false;
                }
                else
                {
                    roda2.Visible = false;
                    roda1.GroupBoxText = "Rodas Dianteiras";
                    roda1.Eh_Par_Rodas = true;
                }
            }
        }

        private void rodas_traseiras_assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    roda4.Visible = true;
                    roda3.GroupBoxText = "Roda Traseira Direita";
                    roda4.GroupBoxText = "Roda Traseira Esquerda";
                    roda3.Eh_Par_Rodas = false;
                }
                else
                {
                    roda4.Visible = false;
                    roda3.GroupBoxText = "Rodas Dianteiras";
                    roda3.Eh_Par_Rodas = true;
                }
            }
        }
    }
}
