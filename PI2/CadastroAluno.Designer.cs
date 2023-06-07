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
            this.calculoSuspensaoDataSet = new PI2.calculoSuspensaoDataSet();
            this.nome = new System.Windows.Forms.TextBox();
            this.raLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cadastroAlunoButton = new System.Windows.Forms.Button();
            this.ra = new System.Windows.Forms.MaskedTextBox();
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
            this.nome.Location = new System.Drawing.Point(86, 75);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 1;
            // 
            // raLabel
            // 
            this.raLabel.AutoSize = true;
            this.raLabel.Location = new System.Drawing.Point(58, 45);
            this.raLabel.Name = "raLabel";
            this.raLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.raLabel.Size = new System.Drawing.Size(22, 13);
            this.raLabel.TabIndex = 2;
            this.raLabel.Text = "RA";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(45, 82);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 3;
            this.nomeLabel.Text = "Nome";
            // 
            // cadastroAlunoButton
            // 
            this.cadastroAlunoButton.Location = new System.Drawing.Point(86, 128);
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
            this.ra.Location = new System.Drawing.Point(86, 38);
            this.ra.Mask = "0000000000";
            this.ra.Name = "ra";
            this.ra.PromptChar = ' ';
            this.ra.Size = new System.Drawing.Size(100, 20);
            this.ra.TabIndex = 5;
            this.ra.ValidatingType = typeof(System.DateTime);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.cadastroAlunoButton);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.raLabel);
            this.Controls.Add(this.nome);
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
    }
}