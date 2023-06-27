namespace PI2
{
    partial class EquipeInfo
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_carro = new System.Windows.Forms.Label();
            this.nome_carro = new System.Windows.Forms.Label();
            this.button_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.participantesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculoSuspensaoDataSet = new PI2.calculoSuspensaoDataSet();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ra = new System.Windows.Forms.TextBox();
            this.button_adicionar_participante = new System.Windows.Forms.Button();
            this.button_remover_participante = new System.Windows.Forms.Button();
            this.raDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantesTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.ParticipantesTableAdapter();
            this.tableAdapterManager = new PI2.calculoSuspensaoDataSetTableAdapters.TableAdapterManager();
            this.alunosTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.AlunosTableAdapter();
            this.equipesTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.participantesDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_editar, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 95);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.num_carro, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nome_carro, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(102, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // num_carro
            // 
            this.num_carro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_carro.AutoSize = true;
            this.num_carro.Location = new System.Drawing.Point(59, 5);
            this.num_carro.Margin = new System.Windows.Forms.Padding(5);
            this.num_carro.Name = "num_carro";
            this.num_carro.Size = new System.Drawing.Size(13, 13);
            this.num_carro.TabIndex = 2;
            this.num_carro.Text = "1";
            // 
            // nome_carro
            // 
            this.nome_carro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nome_carro.AutoSize = true;
            this.nome_carro.Location = new System.Drawing.Point(59, 28);
            this.nome_carro.Margin = new System.Windows.Forms.Padding(5);
            this.nome_carro.Name = "nome_carro";
            this.nome_carro.Size = new System.Drawing.Size(38, 13);
            this.nome_carro.TabIndex = 3;
            this.nome_carro.Text = "Batata";
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(26, 69);
            this.button_editar.Margin = new System.Windows.Forms.Padding(26, 3, 3, 3);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 1;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Participantes";
            // 
            // participantesDataGridView
            // 
            this.participantesDataGridView.AllowUserToAddRows = false;
            this.participantesDataGridView.AllowUserToDeleteRows = false;
            this.participantesDataGridView.AutoGenerateColumns = false;
            this.participantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.participantesDataGridView.DataSource = this.participantesBindingSource;
            this.participantesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantesDataGridView.Location = new System.Drawing.Point(3, 144);
            this.participantesDataGridView.Name = "participantesDataGridView";
            this.participantesDataGridView.ReadOnly = true;
            this.participantesDataGridView.Size = new System.Drawing.Size(543, 189);
            this.participantesDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ra";
            this.dataGridViewTextBoxColumn1.HeaderText = "ra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // participantesBindingSource
            // 
            this.participantesBindingSource.DataMember = "Participantes";
            this.participantesBindingSource.DataSource = this.calculoSuspensaoDataSet;
            // 
            // calculoSuspensaoDataSet
            // 
            this.calculoSuspensaoDataSet.DataSetName = "calculoSuspensaoDataSet";
            this.calculoSuspensaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_ra, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_adicionar_participante, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_remover_participante, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 339);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(543, 29);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "RA";
            // 
            // textBox_ra
            // 
            this.textBox_ra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ra.Location = new System.Drawing.Point(154, 4);
            this.textBox_ra.Name = "textBox_ra";
            this.textBox_ra.Size = new System.Drawing.Size(100, 20);
            this.textBox_ra.TabIndex = 1;
            // 
            // button_adicionar_participante
            // 
            this.button_adicionar_participante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_adicionar_participante.Location = new System.Drawing.Point(260, 3);
            this.button_adicionar_participante.Name = "button_adicionar_participante";
            this.button_adicionar_participante.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar_participante.TabIndex = 2;
            this.button_adicionar_participante.Text = "Adicionar";
            this.button_adicionar_participante.UseVisualStyleBackColor = true;
            this.button_adicionar_participante.Click += new System.EventHandler(this.button_adicionar_participante_Click);
            // 
            // button_remover_participante
            // 
            this.button_remover_participante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_remover_participante.Location = new System.Drawing.Point(341, 3);
            this.button_remover_participante.Name = "button_remover_participante";
            this.button_remover_participante.Size = new System.Drawing.Size(75, 23);
            this.button_remover_participante.TabIndex = 3;
            this.button_remover_participante.Text = "Remover";
            this.button_remover_participante.UseVisualStyleBackColor = true;
            this.button_remover_participante.Click += new System.EventHandler(this.button_remover_participante_Click);
            // 
            // raDataGridViewTextBoxColumn
            // 
            this.raDataGridViewTextBoxColumn.DataPropertyName = "ra";
            this.raDataGridViewTextBoxColumn.HeaderText = "ra";
            this.raDataGridViewTextBoxColumn.Name = "raDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // participantesTableAdapter
            // 
            this.participantesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculosTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EquipesTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.RodasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI2.calculoSuspensaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // alunosTableAdapter1
            // 
            this.alunosTableAdapter1.ClearBeforeFill = true;
            // 
            // equipesTableAdapter1
            // 
            this.equipesTableAdapter1.ClearBeforeFill = true;
            // 
            // EquipeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(324, 330);
            this.Name = "EquipeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações da equipe";
            this.Load += new System.EventHandler(this.EquipeInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label num_carro;
        private System.Windows.Forms.Label nome_carro;
        private calculoSuspensaoDataSet calculoSuspensaoDataSet;
        private System.Windows.Forms.BindingSource participantesBindingSource;
        private calculoSuspensaoDataSetTableAdapters.ParticipantesTableAdapter participantesTableAdapter;
        private calculoSuspensaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView participantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn raDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ra;
        private System.Windows.Forms.Button button_adicionar_participante;
        private System.Windows.Forms.Button button_remover_participante;
        private calculoSuspensaoDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter1;
        private calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter equipesTableAdapter1;
        private System.Windows.Forms.Button button_editar;
    }
}