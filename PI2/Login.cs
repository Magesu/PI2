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
    public partial class Login : Form
    {
        Calculadora calculadora;

        public Login(Calculadora calc)
        {
            InitializeComponent();
            this.calculadora = calc;
        }

        private void button_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.Show();
        }

        private void textBox_ra_TextChanged(object sender, EventArgs e)
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
            bool textBox_senha_filled = !string.IsNullOrWhiteSpace(textBox_senha.Text);

            if (textBox_ra_filled && textBox_senha_filled)
            {
                button_login.Enabled = true;
            }
            else
            {
                button_login.Enabled = false;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string ra = textBox_ra.Text;
            string senha = textBox_senha.Text;

            try
            {
                DataRow usuario = usuariosTableAdapter1.GetDataByRA(ra).Rows[0];

                if (usuario["passhash"].Equals(senha))
                {
                    calculadora.RA_Usuario_Logado = usuario["ra"].ToString();

                    string message = "Seja bem vindo, " + usuario["nome"] + "!";
                    DialogResult result = MessageBox.Show(message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Senha incorreta.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("RA não encontrado.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayErrorMessage(Exception ex)
        {
            MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
