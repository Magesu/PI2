namespace PI2
{
    partial class Roda
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_distribuicao_peso = new System.Windows.Forms.TextBox();
            this.TextBox_distancia_bitola = new System.Windows.Forms.TextBox();
            this.TextBox_distancia_mola = new System.Windows.Forms.TextBox();
            this.TextBox_constante_elastica = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox_comprimento_braco = new System.Windows.Forms.TextBox();
            this.TextBox_altura = new System.Windows.Forms.TextBox();
            this.TextBox_curso_angular = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(17, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 13);
            label6.TabIndex = 3;
            label6.Text = "Comprimento do braço";
            label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(42, 48);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 13);
            label7.TabIndex = 4;
            label7.Text = "Altura até o chão";
            label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(57, 103);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(73, 13);
            label9.TabIndex = 5;
            label9.Text = "Curso Angular";
            label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(93, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 13);
            label1.TabIndex = 2;
            label1.Text = "Distribuição de peso";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(101, 100);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 13);
            label8.TabIndex = 2;
            label8.Text = "Constante Elástica";
            label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(11, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 13);
            label3.TabIndex = 2;
            label3.Text = "Distância da mola até a ponta do eixo";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distância da bitola até o centro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.TextBox_distribuicao_peso);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TextBox_distancia_bitola);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.TextBox_distancia_mola);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(this.TextBox_constante_elastica);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 137);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Constante Elástica";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TextBox_distribuicao_peso
            // 
            this.TextBox_distribuicao_peso.Location = new System.Drawing.Point(202, 19);
            this.TextBox_distribuicao_peso.Name = "TextBox_distribuicao_peso";
            this.TextBox_distribuicao_peso.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distribuicao_peso.TabIndex = 0;
            this.TextBox_distribuicao_peso.TextChanged += new System.EventHandler(this.TextBox_distribuicao_peso_TextChanged);
            // 
            // TextBox_distancia_bitola
            // 
            this.TextBox_distancia_bitola.Location = new System.Drawing.Point(202, 45);
            this.TextBox_distancia_bitola.Name = "TextBox_distancia_bitola";
            this.TextBox_distancia_bitola.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distancia_bitola.TabIndex = 1;
            this.TextBox_distancia_bitola.TextChanged += new System.EventHandler(this.TextBox_distancia_bitola_TextChanged);
            // 
            // TextBox_distancia_mola
            // 
            this.TextBox_distancia_mola.Location = new System.Drawing.Point(202, 71);
            this.TextBox_distancia_mola.Name = "TextBox_distancia_mola";
            this.TextBox_distancia_mola.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distancia_mola.TabIndex = 2;
            this.TextBox_distancia_mola.TextChanged += new System.EventHandler(this.TextBox_distancia_mola_TextChanged);
            // 
            // TextBox_constante_elastica
            // 
            this.TextBox_constante_elastica.Location = new System.Drawing.Point(202, 97);
            this.TextBox_constante_elastica.Name = "TextBox_constante_elastica";
            this.TextBox_constante_elastica.Size = new System.Drawing.Size(100, 20);
            this.TextBox_constante_elastica.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(label6);
            this.groupBox3.Controls.Add(this.TextBox_comprimento_braco);
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Controls.Add(this.TextBox_altura);
            this.groupBox3.Controls.Add(label9);
            this.groupBox3.Controls.Add(this.TextBox_curso_angular);
            this.groupBox3.Location = new System.Drawing.Point(373, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 137);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Curso Angular";
            // 
            // TextBox_comprimento_braco
            // 
            this.TextBox_comprimento_braco.Location = new System.Drawing.Point(136, 19);
            this.TextBox_comprimento_braco.Name = "TextBox_comprimento_braco";
            this.TextBox_comprimento_braco.Size = new System.Drawing.Size(100, 20);
            this.TextBox_comprimento_braco.TabIndex = 4;
            this.TextBox_comprimento_braco.TextChanged += new System.EventHandler(this.TextBox_comprimento_braco_TextChanged);
            // 
            // TextBox_altura
            // 
            this.TextBox_altura.Location = new System.Drawing.Point(136, 45);
            this.TextBox_altura.Name = "TextBox_altura";
            this.TextBox_altura.Size = new System.Drawing.Size(100, 20);
            this.TextBox_altura.TabIndex = 5;
            this.TextBox_altura.TextChanged += new System.EventHandler(this.TextBox_altura_TextChanged);
            // 
            // TextBox_curso_angular
            // 
            this.TextBox_curso_angular.Location = new System.Drawing.Point(136, 100);
            this.TextBox_curso_angular.Name = "TextBox_curso_angular";
            this.TextBox_curso_angular.Size = new System.Drawing.Size(100, 20);
            this.TextBox_curso_angular.TabIndex = 6;
            // 
            // Roda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Roda";
            this.Size = new System.Drawing.Size(657, 175);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBox_curso_angular;
        private System.Windows.Forms.TextBox TextBox_altura;
        private System.Windows.Forms.TextBox TextBox_comprimento_braco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_distribuicao_peso;
        private System.Windows.Forms.TextBox TextBox_distancia_bitola;
        private System.Windows.Forms.TextBox TextBox_constante_elastica;
        private System.Windows.Forms.TextBox TextBox_distancia_mola;
        private System.Windows.Forms.Label label2;
    }
}
