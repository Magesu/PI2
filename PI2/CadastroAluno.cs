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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void cadastroAlunoButton_Click(object sender, EventArgs e)
        {
            AlunosTableAdapter alunosTableAdapter = new AlunosTableAdapter();
            alunosTableAdapter.Insert(ra.Text, nome.Text, null);
        }
    }
}