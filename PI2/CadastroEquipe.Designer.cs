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
            this.nomeCarro = new System.Windows.Forms.TextBox();
            this.numCarro = new System.Windows.Forms.NumericUpDown();
            this.numCarroLabel = new System.Windows.Forms.Label();
            this.nomeCarroLabel = new System.Windows.Forms.Label();
            this.cadastroEquipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeCarro
            // 
            this.nomeCarro.Location = new System.Drawing.Point(122, 76);
            this.nomeCarro.Name = "nomeCarro";
            this.nomeCarro.Size = new System.Drawing.Size(104, 20);
            this.nomeCarro.TabIndex = 1;
            // 
            // numCarro
            // 
            this.numCarro.Location = new System.Drawing.Point(122, 33);
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
            this.numCarroLabel.Location = new System.Drawing.Point(30, 35);
            this.numCarroLabel.Name = "numCarroLabel";
            this.numCarroLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numCarroLabel.Size = new System.Drawing.Size(86, 13);
            this.numCarroLabel.TabIndex = 3;
            this.numCarroLabel.Text = "Número do carro";
            // 
            // nomeCarroLabel
            // 
            this.nomeCarroLabel.AutoSize = true;
            this.nomeCarroLabel.Location = new System.Drawing.Point(39, 79);
            this.nomeCarroLabel.Name = "nomeCarroLabel";
            this.nomeCarroLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeCarroLabel.Size = new System.Drawing.Size(77, 13);
            this.nomeCarroLabel.TabIndex = 4;
            this.nomeCarroLabel.Text = "Nome do carro";
            // 
            // cadastroEquipeButton
            // 
            this.cadastroEquipeButton.Location = new System.Drawing.Point(122, 128);
            this.cadastroEquipeButton.Name = "cadastroEquipeButton";
            this.cadastroEquipeButton.Size = new System.Drawing.Size(75, 23);
            this.cadastroEquipeButton.TabIndex = 5;
            this.cadastroEquipeButton.Text = "Cadastrar";
            this.cadastroEquipeButton.UseVisualStyleBackColor = true;
            this.cadastroEquipeButton.Click += new System.EventHandler(this.cadastroEquipeButton_Click);
            // 
            // CadastroEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastroEquipeButton);
            this.Controls.Add(this.nomeCarroLabel);
            this.Controls.Add(this.numCarroLabel);
            this.Controls.Add(this.numCarro);
            this.Controls.Add(this.nomeCarro);
            this.Name = "CadastroEquipe";
            this.Text = "CadastroEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.numCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeCarro;
        private System.Windows.Forms.NumericUpDown numCarro;
        private System.Windows.Forms.Label numCarroLabel;
        private System.Windows.Forms.Label nomeCarroLabel;
        private System.Windows.Forms.Button cadastroEquipeButton;
    }
}