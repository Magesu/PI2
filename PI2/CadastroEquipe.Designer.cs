namespace PI2
{
    partial class CadastroEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEquipe));
            this.nomeCarro = new System.Windows.Forms.TextBox();
            this.numCarro = new System.Windows.Forms.NumericUpDown();
            this.numCarroLabel = new System.Windows.Forms.Label();
            this.nomeCarroLabel = new System.Windows.Forms.Label();
            this.cadastroEquipeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCarro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeCarro
            // 
            this.nomeCarro.Location = new System.Drawing.Point(95, 52);
            this.nomeCarro.Name = "nomeCarro";
            this.nomeCarro.Size = new System.Drawing.Size(104, 20);
            this.nomeCarro.TabIndex = 1;
            // 
            // numCarro
            // 
            this.numCarro.Location = new System.Drawing.Point(95, 23);
            this.numCarro.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCarro.Name = "numCarro";
            this.numCarro.Size = new System.Drawing.Size(104, 20);
            this.numCarro.TabIndex = 2;
            // 
            // numCarroLabel
            // 
            this.numCarroLabel.AutoSize = true;
            this.numCarroLabel.Location = new System.Drawing.Point(3, 25);
            this.numCarroLabel.Name = "numCarroLabel";
            this.numCarroLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numCarroLabel.Size = new System.Drawing.Size(86, 13);
            this.numCarroLabel.TabIndex = 3;
            this.numCarroLabel.Text = "Número do carro";
            this.numCarroLabel.Click += new System.EventHandler(this.numCarroLabel_Click);
            // 
            // nomeCarroLabel
            // 
            this.nomeCarroLabel.AutoSize = true;
            this.nomeCarroLabel.Location = new System.Drawing.Point(12, 55);
            this.nomeCarroLabel.Name = "nomeCarroLabel";
            this.nomeCarroLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeCarroLabel.Size = new System.Drawing.Size(77, 13);
            this.nomeCarroLabel.TabIndex = 4;
            this.nomeCarroLabel.Text = "Nome do carro";
            // 
            // cadastroEquipeButton
            // 
            this.cadastroEquipeButton.Location = new System.Drawing.Point(95, 104);
            this.cadastroEquipeButton.Name = "cadastroEquipeButton";
            this.cadastroEquipeButton.Size = new System.Drawing.Size(75, 23);
            this.cadastroEquipeButton.TabIndex = 5;
            this.cadastroEquipeButton.Text = "Cadastrar";
            this.cadastroEquipeButton.UseVisualStyleBackColor = true;
            this.cadastroEquipeButton.Click += new System.EventHandler(this.cadastroEquipeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cadastroEquipeButton);
            this.groupBox1.Controls.Add(this.nomeCarroLabel);
            this.groupBox1.Controls.Add(this.numCarroLabel);
            this.groupBox1.Controls.Add(this.numCarro);
            this.groupBox1.Controls.Add(this.nomeCarro);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro da Equipe";
            // 
            // CadastroEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 188);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroEquipe";
            this.Text = "CadastroEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.numCarro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nomeCarro;
        private System.Windows.Forms.NumericUpDown numCarro;
        private System.Windows.Forms.Label numCarroLabel;
        private System.Windows.Forms.Label nomeCarroLabel;
        private System.Windows.Forms.Button cadastroEquipeButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}