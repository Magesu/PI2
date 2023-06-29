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
            this.TextBox_distribuicao_peso = new System.Windows.Forms.TextBox();
            this.TextBox_distancia_bitola = new System.Windows.Forms.TextBox();
            this.TextBox_distancia_mola = new System.Windows.Forms.TextBox();
            this.TextBox_constante_elastica = new System.Windows.Forms.TextBox();
            this.TextBox_comprimento_braco = new System.Windows.Forms.TextBox();
            this.TextBox_altura = new System.Windows.Forms.TextBox();
            this.TextBox_curso_angular = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.Location = new System.Drawing.Point(3, 6);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(138, 13);
            label6.TabIndex = 3;
            label6.Text = "Comprimento do braço (mm)";
            label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label7.Location = new System.Drawing.Point(24, 32);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(117, 13);
            label7.TabIndex = 4;
            label7.Text = "Altura até o chão (mm)";
            label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label9.Location = new System.Drawing.Point(49, 84);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(92, 13);
            label9.TabIndex = 5;
            label9.Text = "Curso Angular (°)";
            label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.Location = new System.Drawing.Point(67, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 13);
            label1.TabIndex = 2;
            label1.Text = "Distribuição de peso (%)";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label8.Location = new System.Drawing.Point(59, 84);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(129, 13);
            label8.TabIndex = 2;
            label8.Text = "Constante Elástica (N)";
            label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.Location = new System.Drawing.Point(3, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 13);
            label3.TabIndex = 2;
            label3.Text = "Distância da mola até a ponta (mm)";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distância da bitola até o centro (mm)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBox_distribuicao_peso
            // 
            this.TextBox_distribuicao_peso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_distribuicao_peso.Location = new System.Drawing.Point(194, 3);
            this.TextBox_distribuicao_peso.Name = "TextBox_distribuicao_peso";
            this.TextBox_distribuicao_peso.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distribuicao_peso.TabIndex = 0;
            this.TextBox_distribuicao_peso.TextChanged += new System.EventHandler(this.TextBox_distribuicao_peso_TextChanged);
            // 
            // TextBox_distancia_bitola
            // 
            this.TextBox_distancia_bitola.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_distancia_bitola.Location = new System.Drawing.Point(194, 29);
            this.TextBox_distancia_bitola.Name = "TextBox_distancia_bitola";
            this.TextBox_distancia_bitola.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distancia_bitola.TabIndex = 1;
            this.TextBox_distancia_bitola.TextChanged += new System.EventHandler(this.TextBox_distancia_bitola_TextChanged);
            // 
            // TextBox_distancia_mola
            // 
            this.TextBox_distancia_mola.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_distancia_mola.Location = new System.Drawing.Point(194, 55);
            this.TextBox_distancia_mola.Name = "TextBox_distancia_mola";
            this.TextBox_distancia_mola.Size = new System.Drawing.Size(100, 20);
            this.TextBox_distancia_mola.TabIndex = 2;
            this.TextBox_distancia_mola.TextChanged += new System.EventHandler(this.TextBox_distancia_mola_TextChanged);
            // 
            // TextBox_constante_elastica
            // 
            this.TextBox_constante_elastica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_constante_elastica.Location = new System.Drawing.Point(194, 81);
            this.TextBox_constante_elastica.Name = "TextBox_constante_elastica";
            this.TextBox_constante_elastica.ReadOnly = true;
            this.TextBox_constante_elastica.Size = new System.Drawing.Size(100, 20);
            this.TextBox_constante_elastica.TabIndex = 3;
            // 
            // TextBox_comprimento_braco
            // 
            this.TextBox_comprimento_braco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_comprimento_braco.Location = new System.Drawing.Point(147, 3);
            this.TextBox_comprimento_braco.Name = "TextBox_comprimento_braco";
            this.TextBox_comprimento_braco.Size = new System.Drawing.Size(100, 20);
            this.TextBox_comprimento_braco.TabIndex = 4;
            this.TextBox_comprimento_braco.TextChanged += new System.EventHandler(this.TextBox_comprimento_braco_TextChanged);
            // 
            // TextBox_altura
            // 
            this.TextBox_altura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_altura.Location = new System.Drawing.Point(147, 29);
            this.TextBox_altura.Name = "TextBox_altura";
            this.TextBox_altura.Size = new System.Drawing.Size(100, 20);
            this.TextBox_altura.TabIndex = 5;
            this.TextBox_altura.TextChanged += new System.EventHandler(this.TextBox_altura_TextChanged);
            // 
            // TextBox_curso_angular
            // 
            this.TextBox_curso_angular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_curso_angular.Location = new System.Drawing.Point(147, 81);
            this.TextBox_curso_angular.Name = "TextBox_curso_angular";
            this.TextBox_curso_angular.ReadOnly = true;
            this.TextBox_curso_angular.Size = new System.Drawing.Size(100, 20);
            this.TextBox_curso_angular.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_constante_elastica, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_distancia_mola, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_distancia_bitola, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_distribuicao_peso, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(label9, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_curso_angular, 1, 3);
            this.tableLayoutPanel3.Controls.Add(label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_comprimento_braco, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_altura, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(352, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 104);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.MinimumSize = new System.Drawing.Size(0, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = " ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 150);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Constante Elástica";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(328, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Curso Angular";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.nomeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nomeLabel.Location = new System.Drawing.Point(10, 5);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(46, 20);
            this.nomeLabel.TabIndex = 9;
            this.nomeLabel.Text = "roda";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.nomeLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(657, 175);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // Roda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Roda";
            this.Size = new System.Drawing.Size(657, 175);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_curso_angular;
        private System.Windows.Forms.TextBox TextBox_altura;
        private System.Windows.Forms.TextBox TextBox_comprimento_braco;
        private System.Windows.Forms.TextBox TextBox_distribuicao_peso;
        private System.Windows.Forms.TextBox TextBox_distancia_bitola;
        private System.Windows.Forms.TextBox TextBox_constante_elastica;
        private System.Windows.Forms.TextBox TextBox_distancia_mola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
    }
}
