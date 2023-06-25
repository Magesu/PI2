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
    public partial class EquipeInfo : Form
    {
        private int id_equipe;

        public EquipeInfo(int id_e)
        {
            InitializeComponent();

            id_equipe = id_e;

            string filter = string.Format("id_equipe = {0}", id_equipe);

            DataRow[] equipe_data = equipesTableAdapter.GetData().Select(filter);

            num_carro.Text = equipe_data[0]["num_carro"].ToString();
            nome_carro.Text = equipe_data[0]["nome_carro"].ToString();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calculoSuspensaoDataSet);

        }

        private void alunosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calculoSuspensaoDataSet);

        }

        private void alunosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calculoSuspensaoDataSet);

        }

        private void EquipeInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculoSuspensaoDataSet.Alunos' table. You can move, or remove it, as needed.
            //this.alunosTableAdapter.FillBy(this.calculoSuspensaoDataSet.Alunos, id_equipe);
        }
    }
}
