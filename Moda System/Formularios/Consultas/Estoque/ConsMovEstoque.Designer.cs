namespace Moda_System.Formularios.Consultas.Estoque
{
    partial class ConsMovEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsMovEstoque));
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.codMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.dt_DataIni = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_DataFim = new System.Windows.Forms.DateTimePicker();
            this.cb_tipoData = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TipoMov = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Terceiro = new System.Windows.Forms.ComboBox();
            this.tb_NomeTerceiro = new System.Windows.Forms.TextBox();
            this.bt_Terceiro = new System.Windows.Forms.Button();
            this.tb_NomeLocal = new System.Windows.Forms.TextBox();
            this.bt_Local = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Atualizar.FlatAppearance.BorderSize = 0;
            this.bt_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Atualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualizar.Image = global::Moda_System.Properties.Resources.DBPesquisar32x32;
            this.bt_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atualizar.Location = new System.Drawing.Point(484, 118);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(115, 41);
            this.bt_Atualizar.TabIndex = 202;
            this.bt_Atualizar.Text = " Atualizar";
            this.bt_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Atualizar.UseVisualStyleBackColor = false;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bt_Cadastrar.Image = global::Moda_System.Properties.Resources.DBCadastrar32x32;
            this.bt_Cadastrar.Location = new System.Drawing.Point(484, 328);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(115, 41);
            this.bt_Cadastrar.TabIndex = 203;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cadastrar.UseVisualStyleBackColor = false;
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Modificar.FlatAppearance.BorderSize = 0;
            this.bt_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Modificar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bt_Modificar.Image = global::Moda_System.Properties.Resources.DBModificar32x32;
            this.bt_Modificar.Location = new System.Drawing.Point(484, 375);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(115, 41);
            this.bt_Modificar.TabIndex = 204;
            this.bt_Modificar.Text = "Alterar    ";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Modificar.UseVisualStyleBackColor = false;
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Todos",
            "Abertos",
            "Fechados"});
            this.cb_Status.Location = new System.Drawing.Point(375, 39);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(87, 24);
            this.cb_Status.TabIndex = 201;
            // 
            // bt_Confirmar
            // 
            this.bt_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatAppearance.BorderSize = 0;
            this.bt_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.bt_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.bt_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Confirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bt_Confirmar.Image = global::Moda_System.Properties.Resources.dbConfirm32x32;
            this.bt_Confirmar.Location = new System.Drawing.Point(484, 71);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(115, 41);
            this.bt_Confirmar.TabIndex = 196;
            this.bt_Confirmar.Text = "Confirmar";
            this.bt_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            // 
            // grd_Dados
            // 
            this.grd_Dados.AllowUserToAddRows = false;
            this.grd_Dados.AllowUserToDeleteRows = false;
            this.grd_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMov,
            this.desPro,
            this.tipMov,
            this.qntMov,
            this.localEst,
            this.statusMov});
            this.grd_Dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Dados.Location = new System.Drawing.Point(3, 23);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 21;
            this.grd_Dados.Size = new System.Drawing.Size(463, 166);
            this.grd_Dados.TabIndex = 197;
            // 
            // codMov
            // 
            this.codMov.HeaderText = "#";
            this.codMov.Name = "codMov";
            this.codMov.ReadOnly = true;
            this.codMov.Width = 40;
            // 
            // desPro
            // 
            this.desPro.HeaderText = "Produto";
            this.desPro.Name = "desPro";
            this.desPro.ReadOnly = true;
            this.desPro.Width = 180;
            // 
            // tipMov
            // 
            this.tipMov.HeaderText = "Tipo";
            this.tipMov.Name = "tipMov";
            this.tipMov.ReadOnly = true;
            this.tipMov.Width = 80;
            // 
            // qntMov
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.qntMov.DefaultCellStyle = dataGridViewCellStyle1;
            this.qntMov.HeaderText = "Quantidade";
            this.qntMov.Name = "qntMov";
            this.qntMov.ReadOnly = true;
            // 
            // localEst
            // 
            this.localEst.HeaderText = "Local";
            this.localEst.Name = "localEst";
            this.localEst.ReadOnly = true;
            // 
            // statusMov
            // 
            this.statusMov.HeaderText = "Status";
            this.statusMov.Name = "statusMov";
            this.statusMov.ReadOnly = true;
            this.statusMov.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(128, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 198;
            this.label4.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(372, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 199;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 200;
            this.label1.Text = "Tipo Data";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Fechar);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 50);
            this.panel2.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 35);
            this.label3.TabIndex = 149;
            this.label3.Text = "Consulta Movimentos de Estoque";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.Fechar2_48x48;
            this.bt_Fechar.Location = new System.Drawing.Point(557, 10);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 31);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            // 
            // dt_DataIni
            // 
            this.dt_DataIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dt_DataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataIni.Location = new System.Drawing.Point(151, 41);
            this.dt_DataIni.Name = "dt_DataIni";
            this.dt_DataIni.Size = new System.Drawing.Size(95, 22);
            this.dt_DataIni.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(246, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 198;
            this.label5.Text = "até";
            // 
            // dt_DataFim
            // 
            this.dt_DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dt_DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataFim.Location = new System.Drawing.Point(272, 41);
            this.dt_DataFim.Name = "dt_DataFim";
            this.dt_DataFim.Size = new System.Drawing.Size(95, 22);
            this.dt_DataFim.TabIndex = 205;
            // 
            // cb_tipoData
            // 
            this.cb_tipoData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_tipoData.FormattingEnabled = true;
            this.cb_tipoData.Items.AddRange(new object[] {
            "Movimento",
            "Digitação"});
            this.cb_tipoData.Location = new System.Drawing.Point(9, 39);
            this.cb_tipoData.Name = "cb_tipoData";
            this.cb_tipoData.Size = new System.Drawing.Size(106, 24);
            this.cb_tipoData.TabIndex = 206;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 200;
            this.label6.Text = "Tipo Mov.";
            // 
            // cb_TipoMov
            // 
            this.cb_TipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_TipoMov.FormattingEnabled = true;
            this.cb_TipoMov.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA",
            "DEVOLUÇÃO"});
            this.cb_TipoMov.Location = new System.Drawing.Point(9, 85);
            this.cb_TipoMov.Name = "cb_TipoMov";
            this.cb_TipoMov.Size = new System.Drawing.Size(106, 24);
            this.cb_TipoMov.TabIndex = 206;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 200;
            this.label7.Text = "Terceiro";
            // 
            // cb_Terceiro
            // 
            this.cb_Terceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Terceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Terceiro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cb_Terceiro.FormattingEnabled = true;
            this.cb_Terceiro.Items.AddRange(new object[] {
            "Fornecedor",
            "Vendedor",
            "Cliente"});
            this.cb_Terceiro.Location = new System.Drawing.Point(9, 131);
            this.cb_Terceiro.Name = "cb_Terceiro";
            this.cb_Terceiro.Size = new System.Drawing.Size(106, 24);
            this.cb_Terceiro.TabIndex = 206;
            // 
            // tb_NomeTerceiro
            // 
            this.tb_NomeTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_NomeTerceiro.Location = new System.Drawing.Point(121, 132);
            this.tb_NomeTerceiro.Name = "tb_NomeTerceiro";
            this.tb_NomeTerceiro.Size = new System.Drawing.Size(310, 22);
            this.tb_NomeTerceiro.TabIndex = 207;
            // 
            // bt_Terceiro
            // 
            this.bt_Terceiro.FlatAppearance.BorderSize = 0;
            this.bt_Terceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Terceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Terceiro.Image = ((System.Drawing.Image)(resources.GetObject("bt_Terceiro.Image")));
            this.bt_Terceiro.Location = new System.Drawing.Point(437, 129);
            this.bt_Terceiro.Name = "bt_Terceiro";
            this.bt_Terceiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Terceiro.Size = new System.Drawing.Size(25, 27);
            this.bt_Terceiro.TabIndex = 208;
            this.bt_Terceiro.UseVisualStyleBackColor = true;
            // 
            // tb_NomeLocal
            // 
            this.tb_NomeLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_NomeLocal.Location = new System.Drawing.Point(121, 85);
            this.tb_NomeLocal.Name = "tb_NomeLocal";
            this.tb_NomeLocal.Size = new System.Drawing.Size(310, 22);
            this.tb_NomeLocal.TabIndex = 207;
            // 
            // bt_Local
            // 
            this.bt_Local.FlatAppearance.BorderSize = 0;
            this.bt_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Local.Image = ((System.Drawing.Image)(resources.GetObject("bt_Local.Image")));
            this.bt_Local.Location = new System.Drawing.Point(437, 82);
            this.bt_Local.Name = "bt_Local";
            this.bt_Local.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Local.Size = new System.Drawing.Size(25, 27);
            this.bt_Local.TabIndex = 208;
            this.bt_Local.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(118, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 200;
            this.label8.Text = "Estoque";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(128, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 200;
            this.label9.Text = "Período";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(118, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 200;
            this.label10.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_DataIni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_Local);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_NomeLocal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bt_Terceiro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_NomeTerceiro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_Terceiro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_TipoMov);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_tipoData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dt_DataFim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Status);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 163);
            this.groupBox1.TabIndex = 209;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd_Dados);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 192);
            this.groupBox2.TabIndex = 210;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentaçãoes";
            // 
            // ConsMovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsMovEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Movimentos de Estoque";
            this.Load += new System.EventHandler(this.ConsMovEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.DateTimePicker dt_DataIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_DataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn desPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn localEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusMov;
        private System.Windows.Forms.ComboBox cb_tipoData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TipoMov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Terceiro;
        private System.Windows.Forms.TextBox tb_NomeTerceiro;
        private System.Windows.Forms.Button bt_Terceiro;
        private System.Windows.Forms.TextBox tb_NomeLocal;
        private System.Windows.Forms.Button bt_Local;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}