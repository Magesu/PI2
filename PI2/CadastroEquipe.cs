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
    public partial class CadastroEquipe : Form
    {
        public CadastroEquipe()
        {
            InitializeComponent();
        }

        private void cadastroEquipeButton_Click(object sender, EventArgs e)
        {
            EquipesTableAdapter equipesTableAdapter = new EquipesTableAdapter();
            equipesTableAdapter.Insert(Convert.ToInt32(numCarro.Value), nomeCarro.Text);
        }

        private void nomeCarroLabel_Click(object sender, EventArgs e)
        {

        }

        private void numCarroLabel_Click(object sender, EventArgs e)
        {

        }

        private void numCarro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nomeCarro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
