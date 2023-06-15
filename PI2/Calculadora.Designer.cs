namespace PI2
{
    partial class Calculadora
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label11;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roda1 = new PI2.Roda();
            this.roda2 = new PI2.Roda();
            this.roda3 = new PI2.Roda();
            this.roda4 = new PI2.Roda();
            this.panel1 = new System.Windows.Forms.Panel();
            this.peso_total = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rodas_dianteiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.rodas_traseiras_assimetricas = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            label11 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(263, 445);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 401);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // roda1
            // 
            this.roda1.Altura = 0D;
            this.roda1.Comprimento_Braco = 0D;
            this.roda1.Constante_Elastica = 0D;
            this.roda1.Curso_Angular = 0D;
            this.roda1.Distancia_Bitola = 0D;
            this.roda1.Distancia_Mola = 0D;
            this.roda1.Distribuicao_Peso = 0D;
            this.roda1.GroupBoxText = "roda1";
            this.roda1.Location = new System.Drawing.Point(3, 3);
            this.roda1.Name = "roda1";
            this.roda1.Peso = 0D;
            this.roda1.Peso_Total = 0D;
            this.roda1.Size = new System.Drawing.Size(609, 175);
            this.roda1.TabIndex = 0;
            // 
            // roda2
            // 
            this.roda2.Altura = 0D;
            this.roda2.Comprimento_Braco = 0D;
            this.roda2.Constante_Elastica = 0D;
            this.roda2.Curso_Angular = 0D;
            this.roda2.Distancia_Bitola = 0D;
            this.roda2.Distancia_Mola = 0D;
            this.roda2.Distribuicao_Peso = 0D;
            this.roda2.GroupBoxText = "roda2";
            this.roda2.Location = new System.Drawing.Point(3, 184);
            this.roda2.Name = "roda2";
            this.roda2.Peso = 0D;
            this.roda2.Peso_Total = 0D;
            this.roda2.Size = new System.Drawing.Size(609, 175);
            this.roda2.TabIndex = 1;
            // 
            // roda3
            // 
            this.roda3.Altura = 0D;
            this.roda3.Comprimento_Braco = 0D;
            this.roda3.Constante_Elastica = 0D;
            this.roda3.Curso_Angular = 0D;
            this.roda3.Distancia_Bitola = 0D;
            this.roda3.Distancia_Mola = 0D;
            this.roda3.Distribuicao_Peso = 0D;
            this.roda3.GroupBoxText = "roda3";
            this.roda3.Location = new System.Drawing.Point(3, 365);
            this.roda3.Name = "roda3";
            this.roda3.Peso = 0D;
            this.roda3.Peso_Total = 0D;
            this.roda3.Size = new System.Drawing.Size(609, 175);
            this.roda3.TabIndex = 2;
            // 
            // roda4
            // 
            this.roda4.Altura = 0D;
            this.roda4.Comprimento_Braco = 0D;
            this.roda4.Constante_Elastica = 0D;
            this.roda4.Curso_Angular = 0D;
            this.roda4.Distancia_Bitola = 0D;
            this.roda4.Distancia_Mola = 0D;
            this.roda4.Distribuicao_Peso = 0D;
            this.roda4.GroupBoxText = "roda4";
            this.roda4.Location = new System.Drawing.Point(3, 546);
            this.roda4.Name = "roda4";
            this.roda4.Peso = 0D;
            this.roda4.Peso_Total = 0D;
            this.roda4.Size = new System.Drawing.Size(609, 175);
            this.roda4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(label11);
            this.panel1.Controls.Add(this.peso_total);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 26);
            this.panel1.TabIndex = 13;
            // 
            // peso_total
            // 
            this.peso_total.Location = new System.Drawing.Point(63, 3);
            this.peso_total.Name = "peso_total";
            this.peso_total.Size = new System.Drawing.Size(100, 20);
            this.peso_total.TabIndex = 7;
            this.peso_total.TextChanged += new System.EventHandler(this.peso_total_TextChanged);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(636, 40);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.rodas_dianteiras_assimetricas);
            this.flowLayoutPanel2.Controls.Add(this.rodas_traseiras_assimetricas);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(241, 8);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 23);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // rodas_dianteiras_assimetricas
            // 
            this.rodas_dianteiras_assimetricas.AutoSize = true;
            this.rodas_dianteiras_assimetricas.Location = new System.Drawing.Point(3, 3);
            this.rodas_dianteiras_assimetricas.Name = "rodas_dianteiras_assimetricas";
            this.rodas_dianteiras_assimetricas.Size = new System.Drawing.Size(168, 17);
            this.rodas_dianteiras_assimetricas.TabIndex = 16;
            this.rodas_dianteiras_assimetricas.Text = "Rodas Dianteiras Assimétricas";
            this.rodas_dianteiras_assimetricas.UseVisualStyleBackColor = true;
            this.rodas_dianteiras_assimetricas.CheckedChanged += new System.EventHandler(this.rodas_dianteiras_assimetricas_CheckedChanged);
            // 
            // rodas_traseiras_assimetricas
            // 
            this.rodas_traseiras_assimetricas.AutoSize = true;
            this.rodas_traseiras_assimetricas.Location = new System.Drawing.Point(177, 3);
            this.rodas_traseiras_assimetricas.Name = "rodas_traseiras_assimetricas";
            this.rodas_traseiras_assimetricas.Size = new System.Drawing.Size(164, 17);
            this.rodas_traseiras_assimetricas.TabIndex = 17;
            this.rodas_traseiras_assimetricas.Text = "Rodas Traseiras Assimétricas";
            this.rodas_traseiras_assimetricas.UseVisualStyleBackColor = true;
            this.rodas_traseiras_assimetricas.CheckedChanged += new System.EventHandler(this.rodas_traseiras_assimetricas_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(903, 445);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(636, 445);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 0;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 445);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(18000, -18000);
            this.MinimumSize = new System.Drawing.Size(836, 260);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox peso_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Roda roda1;
        private Roda roda2;
        private Roda roda3;
        private Roda roda4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox rodas_dianteiras_assimetricas;
        private System.Windows.Forms.CheckBox rodas_traseiras_assimetricas;
    }
}