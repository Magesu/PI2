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
    public partial class CriarEquipe : Form
    {
        Calculadora calculadora;

        public CriarEquipe(Calculadora calc)
        {
            InitializeComponent();
            this.calculadora = calc;
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            int num_carro;
            string nome_carro = textBox_nome_carro.Text;

            try
            {
                num_carro = int.Parse(textBox_num_carro.Text);

                if(num_carro >= 0 && num_carro <= 99)
                {
                    int id_equipe = (int) equipesTableAdapter1.InsertQuery(num_carro, nome_carro);

                    DataRow alunoRow = alunosTableAdapter1.GetDataByRA(calculadora.RA_Usuario_Logado).Rows[0];

                    alunoRow["id_equipe"] = id_equipe;

                    alunosTableAdapter1.Update(alunoRow);

                    DialogResult result = MessageBox.Show("Nova equipe criada com sucesso!", "Criar equipe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Número de carro inválido. Número de carro deve ser um número entre 0 e 99.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Número de carro inválido. Número de carro deve ser um número entre 0 e 99.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox_num_carro_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBox_nome_carro_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            bool textBox_num_carro_Filled = !string.IsNullOrWhiteSpace(textBox_num_carro.Text);
            bool textBox_nome_carro_Filled = !string.IsNullOrWhiteSpace(textBox_nome_carro.Text);

            if(textBox_num_carro_Filled && textBox_nome_carro_Filled)
            {
                button_criar.Enabled = true;
            }
            else
            {
                button_criar.Enabled = false;
            }
        }
    }
}
