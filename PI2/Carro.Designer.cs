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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBox_rodas_dianteiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.CheckBox_rodas_traseiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_peso_total = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roda1 = new PI2.Roda();
            this.roda2 = new PI2.Roda();
            this.roda3 = new PI2.Roda();
            this.roda4 = new PI2.Roda();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(3, 6);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 13);
            label11.TabIndex = 8;
            label11.Text = "Peso Total";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(634, 322);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(634, 40);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.CheckBox_rodas_dianteiras_assimetricas);
            this.flowLayoutPanel2.Controls.Add(this.CheckBox_rodas_traseiras_assimetricas);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(240, 8);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 23);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // CheckBox_rodas_dianteiras_assimetricas
            // 
            this.CheckBox_rodas_dianteiras_assimetricas.AutoSize = true;
            this.CheckBox_rodas_dianteiras_assimetricas.Location = new System.Drawing.Point(3, 3);
            this.CheckBox_rodas_dianteiras_assimetricas.Name = "CheckBox_rodas_dianteiras_assimetricas";
            this.CheckBox_rodas_dianteiras_assimetricas.Size = new System.Drawing.Size(168, 17);
            this.CheckBox_rodas_dianteiras_assimetricas.TabIndex = 16;
            this.CheckBox_rodas_dianteiras_assimetricas.Text = "Rodas Dianteiras Assimétricas";
            this.CheckBox_rodas_dianteiras_assimetricas.UseVisualStyleBackColor = true;
            this.CheckBox_rodas_dianteiras_assimetricas.CheckedChanged += new System.EventHandler(this.CheckBox_rodas_dianteiras_assimetricas_CheckedChanged);
            // 
            // CheckBox_rodas_traseiras_assimetricas
            // 
            this.CheckBox_rodas_traseiras_assimetricas.AutoSize = true;
            this.CheckBox_rodas_traseiras_assimetricas.Location = new System.Drawing.Point(177, 3);
            this.CheckBox_rodas_traseiras_assimetricas.Name = "CheckBox_rodas_traseiras_assimetricas";
            this.CheckBox_rodas_traseiras_assimetricas.Size = new System.Drawing.Size(164, 17);
            this.CheckBox_rodas_traseiras_assimetricas.TabIndex = 17;
            this.CheckBox_rodas_traseiras_assimetricas.Text = "Rodas Traseiras Assimétricas";
            this.CheckBox_rodas_traseiras_assimetricas.UseVisualStyleBackColor = true;
            this.CheckBox_rodas_traseiras_assimetricas.CheckedChanged += new System.EventHandler(this.CheckBox_rodas_traseiras_assimetricas_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(label11);
            this.panel1.Controls.Add(this.TextBox_peso_total);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 26);
            this.panel1.TabIndex = 13;
            // 
            // TextBox_peso_total
            // 
            this.TextBox_peso_total.Location = new System.Drawing.Point(63, 3);
            this.TextBox_peso_total.Name = "TextBox_peso_total";
            this.TextBox_peso_total.Size = new System.Drawing.Size(100, 20);
            this.TextBox_peso_total.TabIndex = 7;
            this.TextBox_peso_total.Text = "0,00";
            this.TextBox_peso_total.TextChanged += new System.EventHandler(this.TextBox_peso_total_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.roda1);
            this.flowLayoutPanel1.Controls.Add(this.roda2);
            this.flowLayoutPanel1.Controls.Add(this.roda3);
            this.flowLayoutPanel1.Controls.Add(this.roda4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 278);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // roda1
            // 
            this.roda1.Altura = 0F;
            this.roda1.Carro_Parente = null;
            this.roda1.Comprimento_Braco = 0F;
            this.roda1.Constante_Elastica = 0F;
            this.roda1.Curso_Angular = 0F;
            this.roda1.Distancia_Bitola = 0F;
            this.roda1.Distancia_Mola = 0F;
            this.roda1.Distribuicao_Peso = 0F;
            this.roda1.Eh_Par_Rodas = false;
            this.roda1.GroupBoxText = "roda1";
            this.roda1.Location = new System.Drawing.Point(3, 3);
            this.roda1.Name = "roda1";
            this.roda1.Peso = 0F;
            this.roda1.Size = new System.Drawing.Size(609, 175);
            this.roda1.TabIndex = 0;
            // 
            // roda2
            // 
            this.roda2.Altura = 0F;
            this.roda2.Carro_Parente = null;
            this.roda2.Comprimento_Braco = 0F;
            this.roda2.Constante_Elastica = 0F;
            this.roda2.Curso_Angular = 0F;
            this.roda2.Distancia_Bitola = 0F;
            this.roda2.Distancia_Mola = 0F;
            this.roda2.Distribuicao_Peso = 0F;
            this.roda2.Eh_Par_Rodas = false;
            this.roda2.GroupBoxText = "roda2";
            this.roda2.Location = new System.Drawing.Point(3, 184);
            this.roda2.Name = "roda2";
            this.roda2.Peso = 0F;
            this.roda2.Size = new System.Drawing.Size(609, 175);
            this.roda2.TabIndex = 1;
            // 
            // roda3
            // 
            this.roda3.Altura = 0F;
            this.roda3.Carro_Parente = null;
            this.roda3.Comprimento_Braco = 0F;
            this.roda3.Constante_Elastica = 0F;
            this.roda3.Curso_Angular = 0F;
            this.roda3.Distancia_Bitola = 0F;
            this.roda3.Distancia_Mola = 0F;
            this.roda3.Distribuicao_Peso = 0F;
            this.roda3.Eh_Par_Rodas = false;
            this.roda3.GroupBoxText = "roda3";
            this.roda3.Location = new System.Drawing.Point(3, 365);
            this.roda3.Name = "roda3";
            this.roda3.Peso = 0F;
            this.roda3.Size = new System.Drawing.Size(609, 175);
            this.roda3.TabIndex = 2;
            // 
            // roda4
            // 
            this.roda4.Altura = 0F;
            this.roda4.Carro_Parente = null;
            this.roda4.Comprimento_Braco = 0F;
            this.roda4.Constante_Elastica = 0F;
            this.roda4.Curso_Angular = 0F;
            this.roda4.Distancia_Bitola = 0F;
            this.roda4.Distancia_Mola = 0F;
            this.roda4.Distribuicao_Peso = 0F;
            this.roda4.Eh_Par_Rodas = false;
            this.roda4.GroupBoxText = "roda4";
            this.roda4.Location = new System.Drawing.Point(3, 546);
            this.roda4.Name = "roda4";
            this.roda4.Peso = 0F;
            this.roda4.Size = new System.Drawing.Size(609, 175);
            this.roda4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "id do cálculo";
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Carro";
            this.Size = new System.Drawing.Size(640, 341);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox CheckBox_rodas_dianteiras_assimetricas;
        private System.Windows.Forms.CheckBox CheckBox_rodas_traseiras_assimetricas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_peso_total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Roda roda1;
        private Roda roda2;
        private Roda roda3;
        private Roda roda4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
