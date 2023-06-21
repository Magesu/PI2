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
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            carro1.SalvarCalculo();
            MessageBox.Show("Resultado salvo.", "Salvar resultado", MessageBoxButtons.OK);
        }

        private void button_carregar_Click(object sender, EventArgs e)
        {
            carro1.CarregarCalculo();
        }
    }
}
