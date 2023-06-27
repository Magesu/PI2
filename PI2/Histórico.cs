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
    public partial class Histórico : Form
    {
        private List<Carro> carros = new List<Carro>();
        private int id_equipe;

        public Histórico(int id_eq)
        {
            InitializeComponent();

            id_equipe = id_eq;

            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);
        }

        public void CarregarHistorico()
        {
            DataTable calculosTable = calculosTableAdapter1.GetDataByIDEquipe(id_equipe);

            int i = 0;

            foreach(DataRow row in calculosTable.Rows)
            {
                if(i < 3)
                {
                    int id_calculo = (int)row[0];

                    carros.ElementAt(i).CarregarCalculo(id_calculo);
                    i++;
                }
            }
        }

        private void Histórico_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }
    }
}
