namespace PI2
{
    partial class Database
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
            this.equipesDataGridView = new System.Windows.Forms.DataGridView();
            this.idequipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculoSuspensaoDataSet = new PI2.calculoSuspensaoDataSet();
            this.equipesTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter();
            this.participantesDataGridView = new System.Windows.Forms.DataGridView();
            this.raDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantesTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.ParticipantesTableAdapter();
            this.calculosGridView = new System.Windows.Forms.DataGridView();
            this.idcalculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.calculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculosTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipesDataGridView
            // 
            this.equipesDataGridView.AllowUserToAddRows = false;
            this.equipesDataGridView.AllowUserToDeleteRows = false;
            this.equipesDataGridView.AutoGenerateColumns = false;
            this.equipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idequipeDataGridViewTextBoxColumn,
            this.numcarroDataGridViewTextBoxColumn,
            this.nomecarroDataGridViewTextBoxColumn});
            this.equipesDataGridView.DataSource = this.equipesBindingSource;
            this.equipesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.equipesDataGridView.Name = "equipesDataGridView";
            this.equipesDataGridView.ReadOnly = true;
            this.equipesDataGridView.Size = new System.Drawing.Size(422, 150);
            this.equipesDataGridView.TabIndex = 0;
            this.equipesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipesGridView_CellClick);
            // 
            // idequipeDataGridViewTextBoxColumn
            // 
            this.idequipeDataGridViewTextBoxColumn.DataPropertyName = "id_equipe";
            this.idequipeDataGridViewTextBoxColumn.HeaderText = "id_equipe";
            this.idequipeDataGridViewTextBoxColumn.Name = "idequipeDataGridViewTextBoxColumn";
            this.idequipeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numcarroDataGridViewTextBoxColumn
            // 
            this.numcarroDataGridViewTextBoxColumn.DataPropertyName = "num_carro";
            this.numcarroDataGridViewTextBoxColumn.HeaderText = "num_carro";
            this.numcarroDataGridViewTextBoxColumn.Name = "numcarroDataGridViewTextBoxColumn";
            this.numcarroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomecarroDataGridViewTextBoxColumn
            // 
            this.nomecarroDataGridViewTextBoxColumn.DataPropertyName = "nome_carro";
            this.nomecarroDataGridViewTextBoxColumn.HeaderText = "nome_carro";
            this.nomecarroDataGridViewTextBoxColumn.Name = "nomecarroDataGridViewTextBoxColumn";
            this.nomecarroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipesBindingSource
            // 
            this.equipesBindingSource.DataMember = "Equipes";
            this.equipesBindingSource.DataSource = this.calculoSuspensaoDataSet;
            // 
            // calculoSuspensaoDataSet
            // 
            this.calculoSuspensaoDataSet.DataSetName = "calculoSuspensaoDataSet";
            this.calculoSuspensaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipesTableAdapter
            // 
            this.equipesTableAdapter.ClearBeforeFill = true;
            // 
            // participantesDataGridView
            // 
            this.participantesDataGridView.AllowUserToAddRows = false;
            this.participantesDataGridView.AllowUserToDeleteRows = false;
            this.participantesDataGridView.AutoGenerateColumns = false;
            this.participantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.participantesDataGridView.DataSource = this.participantesBindingSource;
            this.participantesDataGridView.Location = new System.Drawing.Point(449, 12);
            this.participantesDataGridView.Name = "participantesDataGridView";
            this.participantesDataGridView.ReadOnly = true;
            this.participantesDataGridView.Size = new System.Drawing.Size(254, 150);
            this.participantesDataGridView.TabIndex = 1;
            // 
            // raDataGridViewTextBoxColumn
            // 
            this.raDataGridViewTextBoxColumn.DataPropertyName = "ra";
            this.raDataGridViewTextBoxColumn.HeaderText = "ra";
            this.raDataGridViewTextBoxColumn.Name = "raDataGridViewTextBoxColumn";
            this.raDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // participantesBindingSource
            // 
            this.participantesBindingSource.DataMember = "Participantes";
            this.participantesBindingSource.DataSource = this.calculoSuspensaoDataSet;
            // 
            // participantesTableAdapter
            // 
            this.participantesTableAdapter.ClearBeforeFill = true;
            // 
            // calculosGridView
            // 
            this.calculosGridView.AllowUserToAddRows = false;
            this.calculosGridView.AllowUserToDeleteRows = false;
            this.calculosGridView.AutoGenerateColumns = false;
            this.calculosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcalculoDataGridViewTextBoxColumn,
            this.pesototalDataGridViewTextBoxColumn,
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn,
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn});
            this.calculosGridView.DataSource = this.calculosBindingSource;
            this.calculosGridView.Location = new System.Drawing.Point(12, 168);
            this.calculosGridView.Name = "calculosGridView";
            this.calculosGridView.ReadOnly = true;
            this.calculosGridView.Size = new System.Drawing.Size(422, 150);
            this.calculosGridView.TabIndex = 2;
            // 
            // idcalculoDataGridViewTextBoxColumn
            // 
            this.idcalculoDataGridViewTextBoxColumn.DataPropertyName = "id_calculo";
            this.idcalculoDataGridViewTextBoxColumn.HeaderText = "id_calculo";
            this.idcalculoDataGridViewTextBoxColumn.Name = "idcalculoDataGridViewTextBoxColumn";
            this.idcalculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesototalDataGridViewTextBoxColumn
            // 
            this.pesototalDataGridViewTextBoxColumn.DataPropertyName = "peso_total";
            this.pesototalDataGridViewTextBoxColumn.HeaderText = "peso_total";
            this.pesototalDataGridViewTextBoxColumn.Name = "pesototalDataGridViewTextBoxColumn";
            this.pesototalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodasdianteirasassimetricasDataGridViewCheckBoxColumn
            // 
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn.DataPropertyName = "rodas_dianteiras_assimetricas";
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn.HeaderText = "rodas_dianteiras_assimetricas";
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn.Name = "rodasdianteirasassimetricasDataGridViewCheckBoxColumn";
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rodastraseirasassimetricasDataGridViewCheckBoxColumn
            // 
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn.DataPropertyName = "rodas_traseiras_assimetricas";
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn.HeaderText = "rodas_traseiras_assimetricas";
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn.Name = "rodastraseirasassimetricasDataGridViewCheckBoxColumn";
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // calculosBindingSource
            // 
            this.calculosBindingSource.DataMember = "Calculos";
            this.calculosBindingSource.DataSource = this.calculoSuspensaoDataSet;
            // 
            // calculosTableAdapter
            // 
            this.calculosTableAdapter.ClearBeforeFill = true;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 674);
            this.Controls.Add(this.calculosGridView);
            this.Controls.Add(this.participantesDataGridView);
            this.Controls.Add(this.equipesDataGridView);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView equipesDataGridView;
        private calculoSuspensaoDataSet calculoSuspensaoDataSet;
        private System.Windows.Forms.BindingSource equipesBindingSource;
        private calculoSuspensaoDataSetTableAdapters.EquipesTableAdapter equipesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idequipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView participantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn raDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource participantesBindingSource;
        private calculoSuspensaoDataSetTableAdapters.ParticipantesTableAdapter participantesTableAdapter;
        private System.Windows.Forms.DataGridView calculosGridView;
        private System.Windows.Forms.BindingSource calculosBindingSource;
        private calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter calculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcalculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rodasdianteirasassimetricasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rodastraseirasassimetricasDataGridViewCheckBoxColumn;
    }
}