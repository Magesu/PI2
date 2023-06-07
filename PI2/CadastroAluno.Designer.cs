namespace PI2
{
    partial class CadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAluno));
            this.calculoSuspensaoDataSet = new PI2.calculoSuspensaoDataSet();
            this.nome = new System.Windows.Forms.TextBox();
            this.raLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cadastroAlunoButton = new System.Windows.Forms.Button();
            this.ra = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // calculoSuspensaoDataSet
            // 
            this.calculoSuspensaoDataSet.DataSetName = "calculoSuspensaoDataSet";
            this.calculoSuspensaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(83, 82);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 1;
            // 
            // raLabel
            // 
            this.raLabel.AutoSize = true;
            this.raLabel.BackColor = System.Drawing.Color.LightGray;
            this.raLabel.Location = new System.Drawing.Point(55, 52);
            this.raLabel.Name = "raLabel";
            this.raLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.raLabel.Size = new System.Drawing.Size(22, 13);
            this.raLabel.TabIndex = 2;
            this.raLabel.Text = "RA";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.LightGray;
            this.nomeLabel.Location = new System.Drawing.Point(42, 89);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 3;
            this.nomeLabel.Text = "Nome";
            // 
            // cadastroAlunoButton
            // 
            this.cadastroAlunoButton.Location = new System.Drawing.Point(95, 133);
            this.cadastroAlunoButton.Name = "cadastroAlunoButton";
            this.cadastroAlunoButton.Size = new System.Drawing.Size(75, 23);
            this.cadastroAlunoButton.TabIndex = 4;
            this.cadastroAlunoButton.Text = "Cadastrar";
            this.cadastroAlunoButton.UseVisualStyleBackColor = true;
            this.cadastroAlunoButton.Click += new System.EventHandler(this.cadastroAlunoButton_Click);
            // 
            // ra
            // 
            this.ra.BeepOnError = true;
            this.ra.HidePromptOnLeave = true;
            this.ra.Location = new System.Drawing.Point(83, 45);
            this.ra.Mask = "0000000000";
            this.ra.Name = "ra";
            this.ra.PromptChar = ' ';
            this.ra.Size = new System.Drawing.Size(100, 20);
            this.ra.TabIndex = 5;
            this.ra.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(31, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do aluno";
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 207);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.cadastroAlunoButton);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.raLabel);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(18000, -18000);
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private calculoSuspensaoDataSet calculoSuspensaoDataSet;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label raLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button cadastroAlunoButton;
        private System.Windows.Forms.MaskedTextBox ra;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}