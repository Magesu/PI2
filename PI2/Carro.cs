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
                AtualizarSimetriaRodas();
            }
        }
        private bool rodas_traseiras_assimetricas = false;
        public bool Rodas_Traseiras_Assimetricas
        {
            get { return rodas_traseiras_assimetricas; }
            set
            {
                rodas_traseiras_assimetricas = value;
                AtualizarSimetriaRodas();
            }
        }
        private List<Roda> rodas = new List<Roda>();

        public Carro()
        {
            InitializeComponent();

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

            AtualizarSimetriaRodas();
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

        private void AtualizarSimetriaRodas()
        {
            rodas.ElementAt(0).Visible = Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(1).Visible = Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(2).Visible = !Rodas_Dianteiras_Assimetricas;
            rodas.ElementAt(3).Visible = Rodas_Traseiras_Assimetricas;
            rodas.ElementAt(4).Visible = Rodas_Traseiras_Assimetricas;
            rodas.ElementAt(5).Visible = !Rodas_Traseiras_Assimetricas;
        }
        
        public void SalvarCalculo()
        {
            string connectionString = Properties.Settings.Default.calculoSuspensaoConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand calculosInsertCommand = new SqlCommand("INSERT INTO Calculos(id_equipe, peso_total) VALUES (@id_equipe, @peso_total); SELECT SCOPE_IDENTITY();", connection))
                {
                    calculosInsertCommand.Parameters.AddWithValue("@id_equipe", 1);
                    calculosInsertCommand.Parameters.AddWithValue("@peso_total", Peso_Total);

                    int id_calculo = Convert.ToInt32(calculosInsertCommand.ExecuteScalar());

                    foreach(Roda r in rodas)
                    {
                        if (r.Visible)
                        {
                            using (SqlCommand rodaInsertCommand = new SqlCommand("INSERT INTO Rodas VALUES(@id_calculo, @nome, @distribuicao_peso, @distancia_bitola, @distancia_mola, @constante_elastica, @comprimento_braco, @altura, @curso_angular)", connection))
                            {
                                rodaInsertCommand.Parameters.AddWithValue("@id_calculo", id_calculo);
                                rodaInsertCommand.Parameters.AddWithValue("@nome", r.Nome);
                                rodaInsertCommand.Parameters.AddWithValue("@distribuicao_peso", r.Distribuicao_Peso);
                                rodaInsertCommand.Parameters.AddWithValue("@distancia_bitola", r.Distancia_Bitola);
                                rodaInsertCommand.Parameters.AddWithValue("@distancia_mola", r.Distancia_Mola);
                                rodaInsertCommand.Parameters.AddWithValue("@constante_elastica", r.Constante_Elastica);
                                rodaInsertCommand.Parameters.AddWithValue("@comprimento_braco", r.Comprimento_Braco);
                                rodaInsertCommand.Parameters.AddWithValue("@altura", r.Altura);
                                rodaInsertCommand.Parameters.AddWithValue("@curso_angular", r.Curso_Angular);

                                rodaInsertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        public void CarregarCalculo()
        {
            foreach(Roda r in rodas)
            {
                r.Visible = false;
            }

            string connectionString = Properties.Settings.Default.calculoSuspensaoConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand calculosSelectCommand = new SqlCommand("select c.id_calculo, c.peso_total, r.nome, r.distribuicao_peso, r.distancia_bitola, r.distancia_mola, r.comprimento_braco, r.altura from Calculos c join Rodas r on r.id_calculo = c.id_calculo where c.id_calculo = (SELECT IDENT_CURRENT('Calculos'));", connection))
                {
                    //calculosSelectCommand.Parameters.AddWithValue("@id_calculo", "(SELECT IDENT_CURRENT('Calculos'))");

                    using (SqlDataReader reader = calculosSelectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_calculo = reader.GetInt32(0);
                            double peso_total_from_db = reader.GetDouble(1);

                            Peso_Total = peso_total_from_db;

                            foreach(Roda r in rodas)
                            {
                                string nome_from_db = reader.GetString(2);
                                double distribuicao_peso_from_db = reader.GetDouble(3);
                                double distancia_bitola_from_db = reader.GetDouble(4);
                                double distancia_mola_from_db = reader.GetDouble(5);
                                double comprimento_braco_from_db = reader.GetDouble(6);
                                double altura_from_db = reader.GetDouble(7);

                                if(nome_from_db == r.Nome)
                                {
                                    r.Povoar(distribuicao_peso_from_db, distancia_bitola_from_db, distancia_mola_from_db, comprimento_braco_from_db, altura_from_db);
                                    r.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
