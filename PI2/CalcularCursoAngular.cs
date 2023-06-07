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
    public partial class CalcularCursoAngular : Form
    {
        public CalcularCursoAngular()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            resultado.Value = CalculoSuspensao.RadianosParaGraus(CalculoSuspensao.CalcularCursoAngular(a.Value, b.Value));
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            CursoAngularTableAdapter cursoAngularTableAdapter = new CursoAngularTableAdapter();
            cursoAngularTableAdapter.Insert(1, a.Value, b.Value, resultado.Value);
        }
    }
}
