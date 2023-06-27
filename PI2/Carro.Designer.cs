namespace PI2
{
    partial class Carro
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
            System.Windows.Forms.Label label11;
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBox_rodas_dianteiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.CheckBox_rodas_traseiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBox_peso_total = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.calculosTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter();
            this.rodasTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.RodasTableAdapter();
            this.roda1 = new PI2.Roda();
            this.roda2 = new PI2.Roda();
            this.roda3 = new PI2.Roda();
            this.roda4 = new PI2.Roda();
            this.roda5 = new PI2.Roda();
            this.roda6 = new PI2.Roda();
            label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.MenuText;
            label11.Location = new System.Drawing.Point(3, 6);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 13);
            label11.TabIndex = 8;
            label11.Text = "Peso Total";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(684, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.CheckBox_rodas_dianteiras_assimetricas);
            this.flowLayoutPanel2.Controls.Add(this.CheckBox_rodas_traseiras_assimetricas);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(272, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 23);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CheckBox_rodas_dianteiras_assimetricas
            // 
            this.CheckBox_rodas_dianteiras_assimetricas.AutoSize = true;
            this.CheckBox_rodas_dianteiras_assimetricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_rodas_dianteiras_assimetricas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CheckBox_rodas_dianteiras_assimetricas.Location = new System.Drawing.Point(3, 3);
            this.CheckBox_rodas_dianteiras_assimetricas.Name = "CheckBox_rodas_dianteiras_assimetricas";
            this.CheckBox_rodas_dianteiras_assimetricas.Size = new System.Drawing.Size(168, 17);
            this.CheckBox_rodas_dianteiras_assimetricas.TabIndex = 0;
            this.CheckBox_rodas_dianteiras_assimetricas.Text = "Rodas Dianteiras Assimétricas";
            this.CheckBox_rodas_dianteiras_assimetricas.UseVisualStyleBackColor = true;
            this.CheckBox_rodas_dianteiras_assimetricas.CheckedChanged += new System.EventHandler(this.CheckBox_Rodas_Dianteiras_Assimetricas_CheckedChanged);
            // 
            // CheckBox_rodas_traseiras_assimetricas
            // 
            this.CheckBox_rodas_traseiras_assimetricas.AutoSize = true;
            this.CheckBox_rodas_traseiras_assimetricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_rodas_traseiras_assimetricas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CheckBox_rodas_traseiras_assimetricas.Location = new System.Drawing.Point(177, 3);
            this.CheckBox_rodas_traseiras_assimetricas.Name = "CheckBox_rodas_traseiras_assimetricas";
            this.CheckBox_rodas_traseiras_assimetricas.Size = new System.Drawing.Size(164, 17);
            this.CheckBox_rodas_traseiras_assimetricas.TabIndex = 1;
            this.CheckBox_rodas_traseiras_assimetricas.Text = "Rodas Traseiras Assimétricas";
            this.CheckBox_rodas_traseiras_assimetricas.UseVisualStyleBackColor = true;
            this.CheckBox_rodas_traseiras_assimetricas.CheckedChanged += new System.EventHandler(this.CheckBox_Rodas_Traseiras_Assimetricas_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(label11);
            this.flowLayoutPanel3.Controls.Add(this.TextBox_peso_total);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(170, 26);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // TextBox_peso_total
            // 
            this.TextBox_peso_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_peso_total.Location = new System.Drawing.Point(67, 3);
            this.TextBox_peso_total.Name = "TextBox_peso_total";
            this.TextBox_peso_total.Size = new System.Drawing.Size(100, 20);
            this.TextBox_peso_total.TabIndex = 0;
            this.TextBox_peso_total.Text = "0,00";
            this.TextBox_peso_total.TextChanged += new System.EventHandler(this.TextBox_peso_total_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.roda1);
            this.flowLayoutPanel1.Controls.Add(this.roda2);
            this.flowLayoutPanel1.Controls.Add(this.roda3);
            this.flowLayoutPanel1.Controls.Add(this.roda4);
            this.flowLayoutPanel1.Controls.Add(this.roda5);
            this.flowLayoutPanel1.Controls.Add(this.roda6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 190);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nomeLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 266);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nomeLabel.Location = new System.Drawing.Point(3, 6);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(166, 24);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Id do cálculo : -1";
            // 
            // calculosTableAdapter1
            // 
            this.calculosTableAdapter1.ClearBeforeFill = true;
            // 
            // rodasTableAdapter1
            // 
            this.rodasTableAdapter1.ClearBeforeFill = true;
            // 
            // roda1
            // 
            this.roda1.Altura = 0D;
            this.roda1.Carro_Parente = null;
            this.roda1.Comprimento_Braco = 0D;
            this.roda1.Constante_Elastica = 0D;
            this.roda1.Curso_Angular = 0D;
            this.roda1.Distancia_Bitola = 0D;
            this.roda1.Distancia_Mola = 0D;
            this.roda1.Distribuicao_Peso = 0D;
            this.roda1.Eh_Par_Rodas = false;
            this.roda1.Location = new System.Drawing.Point(3, 3);
            this.roda1.Name = "roda1";
            this.roda1.Nome = "Roda Dianteira Direita";
            this.roda1.Peso = 0D;
            this.roda1.Size = new System.Drawing.Size(657, 175);
            this.roda1.TabIndex = 0;
            // 
            // roda2
            // 
            this.roda2.Altura = 0D;
            this.roda2.Carro_Parente = null;
            this.roda2.Comprimento_Braco = 0D;
            this.roda2.Constante_Elastica = 0D;
            this.roda2.Curso_Angular = 0D;
            this.roda2.Distancia_Bitola = 0D;
            this.roda2.Distancia_Mola = 0D;
            this.roda2.Distribuicao_Peso = 0D;
            this.roda2.Eh_Par_Rodas = false;
            this.roda2.Location = new System.Drawing.Point(3, 184);
            this.roda2.Name = "roda2";
            this.roda2.Nome = "Roda Dianteira Esquerda";
            this.roda2.Peso = 0D;
            this.roda2.Size = new System.Drawing.Size(657, 175);
            this.roda2.TabIndex = 1;
            // 
            // roda3
            // 
            this.roda3.Altura = 0D;
            this.roda3.Carro_Parente = null;
            this.roda3.Comprimento_Braco = 0D;
            this.roda3.Constante_Elastica = 0D;
            this.roda3.Curso_Angular = 0D;
            this.roda3.Distancia_Bitola = 0D;
            this.roda3.Distancia_Mola = 0D;
            this.roda3.Distribuicao_Peso = 0D;
            this.roda3.Eh_Par_Rodas = true;
            this.roda3.Location = new System.Drawing.Point(3, 365);
            this.roda3.Name = "roda3";
            this.roda3.Nome = "Rodas Dianteiras";
            this.roda3.Peso = 0D;
            this.roda3.Size = new System.Drawing.Size(657, 175);
            this.roda3.TabIndex = 2;
            // 
            // roda4
            // 
            this.roda4.Altura = 0D;
            this.roda4.Carro_Parente = null;
            this.roda4.Comprimento_Braco = 0D;
            this.roda4.Constante_Elastica = 0D;
            this.roda4.Curso_Angular = 0D;
            this.roda4.Distancia_Bitola = 0D;
            this.roda4.Distancia_Mola = 0D;
            this.roda4.Distribuicao_Peso = 0D;
            this.roda4.Eh_Par_Rodas = false;
            this.roda4.Location = new System.Drawing.Point(3, 546);
            this.roda4.Name = "roda4";
            this.roda4.Nome = "Roda Traseira Direita";
            this.roda4.Peso = 0D;
            this.roda4.Size = new System.Drawing.Size(657, 175);
            this.roda4.TabIndex = 3;
            // 
            // roda5
            // 
            this.roda5.Altura = 0D;
            this.roda5.Carro_Parente = null;
            this.roda5.Comprimento_Braco = 0D;
            this.roda5.Constante_Elastica = 0D;
            this.roda5.Curso_Angular = 0D;
            this.roda5.Distancia_Bitola = 0D;
            this.roda5.Distancia_Mola = 0D;
            this.roda5.Distribuicao_Peso = 0D;
            this.roda5.Eh_Par_Rodas = false;
            this.roda5.Location = new System.Drawing.Point(3, 727);
            this.roda5.Name = "roda5";
            this.roda5.Nome = "Roda Traseira Esquerda";
            this.roda5.Peso = 0D;
            this.roda5.Size = new System.Drawing.Size(657, 175);
            this.roda5.TabIndex = 4;
            // 
            // roda6
            // 
            this.roda6.Altura = 0D;
            this.roda6.Carro_Parente = null;
            this.roda6.Comprimento_Braco = 0D;
            this.roda6.Constante_Elastica = 0D;
            this.roda6.Curso_Angular = 0D;
            this.roda6.Distancia_Bitola = 0D;
            this.roda6.Distancia_Mola = 0D;
            this.roda6.Distribuicao_Peso = 0D;
            this.roda6.Eh_Par_Rodas = true;
            this.roda6.Location = new System.Drawing.Point(3, 908);
            this.roda6.Name = "roda6";
            this.roda6.Nome = "Rodas Traseiras";
            this.roda6.Peso = 0D;
            this.roda6.Size = new System.Drawing.Size(657, 175);
            this.roda6.TabIndex = 5;
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Carro";
            this.Size = new System.Drawing.Size(693, 266);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox CheckBox_rodas_dianteiras_assimetricas;
        private System.Windows.Forms.CheckBox CheckBox_rodas_traseiras_assimetricas;
        private System.Windows.Forms.TextBox TextBox_peso_total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Roda roda1;
        private Roda roda2;
        private Roda roda4;
        private Roda roda5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Roda roda3;
        private Roda roda6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nomeLabel;
        private calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter calculosTableAdapter1;
        private calculoSuspensaoDataSetTableAdapters.RodasTableAdapter rodasTableAdapter1;
    }
}
