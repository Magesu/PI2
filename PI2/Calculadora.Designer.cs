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
            this.cadastroAluno = new System.Windows.Forms.Button();
            this.cadastroEquipe = new System.Windows.Forms.Button();
            this.constanteElasticaButton = new System.Windows.Forms.Button();
            this.cursoAngularButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.salvarConstanteElasticaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoConstanteElastica = new System.Windows.Forms.NumericUpDown();
            this.calcularConstanteElasticaButton = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.NumericUpDown();
            this.bd = new System.Windows.Forms.NumericUpDown();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.NumericUpDown();
            this.bdLabel = new System.Windows.Forms.Label();
            this.FLabel = new System.Windows.Forms.Label();
            this.sdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarCursoAngularButton = new System.Windows.Forms.Button();
            this.resultadoCursoAngular = new System.Windows.Forms.NumericUpDown();
            this.calcularCursoAngularButton = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoConstanteElastica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoCursoAngular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroAluno
            // 
            this.cadastroAluno.Location = new System.Drawing.Point(296, 141);
            this.cadastroAluno.Name = "cadastroAluno";
            this.cadastroAluno.Size = new System.Drawing.Size(167, 23);
            this.cadastroAluno.TabIndex = 0;
            this.cadastroAluno.Text = "Cadastrar";
            this.cadastroAluno.UseVisualStyleBackColor = true;
            this.cadastroAluno.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // cadastroEquipe
            // 
            this.cadastroEquipe.Location = new System.Drawing.Point(296, 170);
            this.cadastroEquipe.Name = "cadastroEquipe";
            this.cadastroEquipe.Size = new System.Drawing.Size(167, 23);
            this.cadastroEquipe.TabIndex = 1;
            this.cadastroEquipe.Text = "Cadastrar equipe";
            this.cadastroEquipe.UseVisualStyleBackColor = true;
            this.cadastroEquipe.Click += new System.EventHandler(this.cadastroEquipe_Click);
            // 
            // constanteElasticaButton
            // 
            this.constanteElasticaButton.Location = new System.Drawing.Point(296, 199);
            this.constanteElasticaButton.Name = "constanteElasticaButton";
            this.constanteElasticaButton.Size = new System.Drawing.Size(167, 23);
            this.constanteElasticaButton.TabIndex = 2;
            this.constanteElasticaButton.Text = "Calcular Constante Elástica";
            this.constanteElasticaButton.UseVisualStyleBackColor = true;
            this.constanteElasticaButton.Click += new System.EventHandler(this.constanteElasticaButton_Click);
            // 
            // cursoAngularButton
            // 
            this.cursoAngularButton.Location = new System.Drawing.Point(296, 228);
            this.cursoAngularButton.Name = "cursoAngularButton";
            this.cursoAngularButton.Size = new System.Drawing.Size(167, 23);
            this.cursoAngularButton.TabIndex = 3;
            this.cursoAngularButton.Text = "Calcular Curso Angular";
            this.cursoAngularButton.UseVisualStyleBackColor = true;
            this.cursoAngularButton.Click += new System.EventHandler(this.cursoAngularButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.fazerLoginToolStripMenuItem,
            this.cadastrarEquipeToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // fazerLoginToolStripMenuItem
            // 
            this.fazerLoginToolStripMenuItem.Name = "fazerLoginToolStripMenuItem";
            this.fazerLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerLoginToolStripMenuItem.Text = "Login";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.salvarConstanteElasticaButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.resultadoConstanteElastica);
            this.splitContainer1.Panel1.Controls.Add(this.calcularConstanteElasticaButton);
            this.splitContainer1.Panel1.Controls.Add(this.F);
            this.splitContainer1.Panel1.Controls.Add(this.bd);
            this.splitContainer1.Panel1.Controls.Add(this.resultadoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.sd);
            this.splitContainer1.Panel1.Controls.Add(this.bdLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FLabel);
            this.splitContainer1.Panel1.Controls.Add(this.sdLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.salvarCursoAngularButton);
            this.splitContainer1.Panel2.Controls.Add(this.resultadoCursoAngular);
            this.splitContainer1.Panel2.Controls.Add(this.calcularCursoAngularButton);
            this.splitContainer1.Panel2.Controls.Add(this.a);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.b);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 0;
            // 
            // salvarConstanteElasticaButton
            // 
            this.salvarConstanteElasticaButton.Location = new System.Drawing.Point(169, 296);
            this.salvarConstanteElasticaButton.Name = "salvarConstanteElasticaButton";
            this.salvarConstanteElasticaButton.Size = new System.Drawing.Size(75, 23);
            this.salvarConstanteElasticaButton.TabIndex = 20;
            this.salvarConstanteElasticaButton.Text = "Salvar";
            this.salvarConstanteElasticaButton.UseVisualStyleBackColor = true;
            this.salvarConstanteElasticaButton.Click += new System.EventHandler(this.salvarConstanteElasticaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Calcular Constante Elástica";
            // 
            // resultadoConstanteElastica
            // 
            this.resultadoConstanteElastica.DecimalPlaces = 2;
            this.resultadoConstanteElastica.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.resultadoConstanteElastica.Location = new System.Drawing.Point(152, 204);
            this.resultadoConstanteElastica.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.resultadoConstanteElastica.Name = "resultadoConstanteElastica";
            this.resultadoConstanteElastica.ReadOnly = true;
            this.resultadoConstanteElastica.Size = new System.Drawing.Size(120, 20);
            this.resultadoConstanteElastica.TabIndex = 18;
            // 
            // calcularConstanteElasticaButton
            // 
            this.calcularConstanteElasticaButton.Location = new System.Drawing.Point(169, 251);
            this.calcularConstanteElasticaButton.Name = "calcularConstanteElasticaButton";
            this.calcularConstanteElasticaButton.Size = new System.Drawing.Size(75, 23);
            this.calcularConstanteElasticaButton.TabIndex = 19;
            this.calcularConstanteElasticaButton.Text = "Calcular";
            this.calcularConstanteElasticaButton.UseVisualStyleBackColor = true;
            this.calcularConstanteElasticaButton.Click += new System.EventHandler(this.calcularConstanteElasticaButton_Click);
            // 
            // F
            // 
            this.F.DecimalPlaces = 2;
            this.F.Location = new System.Drawing.Point(152, 74);
            this.F.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(120, 20);
            this.F.TabIndex = 11;
            // 
            // bd
            // 
            this.bd.DecimalPlaces = 2;
            this.bd.Location = new System.Drawing.Point(152, 114);
            this.bd.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(120, 20);
            this.bd.TabIndex = 12;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(91, 206);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.resultadoLabel.TabIndex = 17;
            this.resultadoLabel.Text = "Resultado";
            // 
            // sd
            // 
            this.sd.DecimalPlaces = 2;
            this.sd.Location = new System.Drawing.Point(152, 157);
            this.sd.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(120, 20);
            this.sd.TabIndex = 13;
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Location = new System.Drawing.Point(133, 116);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(15, 13);
            this.bdLabel.TabIndex = 16;
            this.bdLabel.Text = "D";
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(133, 76);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(13, 13);
            this.FLabel.TabIndex = 14;
            this.FLabel.Text = "F";
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Location = new System.Drawing.Point(133, 159);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(13, 13);
            this.sdLabel.TabIndex = 15;
            this.sdLabel.Text = "d";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Calcular Curso Angular";
            // 
            // salvarCursoAngularButton
            // 
            this.salvarCursoAngularButton.Location = new System.Drawing.Point(170, 296);
            this.salvarCursoAngularButton.Name = "salvarCursoAngularButton";
            this.salvarCursoAngularButton.Size = new System.Drawing.Size(75, 23);
            this.salvarCursoAngularButton.TabIndex = 28;
            this.salvarCursoAngularButton.Text = "Salvar";
            this.salvarCursoAngularButton.UseVisualStyleBackColor = true;
            this.salvarCursoAngularButton.Click += new System.EventHandler(this.salvarCursoAngularButton_Click);
            // 
            // resultadoCursoAngular
            // 
            this.resultadoCursoAngular.DecimalPlaces = 2;
            this.resultadoCursoAngular.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.resultadoCursoAngular.Location = new System.Drawing.Point(154, 207);
            this.resultadoCursoAngular.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.resultadoCursoAngular.Name = "resultadoCursoAngular";
            this.resultadoCursoAngular.ReadOnly = true;
            this.resultadoCursoAngular.Size = new System.Drawing.Size(120, 20);
            this.resultadoCursoAngular.TabIndex = 23;
            // 
            // calcularCursoAngularButton
            // 
            this.calcularCursoAngularButton.Location = new System.Drawing.Point(170, 253);
            this.calcularCursoAngularButton.Name = "calcularCursoAngularButton";
            this.calcularCursoAngularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularCursoAngularButton.TabIndex = 27;
            this.calcularCursoAngularButton.Text = "Calcular";
            this.calcularCursoAngularButton.UseVisualStyleBackColor = true;
            this.calcularCursoAngularButton.Click += new System.EventHandler(this.calcularCursoAngularButton_Click);
            // 
            // a
            // 
            this.a.DecimalPlaces = 2;
            this.a.Location = new System.Drawing.Point(154, 76);
            this.a.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 20);
            this.a.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Resultado";
            // 
            // b
            // 
            this.b.DecimalPlaces = 2;
            this.b.Location = new System.Drawing.Point(154, 114);
            this.b.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 20);
            this.b.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "a";
            // 
            // cadastrarEquipeToolStripMenuItem
            // 
            this.cadastrarEquipeToolStripMenuItem.Name = "cadastrarEquipeToolStripMenuItem";
            this.cadastrarEquipeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarEquipeToolStripMenuItem.Text = "Cadastrar equipe";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cursoAngularButton);
            this.Controls.Add(this.constanteElasticaButton);
            this.Controls.Add(this.cadastroEquipe);
            this.Controls.Add(this.cadastroAluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoConstanteElastica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoCursoAngular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastroAluno;
        private System.Windows.Forms.Button cadastroEquipe;
        private System.Windows.Forms.Button constanteElasticaButton;
        private System.Windows.Forms.Button cursoAngularButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button salvarConstanteElasticaButton;
        private System.Windows.Forms.NumericUpDown resultadoConstanteElastica;
        private System.Windows.Forms.Button calcularConstanteElasticaButton;
        private System.Windows.Forms.NumericUpDown F;
        private System.Windows.Forms.NumericUpDown bd;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.NumericUpDown sd;
        private System.Windows.Forms.Label bdLabel;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarCursoAngularButton;
        private System.Windows.Forms.NumericUpDown resultadoCursoAngular;
        private System.Windows.Forms.Button calcularCursoAngularButton;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEquipeToolStripMenuItem;
    }
}