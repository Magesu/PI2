using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI2
{
    public partial class EditarUsuario : Form
    {
        private string ra_usuario;

        public EditarUsuario(string ra)
        {
            InitializeComponent();

            ra_usuario = ra;
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_nome.Text))
            {
                button_alterar_nome.Enabled = true;
            }
            else
            {
                button_alterar_nome.Enabled = false;
            }
        }

        private void textBox_senha_atual_TextChanged(object sender, EventArgs e)
        {
            CheckSenhaTextBoxes();
        }

        private void textBox_senha_nova1_TextChanged(object sender, EventArgs e)
        {
            CheckSenhaTextBoxes();
        }

        private void textBox_senha_nova2_TextChanged(object sender, EventArgs e)
        {
            CheckSenhaTextBoxes();
        }

        private void CheckSenhaTextBoxes()
        {
            bool textBox_senha_atual_Filled = !string.IsNullOrWhiteSpace(textBox_senha_atual.Text);
            bool textBox_senha_nova1_Filled = !string.IsNullOrWhiteSpace(textBox_senha_nova1.Text);
            bool textBox_senha_nova2_Filled = !string.IsNullOrWhiteSpace(textBox_senha_nova2.Text);

            if (textBox_senha_atual_Filled && textBox_senha_nova1_Filled && textBox_senha_nova2_Filled)
            {
                button_alterar_senha.Enabled = true;
            }
            else
            {
                button_alterar_senha.Enabled = false;
            }
        }

        private void button_alterar_nome_Click(object sender, EventArgs e)
        {
            string novo_nome = textBox_nome.Text;

            usuariosTableAdapter1.UpdateNomeQuery(novo_nome, ra_usuario);

            MessageBox.Show("Nome alterado.", "Alterar nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_alterar_senha_Click(object sender, EventArgs e)
        {
            DataRow usuarioRow = usuariosTableAdapter1.GetDataByRA(ra_usuario).Rows[0];

            string passhash_atual = textBox_senha_atual.Text;

            if ((string) usuarioRow["passhash"] == passhash_atual)
            {
                string passhash_novo = textBox_senha_nova1.Text;
                string passhash_para_confirmar = textBox_senha_nova2.Text;

                if (passhash_novo == passhash_para_confirmar)
                {
                    usuariosTableAdapter1.UpdatePasshashQuery(passhash_novo, ra_usuario);

                    MessageBox.Show("Senha alterada.", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Confirmar senha é diferente da senha nova!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Senha atual incorreta!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
