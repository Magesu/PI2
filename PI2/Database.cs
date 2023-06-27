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
    }
}
