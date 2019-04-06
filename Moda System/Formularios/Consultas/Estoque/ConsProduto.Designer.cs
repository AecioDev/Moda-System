namespace Moda_System.Formularios.Consultas
{
    partial class ConsProduto
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
            System.Windows.Forms.Label staProdLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsProduto));
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.codpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.tb_codBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_imgPro = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_referencia = new System.Windows.Forms.TextBox();
            this.cb_Marcas = new System.Windows.Forms.ComboBox();
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            this.cb_SGrupo = new System.Windows.Forms.ComboBox();
            staProdLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgPro)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // staProdLabel
            // 
            staProdLabel.AutoSize = true;
            staProdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            staProdLabel.Location = new System.Drawing.Point(4, 125);
            staProdLabel.Name = "staProdLabel";
            staProdLabel.Size = new System.Drawing.Size(49, 20);
            staProdLabel.TabIndex = 207;
            staProdLabel.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(280, 127);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 207;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(4, 158);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 20);
            label6.TabIndex = 207;
            label6.Text = "Grupo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(251, 158);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 20);
            label7.TabIndex = 207;
            label7.Text = "Sub Grupo";
            // 
            // grd_Dados
            // 
            this.grd_Dados.AllowUserToAddRows = false;
            this.grd_Dados.AllowUserToDeleteRows = false;
            this.grd_Dados.AllowUserToResizeRows = false;
            this.grd_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpro,
            this.codRef,
            this.descProd,
            this.unipro,
            this.marcaPro});
            this.grd_Dados.Location = new System.Drawing.Point(8, 184);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 30;
            this.grd_Dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Dados.Size = new System.Drawing.Size(450, 205);
            this.grd_Dados.TabIndex = 197;
            this.grd_Dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Dados_CellClick);
            // 
            // codpro
            // 
            this.codpro.HeaderText = "Cód.";
            this.codpro.Name = "codpro";
            this.codpro.ReadOnly = true;
            this.codpro.Width = 40;
            // 
            // codRef
            // 
            this.codRef.HeaderText = "Ref. / Barras";
            this.codRef.Name = "codRef";
            this.codRef.ReadOnly = true;
            // 
            // descProd
            // 
            this.descProd.HeaderText = "Produto";
            this.descProd.Name = "descProd";
            this.descProd.ReadOnly = true;
            this.descProd.Width = 180;
            // 
            // unipro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unipro.DefaultCellStyle = dataGridViewCellStyle1;
            this.unipro.HeaderText = "UN";
            this.unipro.Name = "unipro";
            this.unipro.ReadOnly = true;
            this.unipro.Width = 30;
            // 
            // marcaPro
            // 
            this.marcaPro.HeaderText = "Marca";
            this.marcaPro.Name = "marcaPro";
            this.marcaPro.ReadOnly = true;
            this.marcaPro.Width = 80;
            // 
            // cb_Status
            // 
            this.cb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_Status.Location = new System.Drawing.Point(123, 125);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(126, 24);
            this.cb_Status.TabIndex = 204;
            // 
            // tb_codBarras
            // 
            this.tb_codBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_codBarras.Location = new System.Drawing.Point(123, 95);
            this.tb_codBarras.Name = "tb_codBarras";
            this.tb_codBarras.Size = new System.Drawing.Size(126, 22);
            this.tb_codBarras.TabIndex = 198;
            this.tb_codBarras.TextChanged += new System.EventHandler(this.tb_refPro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 205;
            this.label3.Text = "Cód. de  Barras";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_nome.Location = new System.Drawing.Point(123, 67);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(335, 22);
            this.tb_nome.TabIndex = 199;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 206;
            this.label4.Text = "Descrição";
            // 
            // pb_imgPro
            // 
            this.pb_imgPro.BackColor = System.Drawing.Color.Transparent;
            this.pb_imgPro.Image = global::Moda_System.Properties.Resources.LogoModaSystem_Azul;
            this.pb_imgPro.InitialImage = global::Moda_System.Properties.Resources.LogoModaSystem_Azul;
            this.pb_imgPro.Location = new System.Drawing.Point(465, 234);
            this.pb_imgPro.Name = "pb_imgPro";
            this.pb_imgPro.Size = new System.Drawing.Size(159, 155);
            this.pb_imgPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imgPro.TabIndex = 208;
            this.pb_imgPro.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_Fechar);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 50);
            this.panel2.TabIndex = 218;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 35);
            this.label1.TabIndex = 149;
            this.label1.Text = "Consulta Produtos";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.Fechar2_48x48;
            this.bt_Fechar.Location = new System.Drawing.Point(582, 10);
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
            this.bt_Confirmar.Location = new System.Drawing.Point(487, 102);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(115, 41);
            this.bt_Confirmar.TabIndex = 219;
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
            this.bt_Atualizar.Location = new System.Drawing.Point(487, 61);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(115, 41);
            this.bt_Atualizar.TabIndex = 222;
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(487, 143);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(115, 41);
            this.bt_Cadastrar.TabIndex = 223;
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
            this.bt_Modificar.Location = new System.Drawing.Point(487, 184);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(115, 41);
            this.bt_Modificar.TabIndex = 224;
            this.bt_Modificar.Text = "Alterar    ";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Modificar.UseVisualStyleBackColor = false;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 205;
            this.label2.Text = "Referência";
            // 
            // tb_referencia
            // 
            this.tb_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_referencia.Location = new System.Drawing.Point(332, 95);
            this.tb_referencia.Name = "tb_referencia";
            this.tb_referencia.Size = new System.Drawing.Size(126, 22);
            this.tb_referencia.TabIndex = 198;
            this.tb_referencia.TextChanged += new System.EventHandler(this.tb_refPro_TextChanged);
            // 
            // cb_Marcas
            // 
            this.cb_Marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Marcas.FormattingEnabled = true;
            this.cb_Marcas.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_Marcas.Location = new System.Drawing.Point(332, 125);
            this.cb_Marcas.Name = "cb_Marcas";
            this.cb_Marcas.Size = new System.Drawing.Size(126, 24);
            this.cb_Marcas.TabIndex = 204;
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_Grupo.Location = new System.Drawing.Point(123, 156);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(126, 24);
            this.cb_Grupo.TabIndex = 204;
            // 
            // cb_SGrupo
            // 
            this.cb_SGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_SGrupo.FormattingEnabled = true;
            this.cb_SGrupo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_SGrupo.Location = new System.Drawing.Point(332, 156);
            this.cb_SGrupo.Name = "cb_SGrupo";
            this.cb_SGrupo.Size = new System.Drawing.Size(126, 24);
            this.cb_SGrupo.TabIndex = 204;
            // 
            // ConsProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(633, 396);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pb_imgPro);
            this.Controls.Add(this.grd_Dados);
            this.Controls.Add(this.cb_SGrupo);
            this.Controls.Add(label7);
            this.Controls.Add(this.cb_Grupo);
            this.Controls.Add(label6);
            this.Controls.Add(this.cb_Marcas);
            this.Controls.Add(label5);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(staProdLabel);
            this.Controls.Add(this.tb_referencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codBarras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.bt_Atualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsProduto";
            this.Load += new System.EventHandler(this.ConsProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgPro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaPro;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox tb_codBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_imgPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_referencia;
        private System.Windows.Forms.ComboBox cb_Marcas;
        private System.Windows.Forms.ComboBox cb_Grupo;
        private System.Windows.Forms.ComboBox cb_SGrupo;
    }
}