namespace Moda_System.Formularios.Consultas
{
    partial class ConsFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsFornecedor));
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.codVeic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descVeic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Doc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cb_Status.Location = new System.Drawing.Point(312, 65);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(78, 24);
            this.cb_Status.TabIndex = 189;
            // 
            // grd_Dados
            // 
            this.grd_Dados.AllowUserToAddRows = false;
            this.grd_Dados.AllowUserToDeleteRows = false;
            this.grd_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVeic,
            this.descVeic,
            this.codVend,
            this.numTel1,
            this.numTel2,
            this.staUser});
            this.grd_Dados.Location = new System.Drawing.Point(7, 129);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 21;
            this.grd_Dados.Size = new System.Drawing.Size(453, 137);
            this.grd_Dados.TabIndex = 185;
            // 
            // codVeic
            // 
            this.codVeic.HeaderText = "#";
            this.codVeic.Name = "codVeic";
            this.codVeic.ReadOnly = true;
            this.codVeic.Width = 40;
            // 
            // descVeic
            // 
            this.descVeic.HeaderText = "Nome";
            this.descVeic.Name = "descVeic";
            this.descVeic.ReadOnly = true;
            this.descVeic.Width = 180;
            // 
            // codVend
            // 
            this.codVend.HeaderText = "CPF/CNPJ";
            this.codVend.Name = "codVend";
            this.codVend.ReadOnly = true;
            // 
            // numTel1
            // 
            this.numTel1.HeaderText = "Telefone A";
            this.numTel1.Name = "numTel1";
            this.numTel1.ReadOnly = true;
            // 
            // numTel2
            // 
            this.numTel2.HeaderText = "Telefone B";
            this.numTel2.Name = "numTel2";
            this.numTel2.ReadOnly = true;
            // 
            // staUser
            // 
            this.staUser.HeaderText = "Status";
            this.staUser.Name = "staUser";
            this.staUser.ReadOnly = true;
            this.staUser.Width = 80;
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_nome.Location = new System.Drawing.Point(89, 95);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(301, 22);
            this.tb_nome.TabIndex = 181;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 186;
            this.label4.Text = "Nome";
            // 
            // tb_Doc
            // 
            this.tb_Doc.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Doc.Location = new System.Drawing.Point(89, 67);
            this.tb_Doc.Name = "tb_Doc";
            this.tb_Doc.Size = new System.Drawing.Size(166, 22);
            this.tb_Doc.TabIndex = 180;
            this.tb_Doc.TextChanged += new System.EventHandler(this.tb_Doc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(261, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 187;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 188;
            this.label1.Text = "CNPJ/CPF";
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
            this.panel2.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 35);
            this.label3.TabIndex = 149;
            this.label3.Text = "Consulta Fornecedores";
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
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
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
            this.bt_Confirmar.TabIndex = 182;
            this.bt_Confirmar.Text = "Confirmar";
            this.bt_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            this.bt_Confirmar.Click += new System.EventHandler(this.bt_Confirmar_Click);
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
            this.bt_Atualizar.TabIndex = 190;
            this.bt_Atualizar.Text = " Atualizar";
            this.bt_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Atualizar.UseVisualStyleBackColor = false;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
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
            this.bt_Cadastrar.TabIndex = 191;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cadastrar.UseVisualStyleBackColor = false;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
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
            this.bt_Modificar.TabIndex = 192;
            this.bt_Modificar.Text = "Alterar    ";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Modificar.UseVisualStyleBackColor = false;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // ConsFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(598, 276);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.grd_Dados);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Doc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsFornecedor";
            this.Load += new System.EventHandler(this.ConsFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVeic;
        private System.Windows.Forms.DataGridViewTextBoxColumn descVeic;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVend;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn staUser;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Label label3;
    }
}