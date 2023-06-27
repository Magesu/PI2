using PI2.calculoSuspensaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI2
{
    public partial class Carro : UserControl
    {
        public double peso_total;
        public double Peso_Total
        {
            get { return peso_total; }
            set
            {
                peso_total = value;
                AtualizarPesoRodas();
            }
        }
        private bool rodas_dianteiras_assimetricas = false;
        public bool Rodas_Dianteiras_Assimetricas
        {
            get { return rodas_dianteiras_assimetricas;}
            set {
                rodas_dianteiras_assimetricas = value;
                Atualizar();
            }
        }
        private bool rodas_traseiras_assimetricas = false;
        public bool Rodas_Traseiras_Assimetricas
        {
            get { return rodas_traseiras_assimetricas; }
            set
            {
                rodas_traseiras_assimetricas = value;
                Atualizar();
            }
        }
        [Browsable(true)]
        public string Nome
        {
            get { return nomeLabel.Text; }
            set { nomeLabel.Text = value; }
        }
        private List<Roda> rodas = new List<Roda>();
        public int limite_calculos { get; set; }

        public Carro()
        {
            InitializeComponent();

            limite_calculos = 3;

            rodas.Add(roda1);
            rodas.Add(roda2);
            rodas.Add(roda3);
            rodas.Add(roda4);
            rodas.Add(roda5);
            rodas.Add(roda6);

            foreach(Roda r in rodas)
            {
                r.Carro_Parente = this;
            }

            Atualizar();
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
                if (double.TryParse(textBox.Text, out double parsedValue))
                {
                    Peso_Total = parsedValue;
                }
                else
                {
                    peso_total = -1;
                }
            }
        }

        private void CheckBox_Rodas_Dianteiras_Assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                Rodas_Dianteiras_Assimetricas = checkBox.Checked;
            }
        }

        private void CheckBox_Rodas_Traseiras_Assimetricas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                Rodas_Traseiras_Assimetricas = checkBox.Checked;
            }
        }

        private void Atualizar()
        {
            TextBox_peso_total.Text = Peso_Total.ToString();
            CheckBox_rodas_dianteiras_assimetricas.Checked = Rodas_Dianteiras_Assimetricas;
            CheckBox_rodas_traseiras_assimetricas.Checked = Rodas_Traseiras_Assimetricas;

            rodas.ElementAt(0).Visible = Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(1).Visible = Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(2).Visible = !Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(3).Visible = Rodas_Traseiras_Assimetricas;
            rodas.ElementAt(4).Visible = Rodas_Traseiras_Assimetricas;
            rodas.ElementAt(5).Visible = !Rodas_Traseiras_Assimetricas;
        }
        
        public void SalvarCalculo(int id_equipe)
        {
            int id_calculo = (int) calculosTableAdapter1.InsertQuery(id_equipe, Peso_Total, Rodas_Dianteiras_Assimetricas, Rodas_Traseiras_Assimetricas);

            foreach(Roda r in rodas)
            {
                if (r.Visible)
                {
                    rodasTableAdapter1.Insert(id_calculo, r.Nome, r.Distribuicao_Peso, r.Distancia_Bitola, r.Distancia_Mola, r.Constante_Elastica, r.Comprimento_Braco, r.Altura, r.Curso_Angular);
                }
            }

            // Deleta os resultados mais antigos para manter os resultados salvos dentro do limite

            DataTable calculosTable = calculosTableAdapter1.GetDataByIDEquipe(id_equipe);

            if(calculosTable.Rows.Count > limite_calculos)
            {
                // Arruma os cálculos em ordem ascendente
                calculosTable.DefaultView.Sort = "id_calculo ASC";
                DataTable sortedCalculosTable = calculosTable.DefaultView.ToTable();

                // Calcula o número de entradas para deletar
                int entradasParaDeletar = sortedCalculosTable.Rows.Count - 3;

                // Deleta as entradas mais antigas
                for (int i = 0; i < entradasParaDeletar; i++)
                {
                    // Encontre o id do cálculo correspondente e deleta;
                    int id_calculo_a_ser_deletado = (int) sortedCalculosTable.Rows[i]["id_calculo"];

                    // Deleta as rodas do cálculo
                    rodasTableAdapter1.DeleteQuery(id_calculo_a_ser_deletado);

                    calculosTableAdapter1.DeleteQuery(id_calculo_a_ser_deletado);
                }
            }
        }

        public void CarregarCalculo(int id_calculo)
        {
            foreach(Roda r in rodas)
            {
                r.Visible = false;
            }

            DataRow calculoRow = calculosTableAdapter1.GetDataByIDCalculo(id_calculo).Rows[0];

            DataTable rodasTable = rodasTableAdapter1.GetDataByIDCalculo(id_calculo);

            Nome = "ID do cálculo: " + calculoRow["id_calculo"].ToString();
            Peso_Total = (double) calculoRow["peso_total"];
            Rodas_Dianteiras_Assimetricas = (bool) calculoRow["rodas_dianteiras_assimetricas"];
            Rodas_Traseiras_Assimetricas = (bool) calculoRow["rodas_traseiras_assimetricas"];

            foreach(DataRow row in rodasTable.Rows)
            {
                foreach (Roda r in rodas)
                {
                    if ((string) row["nome"] == r.Nome)
                    {
                        r.Povoar((double) row["distribuicao_peso"], (double) row["distancia_bitola"], (double) row["distancia_mola"], (double) row["comprimento_braco"], (double) row["altura"]);
                        r.Visible = true;
                    }
                }
            }
        }
    }
}
