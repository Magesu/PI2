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
    public partial class EquipeInfo : Form
    {
        private int id_equipe;

        public EquipeInfo(int id_e)
        {
            InitializeComponent();

            id_equipe = id_e;
        }

        private void EquipeInfo_Load(object sender, EventArgs e)
        {
            DataRow equipeRow = equipesTableAdapter1.GetDataByIDEquipe(id_equipe).Rows[0];

            num_carro.Text = equipeRow["num_carro"].ToString();
            nome_carro.Text = equipeRow["nome_carro"].ToString();

            AtualizarTabelaParticipantes();
        }

        private void button_adicionar_participante_Click(object sender, EventArgs e)
        {
            string ra_novo_participante = textBox_ra.Text;

            try
            {
                alunosTableAdapter1.UpdateIDEquipe(id_equipe, ra_novo_participante);

                AtualizarTabelaParticipantes();
            }
            catch (Exception)
            {
                MessageBox.Show("RA não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button_remover_participante_Click(object sender, EventArgs e)
        {
            string ra_participante = textBox_ra.Text;

            try
            {
                DataRow participanteRow = alunosTableAdapter1.GetDataByRA(ra_participante).Rows[0];

                if ((int) participanteRow["id_equipe"] == id_equipe)
                {
                    alunosTableAdapter1.UpdateIDEquipe(null, ra_participante);

                    AtualizarTabelaParticipantes();
                }
                else
                {
                    MessageBox.Show("Aluno não faz parte dessa equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("RA não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AtualizarTabelaParticipantes()
        {
            this.participantesTableAdapter.Fill(this.calculoSuspensaoDataSet.Participantes, id_equipe);
        }
    }
}
