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
        private Calculadora calculadora;
        private int id_equipe;

        public EquipeInfo(Calculadora calculadora)
        {
            InitializeComponent();

            this.calculadora = calculadora;

            DataRow alunoRow = alunosTableAdapter1.GetDataByRA(calculadora.RA_Usuario_Logado).Rows[0];

            id_equipe = (int) alunoRow["id_equipe"];
        }

        private void EquipeInfo_Load(object sender, EventArgs e)
        {
            AtualizarInfo();

            AtualizarTabelaParticipantes();

            DataRow alunoRow = alunosTableAdapter1.GetDataByRA(calculadora.RA_Usuario_Logado).Rows[0];

            if (alunoRow["cargo"].Equals("fundador"))
            {
                // Se usuário logado for fundador, habilita a opção de edição
                button_editar.Visible = true;
                tableLayoutPanel4.Visible = true;
            }
            else if (alunoRow["cargo"].Equals("participante"))
            {
                // Se for participante, não habilita a opção de edição
                button_editar.Visible = false;
                tableLayoutPanel4.Visible = false;
            }
        }

        private void button_adicionar_participante_Click(object sender, EventArgs e)
        {
            string ra_novo_participante = textBox_ra.Text;

            try
            {
                DataRow novo_participante_row = alunosTableAdapter1.GetDataByRA(ra_novo_participante).Rows[0];

                if (novo_participante_row.IsNull("id_equipe"))
                {
                    alunosTableAdapter1.UpdateAlunoEquipe(id_equipe, "participante", ra_novo_participante);
                    AtualizarTabelaParticipantes();
                }
                else
                { 
                    if (novo_participante_row["id_equipe"].Equals(id_equipe))
                    {
                        MessageBox.Show("Aluno já faz parte dessa equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Aluno já faz parte de outra equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("RA não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_remover_participante_Click(object sender, EventArgs e)
        {
            string ra_participante = textBox_ra.Text;

            if(calculadora.RA_Usuario_Logado == ra_participante)
            {
                MessageBox.Show("Aluno não pode se remover do grupo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataRow participanteRow = alunosTableAdapter1.GetDataByRA(ra_participante).Rows[0];

                    if (participanteRow["id_equipe"].Equals(id_equipe))
                    {
                        alunosTableAdapter1.UpdateAlunoEquipe(null, null, ra_participante);

                        AtualizarTabelaParticipantes();
                    }
                    else
                    {
                        MessageBox.Show("Aluno não faz parte dessa equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("RA não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizarTabelaParticipantes()
        {
            this.participantesTableAdapter.Fill(this.calculoSuspensaoDataSet.Participantes, id_equipe);
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            EditarEquipe editarEquipe = new EditarEquipe(this, id_equipe);

            editarEquipe.Show();
        }

        private void AtualizarInfo()
        {
            DataRow equipeRow = equipesTableAdapter1.GetDataByIDEquipe(id_equipe).Rows[0];

            num_carro.Text = equipeRow["num_carro"].ToString();
            nome_carro.Text = equipeRow["nome_carro"].ToString();
        }

        public void ForcarAtualizarInfo()
        {
            AtualizarInfo();
        }
    }
}
