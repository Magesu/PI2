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
    public partial class EditarEquipe : Form
    {
        private EquipeInfo equipeInfo;
        private int id_equipe;

        public EditarEquipe(EquipeInfo eq_info, int id_eq)
        {
            InitializeComponent();

            equipeInfo = eq_info;
            id_equipe = id_eq;
        }

        private void EditarEquipe_Load(object sender, EventArgs e)
        {
            DataRow equipeRow = equipesTableAdapter1.GetDataByIDEquipe(id_equipe).Rows[0];

            textBox_num_carro.Text = equipeRow["num_carro"].ToString();
            textBox_nome_carro.Text = equipeRow["nome_carro"].ToString();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                int num_carro = Convert.ToInt32(textBox_num_carro.Text);
                string nome_carro = textBox_nome_carro.Text;

                if (num_carro >= 0 && num_carro <= 99)
                {
                    equipesTableAdapter1.UpdateQuery(num_carro, nome_carro, id_equipe);

                    DialogResult result = MessageBox.Show("Mudanças salvas!", "Editar equipe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Número de carro inválido. Número de carro deve ser um número entre 0 e 99.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (textBox_num_carro_Filled && textBox_nome_carro_Filled)
            {
                button_salvar.Enabled = true;
            }
            else
            {
                button_salvar.Enabled = false;
            }
        }

        private void EditarEquipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            equipeInfo.ForcarAtualizarInfo();
        }
    }
}
