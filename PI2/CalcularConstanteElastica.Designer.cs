namespace PI2
{
    partial class CalcularConstanteElastica
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
            this.F = new System.Windows.Forms.NumericUpDown();
            this.bd = new System.Windows.Forms.NumericUpDown();
            this.sd = new System.Windows.Forms.NumericUpDown();
            this.FLabel = new System.Windows.Forms.Label();
            this.sdLabel = new System.Windows.Forms.Label();
            this.bdLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.NumericUpDown();
            this.calcularButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // F
            // 
            this.F.DecimalPlaces = 2;
            this.F.Location = new System.Drawing.Point(291, 82);
            this.F.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(120, 20);
            this.F.TabIndex = 0;
            // 
            // bd
            // 
            this.bd.DecimalPlaces = 2;
            this.bd.Location = new System.Drawing.Point(291, 122);
            this.bd.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(120, 20);
            this.bd.TabIndex = 1;
            // 
            // sd
            // 
            this.sd.DecimalPlaces = 2;
            this.sd.Location = new System.Drawing.Point(291, 165);
            this.sd.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(120, 20);
            this.sd.TabIndex = 2;
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(272, 84);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(13, 13);
            this.FLabel.TabIndex = 3;
            this.FLabel.Text = "F";
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Location = new System.Drawing.Point(272, 167);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(13, 13);
            this.sdLabel.TabIndex = 4;
            this.sdLabel.Text = "d";
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Location = new System.Drawing.Point(272, 124);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(15, 13);
            this.bdLabel.TabIndex = 5;
            this.bdLabel.Text = "D";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(230, 214);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.resultadoLabel.TabIndex = 7;
            this.resultadoLabel.Text = "Resultado";
            // 
            // resultado
            // 
            this.resultado.DecimalPlaces = 2;
            this.resultado.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.resultado.Location = new System.Drawing.Point(291, 212);
            this.resultado.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(120, 20);
            this.resultado.TabIndex = 8;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(308, 259);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 9;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(308, 304);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 10;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // CalcularConstanteElastica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.bdLabel);
            this.Controls.Add(this.sdLabel);
            this.Controls.Add(this.FLabel);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.F);
            this.Name = "CalcularConstanteElastica";
            this.Text = "CalcularConstanteElastica";
            ((System.ComponentModel.ISupportInitialize)(this.F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown F;
        private System.Windows.Forms.NumericUpDown bd;
        private System.Windows.Forms.NumericUpDown sd;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label bdLabel;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.NumericUpDown resultado;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button salvarButton;
    }
}