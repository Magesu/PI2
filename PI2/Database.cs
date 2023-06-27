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
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Calculos' table. You can move, or remove it, as needed.
            this.calculosTableAdapter.Fill(this.calculoSuspensaoDataSet.Calculos);
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Equipes' table. You can move, or remove it, as needed.
            this.equipesTableAdapter.Fill(this.calculoSuspensaoDataSet.Equipes);
        }

        private void equipesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow linha_selecionada = equipesDataGridView.Rows[e.RowIndex];

                int id_equipe = Convert.ToInt32(linha_selecionada.Cells[0].Value);

                // Update the participants table based on the selected team ID
                UpdateParticipantesDataGridView(id_equipe);


                UpdateCalculosDataGridView(id_equipe);
            }
        }

        private void UpdateParticipantesDataGridView(int id_equipe)
        {
            // Retrieve the participants for the selected team using the teamID
            DataTable participantesData = participantesTableAdapter.GetData(id_equipe);

            // Bind the participantsData to the Participants Data Grid View
            participantesDataGridView.DataSource = participantesData;
        }

        private void UpdateCalculosDataGridView(int id_equipe)
        {
            // Retrieve the participants for the selected team using the teamID
            DataTable calculosData = calculosTableAdapter.GetDataByIDEquipe(id_equipe);

            // Bind the participantsData to the Participants Data Grid View
            participantesDataGridView.DataSource = calculosData;
        }
    }
}
