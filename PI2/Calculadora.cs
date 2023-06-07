﻿using PI2.calculoSuspensaoDataSetTableAdapters;
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

        private void cadastro_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();

            cadastroAluno.Show();
        }

        private void cadastroEquipe_Click(object sender, EventArgs e)
        {
            CadastroEquipe cadastroEquipe = new CadastroEquipe();

            cadastroEquipe.Show()
;        }

        private void constanteElasticaButton_Click(object sender, EventArgs e)
        {
            CalcularConstanteElastica calcularConstanteElastica = new CalcularConstanteElastica();

            calcularConstanteElastica.Show();
        }

        private void cursoAngularButton_Click(object sender, EventArgs e)
        {
            CalcularCursoAngular calcularCursoAngular = new CalcularCursoAngular();

            calcularCursoAngular.Show();
        }

        private void calcularConstanteElasticaButton_Click(object sender, EventArgs e)
        {
            resultadoConstanteElastica.Value = CalculoSuspensao.CalcularConstanteElastica(F.Value, bd.Value, sd.Value);
        }

        private void salvarConstanteElasticaButton_Click(object sender, EventArgs e)
        {
            ConstanteElasticaTableAdapter constanteElasticaTableAdapter = new ConstanteElasticaTableAdapter();
            constanteElasticaTableAdapter.Insert(1, F.Value, bd.Value, sd.Value, resultadoConstanteElastica.Value);

            MessageBox.Show("Resultado salvo.", "Salvar Constante Elástica", MessageBoxButtons.OK);
        }

        private void calcularCursoAngularButton_Click(object sender, EventArgs e)
        {
            resultadoCursoAngular.Value = CalculoSuspensao.RadianosParaGraus(CalculoSuspensao.CalcularCursoAngular(a.Value, b.Value));
        }

        private void salvarCursoAngularButton_Click(object sender, EventArgs e)
        {
            CursoAngularTableAdapter cursoAngularTableAdapter = new CursoAngularTableAdapter();
            cursoAngularTableAdapter.Insert(1, a.Value, b.Value, resultadoCursoAngular.Value);

            MessageBox.Show("Resultado salvo.", "Salvar Curso Angular", MessageBoxButtons.OK);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
