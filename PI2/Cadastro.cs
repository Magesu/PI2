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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void DisplayErrorMessage(Exception ex)
        {
            MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string ra = textBox_ra.Text;
            string nome = textBox_nome.Text;
            string passhash = textBox_senha.Text;

            try
            {
                usuariosTableAdapter1.Insert(ra, nome, passhash);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex);
                return;
            }
            

            if (radioButton_aluno.Checked)
            {
                try
                {
                    alunosTableAdapter1.Insert(ra, null);
                }
                catch (Exception ex)
                {
                    DisplayErrorMessage(ex);
                    return;
                }
            }
            else if (radioButton_professor.Checked)
            {
                try
                {
                    professoresTableAdapter1.Insert(ra);
                }
                catch (Exception ex)
                {
                    DisplayErrorMessage(ex);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textBox_ra_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            bool textBox_ra_filled = !string.IsNullOrWhiteSpace(textBox_ra.Text);
            bool textBox_nome_filled = !string.IsNullOrWhiteSpace(textBox_nome.Text);
            bool textBox_senha_filled = !string.IsNullOrWhiteSpace(textBox_senha.Text);

            if(textBox_ra_filled && textBox_nome_filled && textBox_senha_filled)
            {
                button_cadastrar.Enabled = true;
            }
            else
            {
                button_cadastrar.Enabled = false;
            }
        }
    }
}
