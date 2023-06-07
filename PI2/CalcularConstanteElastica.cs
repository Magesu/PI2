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
    public partial class CalcularConstanteElastica : Form
    {
        public CalcularConstanteElastica()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            resultado.Value = CalculoSuspensao.CalcularConstanteElastica(F.Value, bd.Value, sd.Value);
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            ConstanteElasticaTableAdapter constanteElasticaTableAdapter = new ConstanteElasticaTableAdapter();
            constanteElasticaTableAdapter.Insert(1, F.Value, bd.Value, sd.Value, resultado.Value);
        }
    }
}
