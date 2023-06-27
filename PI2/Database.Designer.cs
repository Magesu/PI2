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
            this.calculosDataGridView = new System.Windows.Forms.DataGridView();
            this.idcalculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.calculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculosTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter();
            this.rodasDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuicaopesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciabitolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciamolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanteelasticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprimentobracoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoangularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodasTableAdapter = new PI2.calculoSuspensaoDataSetTableAdapters.RodasTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_id_equipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_remover = new System.Windows.Forms.Button();
            this.alunosTableAdapter1 = new PI2.calculoSuspensaoDataSetTableAdapters.AlunosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodasBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.equipesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipesDataGridView.Location = new System.Drawing.Point(3, 23);
            this.equipesDataGridView.Name = "equipesDataGridView";
            this.equipesDataGridView.ReadOnly = true;
            this.equipesDataGridView.Size = new System.Drawing.Size(393, 139);
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
            this.participantesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantesDataGridView.Location = new System.Drawing.Point(402, 23);
            this.participantesDataGridView.Name = "participantesDataGridView";
            this.participantesDataGridView.ReadOnly = true;
            this.participantesDataGridView.Size = new System.Drawing.Size(393, 139);
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
            // calculosDataGridView
            // 
            this.calculosDataGridView.AllowUserToAddRows = false;
            this.calculosDataGridView.AllowUserToDeleteRows = false;
            this.calculosDataGridView.AutoGenerateColumns = false;
            this.calculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcalculoDataGridViewTextBoxColumn,
            this.pesototalDataGridViewTextBoxColumn,
            this.rodasdianteirasassimetricasDataGridViewCheckBoxColumn,
            this.rodastraseirasassimetricasDataGridViewCheckBoxColumn});
            this.calculosDataGridView.DataSource = this.calculosBindingSource;
            this.calculosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculosDataGridView.Location = new System.Drawing.Point(3, 194);
            this.calculosDataGridView.Name = "calculosDataGridView";
            this.calculosDataGridView.ReadOnly = true;
            this.calculosDataGridView.Size = new System.Drawing.Size(798, 166);
            this.calculosDataGridView.TabIndex = 2;
            this.calculosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calculosDataGridView_CellClick);
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
            // rodasDataGridView
            // 
            this.rodasDataGridView.AllowUserToAddRows = false;
            this.rodasDataGridView.AllowUserToDeleteRows = false;
            this.rodasDataGridView.AutoGenerateColumns = false;
            this.rodasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rodasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.distribuicaopesoDataGridViewTextBoxColumn,
            this.distanciabitolaDataGridViewTextBoxColumn,
            this.distanciamolaDataGridViewTextBoxColumn,
            this.constanteelasticaDataGridViewTextBoxColumn,
            this.comprimentobracoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.cursoangularDataGridViewTextBoxColumn});
            this.rodasDataGridView.DataSource = this.rodasBindingSource;
            this.rodasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rodasDataGridView.Location = new System.Drawing.Point(3, 386);
            this.rodasDataGridView.Name = "rodasDataGridView";
            this.rodasDataGridView.ReadOnly = true;
            this.rodasDataGridView.Size = new System.Drawing.Size(798, 166);
            this.rodasDataGridView.TabIndex = 3;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distribuicaopesoDataGridViewTextBoxColumn
            // 
            this.distribuicaopesoDataGridViewTextBoxColumn.DataPropertyName = "distribuicao_peso";
            this.distribuicaopesoDataGridViewTextBoxColumn.HeaderText = "distribuicao_peso";
            this.distribuicaopesoDataGridViewTextBoxColumn.Name = "distribuicaopesoDataGridViewTextBoxColumn";
            this.distribuicaopesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanciabitolaDataGridViewTextBoxColumn
            // 
            this.distanciabitolaDataGridViewTextBoxColumn.DataPropertyName = "distancia_bitola";
            this.distanciabitolaDataGridViewTextBoxColumn.HeaderText = "distancia_bitola";
            this.distanciabitolaDataGridViewTextBoxColumn.Name = "distanciabitolaDataGridViewTextBoxColumn";
            this.distanciabitolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanciamolaDataGridViewTextBoxColumn
            // 
            this.distanciamolaDataGridViewTextBoxColumn.DataPropertyName = "distancia_mola";
            this.distanciamolaDataGridViewTextBoxColumn.HeaderText = "distancia_mola";
            this.distanciamolaDataGridViewTextBoxColumn.Name = "distanciamolaDataGridViewTextBoxColumn";
            this.distanciamolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constanteelasticaDataGridViewTextBoxColumn
            // 
            this.constanteelasticaDataGridViewTextBoxColumn.DataPropertyName = "constante_elastica";
            this.constanteelasticaDataGridViewTextBoxColumn.HeaderText = "constante_elastica";
            this.constanteelasticaDataGridViewTextBoxColumn.Name = "constanteelasticaDataGridViewTextBoxColumn";
            this.constanteelasticaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprimentobracoDataGridViewTextBoxColumn
            // 
            this.comprimentobracoDataGridViewTextBoxColumn.DataPropertyName = "comprimento_braco";
            this.comprimentobracoDataGridViewTextBoxColumn.HeaderText = "comprimento_braco";
            this.comprimentobracoDataGridViewTextBoxColumn.Name = "comprimentobracoDataGridViewTextBoxColumn";
            this.comprimentobracoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoangularDataGridViewTextBoxColumn
            // 
            this.cursoangularDataGridViewTextBoxColumn.DataPropertyName = "curso_angular";
            this.cursoangularDataGridViewTextBoxColumn.HeaderText = "curso_angular";
            this.cursoangularDataGridViewTextBoxColumn.Name = "cursoangularDataGridViewTextBoxColumn";
            this.cursoangularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodasBindingSource
            // 
            this.rodasBindingSource.DataMember = "Rodas";
            this.rodasBindingSource.DataSource = this.calculoSuspensaoDataSet;
            // 
            // rodasTableAdapter
            // 
            this.rodasTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rodasDataGridView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.calculosDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 591);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.equipesDataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.participantesDataGridView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 165);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(402, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Participantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cálculos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(3, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rodas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_id_equipe, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_remover, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 558);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(798, 30);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // textBox_id_equipe
            // 
            this.textBox_id_equipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id_equipe.Location = new System.Drawing.Point(345, 5);
            this.textBox_id_equipe.Name = "textBox_id_equipe";
            this.textBox_id_equipe.Size = new System.Drawing.Size(100, 20);
            this.textBox_id_equipe.TabIndex = 0;
            this.textBox_id_equipe.TextChanged += new System.EventHandler(this.textBox_id_equipe_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID da equipe";
            // 
            // button_remover
            // 
            this.button_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_remover.Enabled = false;
            this.button_remover.Location = new System.Drawing.Point(451, 3);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(75, 23);
            this.button_remover.TabIndex = 2;
            this.button_remover.Text = "Excluir";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // alunosTableAdapter1
            // 
            this.alunosTableAdapter1.ClearBeforeFill = true;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Database";
            this.Text = "Base de dados";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoSuspensaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodasBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView calculosDataGridView;
        private System.Windows.Forms.BindingSource calculosBindingSource;
        private calculoSuspensaoDataSetTableAdapters.CalculosTableAdapter calculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcalculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rodasdianteirasassimetricasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rodastraseirasassimetricasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView rodasDataGridView;
        private System.Windows.Forms.BindingSource rodasBindingSource;
        private calculoSuspensaoDataSetTableAdapters.RodasTableAdapter rodasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distribuicaopesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciabitolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciamolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanteelasticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprimentobracoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoangularDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_id_equipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_remover;
        private calculoSuspensaoDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter1;
    }
}