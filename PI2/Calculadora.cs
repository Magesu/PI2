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
        }

        private void Deslogar()
        {
            button_salvar.Enabled = false;
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

        private void button_carregar_Click(object sender, EventArgs e)
        {
            carro1.CarregarCalculo(2);
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.Show();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipeInfo equipeInfo = new EquipeInfo(this);

            equipeInfo.Show();
        }

        private void bemvindoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Seja bem vindo, " + RA_Usuario_Logado + "!";
            MessageBox.Show(message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
