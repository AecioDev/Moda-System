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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsMovEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bt_Marca = new System.Windows.Forms.Button();
            this.codMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.bt_Atualizar.Location = new System.Drawing.Point(468, 130);
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(468, 177);
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
            this.bt_Modificar.Location = new System.Drawing.Point(468, 224);
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
            this.cb_Status.Location = new System.Drawing.Point(373, 96);
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
            this.bt_Confirmar.Location = new System.Drawing.Point(468, 83);
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
            this.grd_Dados.Location = new System.Drawing.Point(7, 129);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 21;
            this.grd_Dados.Size = new System.Drawing.Size(453, 137);
            this.grd_Dados.TabIndex = 197;
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_nome.Location = new System.Drawing.Point(121, 67);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(308, 22);
            this.tb_nome.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 198;
            this.label4.Text = "Período";
            // 
            // tb_codPro
            // 
            this.tb_codPro.BackColor = System.Drawing.SystemColors.Control;
            this.tb_codPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_codPro.Location = new System.Drawing.Point(71, 67);
            this.tb_codPro.Name = "tb_codPro";
            this.tb_codPro.Size = new System.Drawing.Size(44, 22);
            this.tb_codPro.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(322, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 199;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 200;
            this.label1.Text = "Produto";
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
            this.panel2.Size = new System.Drawing.Size(594, 50);
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
            this.bt_Fechar.Location = new System.Drawing.Point(547, 10);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 31);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(166, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 198;
            this.label5.Text = "até";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 205;
            // 
            // bt_Marca
            // 
            this.bt_Marca.FlatAppearance.BorderSize = 0;
            this.bt_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Marca.Image = ((System.Drawing.Image)(resources.GetObject("bt_Marca.Image")));
            this.bt_Marca.Location = new System.Drawing.Point(435, 63);
            this.bt_Marca.Name = "bt_Marca";
            this.bt_Marca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Marca.Size = new System.Drawing.Size(25, 27);
            this.bt_Marca.TabIndex = 206;
            this.bt_Marca.UseVisualStyleBackColor = true;
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
            // ConsMovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 276);
            this.Controls.Add(this.bt_Marca);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.grd_Dados);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_codPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsMovEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Movimentos de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn desPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn localEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusMov;
        private System.Windows.Forms.Button bt_Marca;
    }
}