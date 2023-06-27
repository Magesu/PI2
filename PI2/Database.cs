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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Rodas' table. You can move, or remove it, as needed.
            //this.rodasTableAdapter.Fill(this.calculoSuspensaoDataSet.Rodas);
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Calculos' table. You can move, or remove it, as needed.
            //this.calculosTableAdapter.Fill(this.calculoSuspensaoDataSet.Calculos);
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Equipes' table. You can move, or remove it, as needed.
            this.equipesTableAdapter.Fill(this.calculoSuspensaoDataSet.Equipes);
        }

        private void equipesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Checa se um index de linha válido foi clicado
            {
                DataGridViewRow linha_selecionada = equipesDataGridView.Rows[e.RowIndex];

                int id_equipe = Convert.ToInt32(linha_selecionada.Cells[0].Value);

                // Atualiza a tabela de participantes baseado no id_equipe selecionado
                UpdateParticipantesDataGridView(id_equipe);

                // Atualiza a tabela de calculos baseado no id_equipe selecionado
                UpdateCalculosDataGridView(id_equipe);
            }
        }

        private void UpdateParticipantesDataGridView(int id_equipe)
        {
            // Busca os participantes para a equipe selecionada usando o id_equipe
            DataTable participantesData = participantesTableAdapter.GetData(id_equipe);

            // Vincula participantesData com participantesDataGridView
            participantesDataGridView.DataSource = participantesData;
        }

        private void UpdateCalculosDataGridView(int id_equipe)
        {
            // Busca os cálculos da equipe selecionada usando o id_equipe
            DataTable calculosData = calculosTableAdapter.GetDataByIDEquipe(id_equipe);

            // Vincula calculosData com calculosDataGridView
            calculosDataGridView.DataSource = calculosData;
        }

        private void calculosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Checa se um index de linha válido foi clicado
            {
                DataGridViewRow linha_selecionada = calculosDataGridView.Rows[e.RowIndex];

                int id_calculo = Convert.ToInt32(linha_selecionada.Cells[0].Value);

                // Atualiza a tabela de rodas baseado no id_calculo selecionado
                UpdateRodasDataGridView(id_calculo);
            }
        }

        private void UpdateRodasDataGridView(int id_calculo)
        {
            DataTable rodasData = rodasTableAdapter.GetDataByIDCalculo(id_calculo);

            // Vincula rodasData com rodasDataGridView
            rodasDataGridView.DataSource = rodasData;
        }

        private void textBox_id_equipe_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_id_equipe.Text))
            {
                button_remover.Enabled = false;
            }
            else
            {
                button_remover.Enabled = true;
            }
        }

        private void button_remover_Click(object sender, EventArgs e)
        {
            int id_equipe = Convert.ToInt32(textBox_id_equipe.Text);

            DataTable equipeData = equipesTableAdapter.GetDataByIDEquipe(id_equipe);

            if(equipeData.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir essa equipe e seu histórico de cálculos?\nObserve que os alunos participantes não serão excluídos.", "Excluir equipe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Define que os participantes estão em nenhuma equipe
                    DataTable participantesTable = alunosTableAdapter1.GetDataByIDEquipe(id_equipe);

                    foreach (DataRow row in participantesTable.Rows)
                    {
                        alunosTableAdapter1.UpdateAlunoEquipe(null, null, (string)row["ra_aluno"]);
                    }

                    // Exclui cálculos
                    DataTable calculosTable = calculosTableAdapter.GetDataByIDEquipe(id_equipe);

                    foreach (DataRow row in calculosTable.Rows)
                    {
                        int id_calculo = (int)row["id_calculo"];

                        DataTable rodasTable = rodasTableAdapter.GetDataByIDCalculo(id_calculo);

                        rodasTableAdapter.DeleteQuery(id_calculo);

                        calculosTableAdapter.DeleteQuery(id_calculo);
                    }

                    // Exclui a equipe
                    equipesTableAdapter.DeleteQuery(id_equipe);

                    // Atualiza a tabela de equipes
                    this.equipesTableAdapter.Fill(this.calculoSuspensaoDataSet.Equipes);

                    // Deixa as outras tabelas vazias
                    DataTable dataTableVazia = new DataTable();

                    participantesDataGridView.DataSource = dataTableVazia;

                    calculosDataGridView.DataSource = dataTableVazia;

                    rodasDataGridView.DataSource = dataTableVazia;
                }
            }
            else
            {
                MessageBox.Show("Equipe não encontrada.", "Excluir equipe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
