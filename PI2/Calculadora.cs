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
        private string ra_usuario_logado;
        public string RA_Usuario_Logado 
        {
            get { return ra_usuario_logado; }
            set
            {
                ra_usuario_logado = value;
                if(ra_usuario_logado == null)
                {
                    Deslogar();
                }
                else
                {
                    Logar();
                }
            }
        }

        private void Logar()
        {
            button_salvar.Enabled = true;
            Atualizar();
        }

        private void Deslogar()
        {
            button_salvar.Enabled = false;
            Atualizar();
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow alunoRow = alunosTableAdapter1.GetDataByRA(RA_Usuario_Logado).Rows[0];

                if (!alunoRow.IsNull("id_equipe"))
                {
                    int id_equipe = (int)alunoRow["id_equipe"];

                    carro1.SalvarCalculo(id_equipe);
                    MessageBox.Show("Resultado salvo.", "Salvar resultado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Aluno não pertence a uma equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);

            login.Show();
        }

        private void históricoDeCálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow alunoRow = alunosTableAdapter1.GetDataByRA(RA_Usuario_Logado).Rows[0];

                if (!alunoRow.IsNull("id_equipe"))
                {
                    int id_equipe = (int)alunoRow["id_equipe"];

                    Histórico histórico = new Histórico(id_equipe);

                    histórico.Show();
                }
                else
                {
                    MessageBox.Show("Aluno não pertence a uma equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipeInfo equipeInfo = new EquipeInfo(this);

            equipeInfo.Show();
        }

        private void criarEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarEquipe criarEquipe = new CriarEquipe(this);

            criarEquipe.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           RA_Usuario_Logado = null;
        }

        private void Atualizar()
        {
            if(RA_Usuario_Logado == null)
            {
                button_salvar.Enabled = false;
                usuarioToolStripMenuItem.Visible = false;
                equipeToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Visible = true;
            }
            else
            {
                usuarioToolStripMenuItem.Visible = true;
                loginToolStripMenuItem.Visible = false;

                DataRow alunoRow = alunosTableAdapter1.GetDataByRA(RA_Usuario_Logado).Rows[0];

                if (alunoRow.IsNull("id_equipe"))
                {
                    button_salvar.Enabled = false;
                    criarEquipeToolStripMenuItem.Visible = true;
                    equipeToolStripMenuItem.Visible = false;
                }
                else
                {
                    button_salvar.Enabled = true;
                    criarEquipeToolStripMenuItem.Visible = false;
                    equipeToolStripMenuItem.Visible = true;
                }
            }
        }

        public void ForcarAtualizar()
        {
            Atualizar();
        }
    }
}
