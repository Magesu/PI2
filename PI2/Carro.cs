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
            if (Rodas_Dianteiras_Assimetricas)
            {
                rodas.ElementAt(1).Visible = true;
                rodas.ElementAt(0).GroupBoxText = "Roda Dianteira Direita";
                rodas.ElementAt(1).GroupBoxText = "Roda Dianteira Esquerda";
                rodas.ElementAt(0).Eh_Par_Rodas = false;
                rodas.ElementAt(1).Povoar(rodas.ElementAt(0));
            }
            else
            {
                rodas.ElementAt(1).Visible = false;
                rodas.ElementAt(0).GroupBoxText = "Rodas Dianteiras";
                rodas.ElementAt(0).Eh_Par_Rodas = true;
            }

            if (Rodas_Traseiras_Assimetricas)
            {
                rodas.ElementAt(3).Visible = true;
                rodas.ElementAt(2).GroupBoxText = "Roda Traseira Direita";
                rodas.ElementAt(3).GroupBoxText = "Roda Traseira Esquerda";
                rodas.ElementAt(2).Eh_Par_Rodas = false;
                rodas.ElementAt(3).Povoar(rodas.ElementAt(2));
            }
            else
            {
                rodas.ElementAt(3).Visible = false;
                rodas.ElementAt(2).GroupBoxText = "Rodas Traseiras";
                rodas.ElementAt(2).Eh_Par_Rodas = true;
            }
        }
        
        public void SalvarCalculo()
        {
            

            string connectionString = Properties.Settings.Default.calculoSuspensaoConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand calculosInsertCommand = new SqlCommand("INSERT INTO Calculos(id_equipe, peso_total, rodas_dianteiras_assimetricas, rodas_traseiras_assimetricas) VALUES (@id_equipe, @peso_total, @rodas_dianteiras_assimetricas, @rodas_traseiras_assimetricas); SELECT SCOPE_IDENTITY();", connection))
                {
                    calculosInsertCommand.Parameters.AddWithValue("@id_equipe", 1);
                    calculosInsertCommand.Parameters.AddWithValue("@peso_total", Peso_Total);
                    calculosInsertCommand.Parameters.AddWithValue("@rodas_dianteiras_assimetricas", Rodas_Dianteiras_Assimetricas);
                    calculosInsertCommand.Parameters.AddWithValue("@rodas_traseiras_assimetricas", Rodas_Traseiras_Assimetricas);

                    int id_calculo = Convert.ToInt32(calculosInsertCommand.ExecuteScalar());

                    foreach(Roda r in rodas)
                    {
                        if (r.Visible)
                        {
                            using (SqlCommand rodaInsertCommand = new SqlCommand("INSERT INTO Rodas VALUES(@id_calculo, @nome, @distribuicao_peso, @distancia_bitola, @distancia_mola, @constante_elastica, @comprimento_braco, @altura, @curso_angular)", connection))
                            {
                                rodaInsertCommand.Parameters.AddWithValue("@id_calculo", id_calculo);
                                rodaInsertCommand.Parameters.AddWithValue("@nome", r.GroupBoxText);
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
            string connectionString = Properties.Settings.Default.calculoSuspensaoConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand calculosSelectCommand = new SqlCommand("select c.id_calculo, c.peso_total, r.distribuicao_peso, r.distancia_bitola, r.distancia_mola, r.comprimento_braco, r.altura from Calculos c join Rodas r on r.id_calculo = c.id_calculo where c.id_calculo = (SELECT IDENT_CURRENT('Calculos'));", connection))
                {
                    //calculosSelectCommand.Parameters.AddWithValue("@id_calculo", "(SELECT IDENT_CURRENT('Calculos'))");

                    using (SqlDataReader reader = calculosSelectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id_calculo = reader.GetInt32(0);
                            Console.WriteLine(reader.GetValue(1).GetType());
                            Console.WriteLine("Batata");
                            float peso_total_from_db = reader.GetFloat(1);

                            Peso_Total = peso_total_from_db;

                            int rodaIndex = 0;

                            while (rodaIndex < rodas.Count)
                            {
                                float distribuicao_peso_from_db = reader.GetFloat(2);
                                float distancia_bitola_from_db = reader.GetFloat(3);
                                float distancia_mola_from_db = reader.GetFloat(4);
                                float comprimento_braco_from_db = reader.GetFloat(5);
                                float altura_from_db = reader.GetFloat(6);

                                rodas[rodaIndex].Povoar(distribuicao_peso_from_db, distancia_bitola_from_db, distancia_mola_from_db, comprimento_braco_from_db, altura_from_db);

                                rodaIndex++;
                            }
                        }
                    }
                }
            }
        }
    }
}
