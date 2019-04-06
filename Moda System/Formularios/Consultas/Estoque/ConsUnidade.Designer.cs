﻿namespace Moda_System.Formularios.Consultas
{
    partial class ConsUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsUnidade));
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Sigla = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.codLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Dados
            // 
            this.grd_Dados.AllowUserToAddRows = false;
            this.grd_Dados.AllowUserToDeleteRows = false;
            this.grd_Dados.AutoGenerateColumns = false;
            this.grd_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocal,
            this.descLocal,
            this.siglaUni});
            this.grd_Dados.DataSource = this.unidadeBindingSource;
            this.grd_Dados.Location = new System.Drawing.Point(13, 113);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 21;
            this.grd_Dados.Size = new System.Drawing.Size(293, 140);
            this.grd_Dados.TabIndex = 205;
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataSource = typeof(Moda_System.Classes.Unidade);
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_nome.Location = new System.Drawing.Point(13, 85);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(208, 22);
            this.tb_nome.TabIndex = 200;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 206;
            this.label4.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(224, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "Sigla";
            // 
            // tb_Sigla
            // 
            this.tb_Sigla.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Sigla.Location = new System.Drawing.Point(227, 85);
            this.tb_Sigla.Name = "tb_Sigla";
            this.tb_Sigla.Size = new System.Drawing.Size(79, 22);
            this.tb_Sigla.TabIndex = 200;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Fechar);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 50);
            this.panel2.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 35);
            this.label3.TabIndex = 149;
            this.label3.Text = "Consulta Unidades";
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
            this.bt_Fechar.Location = new System.Drawing.Point(387, 10);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 31);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Atualizar.FlatAppearance.BorderSize = 0;
            this.bt_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Atualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualizar.Image = global::Moda_System.Properties.Resources.DBPesquisar32x32;
            this.bt_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atualizar.Location = new System.Drawing.Point(311, 118);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(115, 41);
            this.bt_Atualizar.TabIndex = 209;
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(311, 165);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(115, 41);
            this.bt_Cadastrar.TabIndex = 210;
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
            this.bt_Modificar.Location = new System.Drawing.Point(311, 212);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(115, 41);
            this.bt_Modificar.TabIndex = 211;
            this.bt_Modificar.Text = "Alterar    ";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Modificar.UseVisualStyleBackColor = false;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
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
            this.bt_Confirmar.Location = new System.Drawing.Point(311, 71);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(115, 41);
            this.bt_Confirmar.TabIndex = 208;
            this.bt_Confirmar.Text = "Confirmar";
            this.bt_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            this.bt_Confirmar.Click += new System.EventHandler(this.bt_Confirmar_Click);
            // 
            // codLocal
            // 
            this.codLocal.DataPropertyName = "UnidadeId";
            this.codLocal.HeaderText = "#";
            this.codLocal.Name = "codLocal";
            this.codLocal.ReadOnly = true;
            this.codLocal.Width = 40;
            // 
            // descLocal
            // 
            this.descLocal.DataPropertyName = "DescUnidade";
            this.descLocal.HeaderText = "Nome";
            this.descLocal.Name = "descLocal";
            this.descLocal.ReadOnly = true;
            this.descLocal.Width = 180;
            // 
            // siglaUni
            // 
            this.siglaUni.DataPropertyName = "SiglaUnidade";
            this.siglaUni.HeaderText = "Sigla";
            this.siglaUni.Name = "siglaUni";
            this.siglaUni.ReadOnly = true;
            this.siglaUni.Width = 50;
            // 
            // ConsUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(438, 265);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grd_Dados);
            this.Controls.Add(this.tb_Sigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsUnidade";
            this.Load += new System.EventHandler(this.ConsUnidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Sigla;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaUni;
    }
}