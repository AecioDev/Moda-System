namespace Moda_System.Formularios.Cadastros
{
    partial class CadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFornecedor));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Contato = new System.Windows.Forms.TextBox();
            this.lb_ConfSenha = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Tel1 = new System.Windows.Forms.TextBox();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Tel2 = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.TextBox();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(2, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fornecedor";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 50);
            this.panel1.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 32);
            this.label5.TabIndex = 148;
            this.label5.Text = "Cadastro do Fornecedor";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.fechar_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(370, 8);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 33);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Status.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_Status.Location = new System.Drawing.Point(322, 110);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(81, 23);
            this.cb_Status.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nome";
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(15, 285);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(388, 23);
            this.tb_Email.TabIndex = 8;
            // 
            // tb_Contato
            // 
            this.tb_Contato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Contato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Contato.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Contato.Location = new System.Drawing.Point(15, 197);
            this.tb_Contato.Name = "tb_Contato";
            this.tb_Contato.Size = new System.Drawing.Size(388, 23);
            this.tb_Contato.TabIndex = 5;
            // 
            // lb_ConfSenha
            // 
            this.lb_ConfSenha.AutoSize = true;
            this.lb_ConfSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConfSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ConfSenha.Location = new System.Drawing.Point(12, 181);
            this.lb_ConfSenha.Name = "lb_ConfSenha";
            this.lb_ConfSenha.Size = new System.Drawing.Size(104, 16);
            this.lb_ConfSenha.TabIndex = 44;
            this.lb_ConfSenha.Text = "Nome do Contato";
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Nome.Location = new System.Drawing.Point(15, 155);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(388, 23);
            this.tb_Nome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(319, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(155, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Telefone B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(155, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "CNPJ";
            // 
            // tb_Tel1
            // 
            this.tb_Tel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Tel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Tel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Tel1.Location = new System.Drawing.Point(15, 241);
            this.tb_Tel1.Name = "tb_Tel1";
            this.tb_Tel1.Size = new System.Drawing.Size(116, 23);
            this.tb_Tel1.TabIndex = 6;
            this.tb_Tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.SetToolTip(this.tb_Tel1, "Sem TRAÇOS e sem PONTOS");
            // 
            // tb_CPF
            // 
            this.tb_CPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CPF.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CPF.Location = new System.Drawing.Point(15, 111);
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(116, 23);
            this.tb_CPF.TabIndex = 1;
            this.tb_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.SetToolTip(this.tb_CPF, "Sem TRAÇOS e sem PONTOS");
            this.tb_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Telefone A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(12, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "CPF";
            // 
            // tb_Tel2
            // 
            this.tb_Tel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Tel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Tel2.Location = new System.Drawing.Point(158, 241);
            this.tb_Tel2.Name = "tb_Tel2";
            this.tb_Tel2.Size = new System.Drawing.Size(116, 23);
            this.tb_Tel2.TabIndex = 7;
            this.tb_Tel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.SetToolTip(this.tb_Tel2, "Sem TRAÇOS e sem PONTOS");
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CNPJ.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CNPJ.Location = new System.Drawing.Point(158, 110);
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(132, 23);
            this.tb_CNPJ.TabIndex = 2;
            this.tb_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.SetToolTip(this.tb_CNPJ, "Sem TRAÇOS e sem PONTOS");
            this.tb_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CNPJ_KeyPress);
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Gravar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gravar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Gravar.Image = global::Moda_System.Properties.Resources.check1_32x32;
            this.bt_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Gravar.Location = new System.Drawing.Point(241, 316);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(162, 44);
            this.bt_Gravar.TabIndex = 9;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(419, 370);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Contato);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_ConfSenha);
            this.Controls.Add(this.tb_CNPJ);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_Tel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Tel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadFornecedor";
            this.Load += new System.EventHandler(this.CadFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_ConfSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.TextBox tb_Contato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_CNPJ;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Tel1;
        private System.Windows.Forms.ToolTip info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Tel2;
        private System.Windows.Forms.Label label5;
    }
}