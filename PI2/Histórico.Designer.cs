namespace PI2
{
    partial class Histórico
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.carro1 = new PI2.Carro();
            this.carro2 = new PI2.Carro();
            this.carro3 = new PI2.Carro();
            this.equipesTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter();
            this.calculosTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_recarregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.carro1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.carro2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.carro3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 459);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // carro1
            // 
            this.carro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carro1.limite_calculos = 3;
            this.carro1.Location = new System.Drawing.Point(3, 3);
            this.carro1.Name = "carro1";
            this.carro1.Nome = "Id do cálculo: -1";
            this.carro1.Peso_Total = 0D;
            this.carro1.Rodas_Dianteiras_Assimetricas = false;
            this.carro1.Rodas_Traseiras_Assimetricas = false;
            this.carro1.Size = new System.Drawing.Size(693, 436);
            this.carro1.TabIndex = 0;
            // 
            // carro2
            // 
            this.carro2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carro2.limite_calculos = 3;
            this.carro2.Location = new System.Drawing.Point(702, 3);
            this.carro2.Name = "carro2";
            this.carro2.Nome = "Id do cálculo: -1";
            this.carro2.Peso_Total = 0D;
            this.carro2.Rodas_Dianteiras_Assimetricas = false;
            this.carro2.Rodas_Traseiras_Assimetricas = false;
            this.carro2.Size = new System.Drawing.Size(693, 436);
            this.carro2.TabIndex = 1;
            // 
            // carro3
            // 
            this.carro3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carro3.limite_calculos = 3;
            this.carro3.Location = new System.Drawing.Point(1401, 3);
            this.carro3.Name = "carro3";
            this.carro3.Nome = "Id do cálculo: -1";
            this.carro3.Peso_Total = 0D;
            this.carro3.Rodas_Dianteiras_Assimetricas = false;
            this.carro3.Rodas_Traseiras_Assimetricas = false;
            this.carro3.Size = new System.Drawing.Size(693, 436);
            this.carro3.TabIndex = 2;
            // 
            // equipesTableAdapter1
            // 
            this.equipesTableAdapter1.ClearBeforeFill = true;
            // 
            // calculosTableAdapter1
            // 
            this.calculosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_recarregar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_recarregar
            // 
            this.button_recarregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_recarregar.Location = new System.Drawing.Point(337, 472);
            this.button_recarregar.Margin = new System.Windows.Forms.Padding(7);
            this.button_recarregar.Name = "button_recarregar";
            this.button_recarregar.Size = new System.Drawing.Size(126, 23);
            this.button_recarregar.TabIndex = 1;
            this.button_recarregar.Text = "Recarregar cálculos";
            this.button_recarregar.UseVisualStyleBackColor = true;
            this.button_recarregar.Click += new System.EventHandler(this.button_recarregar_Click);
            // 
            // Histórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Histórico";
            this.Text = "Histórico de cálculos";
            this.Load += new System.EventHandler(this.Histórico_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Carro carro1;
        private Carro carro2;
        private Carro carro3;
        private calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter equipesTableAdapter1;
        private calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter calculosTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_recarregar;
    }
}