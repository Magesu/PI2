using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PI2
{
    public partial class Roda : UserControl
    {
        private Carro carro_parente;
        public Carro Carro_Parente
        {
            get { return carro_parente; }
            set
            {
                carro_parente = value;
            }
        }
        private float distribuicao_peso;
        [Browsable(false)]
        public float Distribuicao_Peso
        {
            get { return distribuicao_peso; }
            set
            {
                distribuicao_peso = value;
                AtualizarPeso();
            }
        }
        private bool eh_par_rodas;
        public bool Eh_Par_Rodas
        {
            get { return eh_par_rodas; }
            set
            {
                eh_par_rodas = value;
                if (eh_par_rodas)
                {
                    AtualizarParaParRoda();
                }
                else
                {
                    AtualizarParaRodaUnica();
                }
                AtualizarConstanteElastica();
                AtualizarTextBoxes();
            }
        }
        private float peso;
        [Browsable(false)]
        public float Peso
        {
            get { return peso; }
            set
            {
                peso = value;
                AtualizarConstanteElastica();
            }
        }
        private float distancia_bitola;
        [Browsable(false)]
        public float Distancia_Bitola
        {
            get { return distancia_bitola; }
            set
            {
                distancia_bitola = value;
                AtualizarConstanteElastica();
            }
        }
        private float distancia_mola;
        [Browsable(false)]
        public float Distancia_Mola
        {
            get { return distancia_mola; }
            set
            {
                distancia_mola = value;
                AtualizarConstanteElastica();
            }
        }
        private float constante_elastica;
        [Browsable(false)]
        public float Constante_Elastica
        {
            get { return constante_elastica; }
            set
            {
                constante_elastica = value;
            }
        }
        private float comprimento_braco;
        [Browsable(false)]
        public float Comprimento_Braco
        {
            get { return comprimento_braco; }
            set
            {
                comprimento_braco = value;
                AtualizarCursoAngular();
            }
        }
        private float altura;
        [Browsable(false)]
        public float Altura
        {
            get { return altura; }
            set
            {
                altura = value;
                AtualizarCursoAngular();
            }
        }
        private float curso_angular;
        [Browsable(false)]
        public float Curso_Angular
        {
            get { return curso_angular; }
            set
            {
                curso_angular = value;
            }
        }
        [Browsable(true)]
        public string GroupBoxText
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }

        public Roda()
        {
            InitializeComponent();
        }

        private void TextBox_distribuicao_peso_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Distribuicao_Peso = parsedValue;
                }
                else
                {
                    Distribuicao_Peso = -1;
                }
            }
        }

        private void TextBox_distancia_bitola_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Distancia_Bitola = parsedValue;
                }
                else
                {
                    Distancia_Bitola = -1;
                }
            }
        }

        private void TextBox_distancia_mola_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Distancia_Mola = parsedValue;
                }
                else
                {
                    Distancia_Mola = -1;
                }
            }
        }

        private void TextBox_comprimento_braco_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Comprimento_Braco = parsedValue;
                }
                else
                {
                    Comprimento_Braco = -1;
                }
            }
        }

        private void TextBox_altura_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (float.TryParse(textBox.Text, out float parsedValue))
                {
                    Altura = parsedValue;
                }
                else
                {
                    Altura = -1;
                }
            }
        }

        private void AtualizarPeso()
        {
            try
            {
                if (Carro_Parente == null)
                {
                    throw new ArgumentNullException("Carro_Parente", "Objeto 'Carro_Parente' é nulo.");
                }

                float peso_total = Carro_Parente.Peso_Total;

                if (eh_par_rodas)
                {
                    Peso = ((peso_total * Distribuicao_Peso) / 100) / 2;
                }
                else
                {
                    Peso = (peso_total * Distribuicao_Peso) / 100;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ForcarAtualizarPeso()
        {
            AtualizarPeso();
        }

        private void AtualizarConstanteElastica()
        {
            try
            {
                if (Eh_Par_Rodas)
                {
                    Constante_Elastica = CalculoSuspensao.CalcularConstanteElastica(Peso, Distancia_Bitola / 2, (Distancia_Bitola / 2) - Distancia_Mola);
                }
                else
                {
                    Constante_Elastica = CalculoSuspensao.CalcularConstanteElastica(Peso, Distancia_Bitola, Distancia_Bitola - Distancia_Mola);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            TextBox_constante_elastica.Text = Constante_Elastica.ToString("F2");
        }

        private void AtualizarCursoAngular()
        {
            try
            {
                Curso_Angular = CalculoSuspensao.CalcularCursoAngular(Altura / 2, Comprimento_Braco);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            TextBox_curso_angular.Text = Curso_Angular.ToString("F2");
        }

        private void AtualizarParaParRoda()
        {
            label2.Text = "Comprimento da bitola";
            Distribuicao_Peso = Distribuicao_Peso * 2;
            Distancia_Bitola = Distancia_Bitola * 2;
        }

        private void AtualizarParaRodaUnica()
        {
            label2.Text = "Distância da bitola até o centro";
            Distribuicao_Peso = Distribuicao_Peso / 2;
            Distancia_Bitola = Distancia_Bitola / 2;
        }

        public void Povoar(Roda outro)
        {
            Eh_Par_Rodas = outro.Eh_Par_Rodas;
            Distribuicao_Peso = outro.Distribuicao_Peso;
            Distancia_Bitola = outro.Distancia_Bitola;
            Distancia_Mola = outro.Distancia_Mola;
            Comprimento_Braco = outro.Comprimento_Braco;
            Altura = outro.Altura;
            AtualizarTextBoxes();
        }

        public void Povoar(float dp, float db, float dm, float cb, float a, bool eh_par = false)
        {
            Eh_Par_Rodas = eh_par;
            Distribuicao_Peso = dp;
            Distancia_Bitola = db;
            Distancia_Mola = dm;
            Comprimento_Braco = cb;
            Altura = a;
            AtualizarTextBoxes();
        }

        private void AtualizarTextBoxes()
        {
            TextBox_distribuicao_peso.Text = Distribuicao_Peso.ToString("F2");
            TextBox_distancia_bitola.Text = Distancia_Bitola.ToString("F2");
            TextBox_distancia_mola.Text = Distancia_Mola.ToString("F2");
            TextBox_comprimento_braco.Text = Comprimento_Braco.ToString("F2");
            TextBox_altura.Text = Altura.ToString("F2");
        }
    }
}
