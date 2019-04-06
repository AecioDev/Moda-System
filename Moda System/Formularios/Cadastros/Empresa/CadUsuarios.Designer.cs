namespace Moda_System.Formularios.Cadastros
{
    partial class CadUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_PerfilUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_EmailUser = new System.Windows.Forms.TextBox();
            this.tb_NomeUser = new System.Windows.Forms.TextBox();
            this.lb_ConfSenha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_LoginUser = new System.Windows.Forms.TextBox();
            this.tb_ConfSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_SenhaUser = new System.Windows.Forms.TextBox();
            this.bt_trcSenha = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.bt_verConfSenha = new System.Windows.Forms.Button();
            this.bt_verSenha = new System.Windows.Forms.Button();
            this.bt_verificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 50);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 27);
            this.label3.TabIndex = 148;
            this.label3.Text = "Cadastro do Usuário";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.fechar_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(355, 8);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 33);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(2, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "Usuário";
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Status.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_Status.Location = new System.Drawing.Point(324, 116);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(69, 23);
            this.cb_Status.TabIndex = 2;
            // 
            // cb_PerfilUser
            // 
            this.cb_PerfilUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_PerfilUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_PerfilUser.FormattingEnabled = true;
            this.cb_PerfilUser.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cb_PerfilUser.Location = new System.Drawing.Point(263, 210);
            this.cb_PerfilUser.Name = "cb_PerfilUser";
            this.cb_PerfilUser.Size = new System.Drawing.Size(130, 23);
            this.cb_PerfilUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nome";
            // 
            // tb_EmailUser
            // 
            this.tb_EmailUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_EmailUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_EmailUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_EmailUser.Location = new System.Drawing.Point(17, 159);
            this.tb_EmailUser.Name = "tb_EmailUser";
            this.tb_EmailUser.Size = new System.Drawing.Size(376, 23);
            this.tb_EmailUser.TabIndex = 3;
            // 
            // tb_NomeUser
            // 
            this.tb_NomeUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_NomeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NomeUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_NomeUser.Location = new System.Drawing.Point(17, 117);
            this.tb_NomeUser.Name = "tb_NomeUser";
            this.tb_NomeUser.Size = new System.Drawing.Size(301, 23);
            this.tb_NomeUser.TabIndex = 1;
            // 
            // lb_ConfSenha
            // 
            this.lb_ConfSenha.AutoSize = true;
            this.lb_ConfSenha.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConfSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_ConfSenha.Location = new System.Drawing.Point(260, 245);
            this.lb_ConfSenha.Name = "lb_ConfSenha";
            this.lb_ConfSenha.Size = new System.Drawing.Size(97, 16);
            this.lb_ConfSenha.TabIndex = 44;
            this.lb_ConfSenha.Text = "Confirmar Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(321, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(14, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(260, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Perfil";
            // 
            // tb_LoginUser
            // 
            this.tb_LoginUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_LoginUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LoginUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_LoginUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_LoginUser.Location = new System.Drawing.Point(17, 211);
            this.tb_LoginUser.Name = "tb_LoginUser";
            this.tb_LoginUser.Size = new System.Drawing.Size(130, 23);
            this.tb_LoginUser.TabIndex = 4;
            // 
            // tb_ConfSenha
            // 
            this.tb_ConfSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ConfSenha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_ConfSenha.Location = new System.Drawing.Point(263, 261);
            this.tb_ConfSenha.Name = "tb_ConfSenha";
            this.tb_ConfSenha.Size = new System.Drawing.Size(130, 23);
            this.tb_ConfSenha.TabIndex = 7;
            this.tb_ConfSenha.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(14, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Login";
            // 
            // tb_SenhaUser
            // 
            this.tb_SenhaUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_SenhaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SenhaUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_SenhaUser.Location = new System.Drawing.Point(17, 261);
            this.tb_SenhaUser.Name = "tb_SenhaUser";
            this.tb_SenhaUser.Size = new System.Drawing.Size(130, 23);
            this.tb_SenhaUser.TabIndex = 6;
            this.tb_SenhaUser.UseSystemPasswordChar = true;
            // 
            // bt_trcSenha
            // 
            this.bt_trcSenha.BackColor = System.Drawing.Color.Transparent;
            this.bt_trcSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_trcSenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_trcSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_trcSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trcSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_trcSenha.Image = global::Moda_System.Properties.Resources.Cadeado_32x32;
            this.bt_trcSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_trcSenha.Location = new System.Drawing.Point(17, 300);
            this.bt_trcSenha.Name = "bt_trcSenha";
            this.bt_trcSenha.Size = new System.Drawing.Size(157, 44);
            this.bt_trcSenha.TabIndex = 8;
            this.bt_trcSenha.Text = "Trocar Senha";
            this.bt_trcSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_trcSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_trcSenha.UseVisualStyleBackColor = false;
            this.bt_trcSenha.Click += new System.EventHandler(this.bt_trcSenha_Click);
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
            this.bt_Gravar.Location = new System.Drawing.Point(237, 300);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(156, 44);
            this.bt_Gravar.TabIndex = 8;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // bt_verConfSenha
            // 
            this.bt_verConfSenha.BackColor = System.Drawing.Color.Transparent;
            this.bt_verConfSenha.FlatAppearance.BorderSize = 0;
            this.bt_verConfSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_verConfSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_verConfSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_verConfSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_verConfSenha.Image = global::Moda_System.Properties.Resources.eye_32x32;
            this.bt_verConfSenha.Location = new System.Drawing.Point(364, 240);
            this.bt_verConfSenha.Name = "bt_verConfSenha";
            this.bt_verConfSenha.Size = new System.Drawing.Size(29, 22);
            this.bt_verConfSenha.TabIndex = 146;
            this.bt_verConfSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_verConfSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_verConfSenha.UseVisualStyleBackColor = false;
            this.bt_verConfSenha.MouseEnter += new System.EventHandler(this.bt_verSenha_MouseEnter);
            this.bt_verConfSenha.MouseLeave += new System.EventHandler(this.bt_verSenha_MouseLeave);
            // 
            // bt_verSenha
            // 
            this.bt_verSenha.BackColor = System.Drawing.Color.Transparent;
            this.bt_verSenha.FlatAppearance.BorderSize = 0;
            this.bt_verSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_verSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_verSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_verSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_verSenha.Image = global::Moda_System.Properties.Resources.eye_32x32;
            this.bt_verSenha.Location = new System.Drawing.Point(118, 240);
            this.bt_verSenha.Name = "bt_verSenha";
            this.bt_verSenha.Size = new System.Drawing.Size(29, 22);
            this.bt_verSenha.TabIndex = 146;
            this.bt_verSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_verSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_verSenha.UseVisualStyleBackColor = false;
            this.bt_verSenha.MouseEnter += new System.EventHandler(this.bt_verSenha_MouseEnter);
            this.bt_verSenha.MouseLeave += new System.EventHandler(this.bt_verSenha_MouseLeave);
            // 
            // bt_verificar
            // 
            this.bt_verificar.BackColor = System.Drawing.Color.Transparent;
            this.bt_verificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_verificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_verificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_verificar.Image = global::Moda_System.Properties.Resources.eye_32x32;
            this.bt_verificar.Location = new System.Drawing.Point(17, 300);
            this.bt_verificar.Name = "bt_verificar";
            this.bt_verificar.Size = new System.Drawing.Size(157, 44);
            this.bt_verificar.TabIndex = 8;
            this.bt_verificar.Text = "Verificar";
            this.bt_verificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_verificar.UseVisualStyleBackColor = false;
            this.bt_verificar.Click += new System.EventHandler(this.bt_verificar_Click);
            // 
            // CadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(408, 350);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.bt_trcSenha);
            this.Controls.Add(this.cb_PerfilUser);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_verConfSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_verSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_EmailUser);
            this.Controls.Add(this.bt_verificar);
            this.Controls.Add(this.tb_NomeUser);
            this.Controls.Add(this.tb_SenhaUser);
            this.Controls.Add(this.lb_ConfSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ConfSenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_LoginUser);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadIni";
            this.Load += new System.EventHandler(this.CadUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NomeUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_LoginUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_SenhaUser;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button bt_verSenha;
        private System.Windows.Forms.ComboBox cb_PerfilUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_EmailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_verConfSenha;
        private System.Windows.Forms.Label lb_ConfSenha;
        private System.Windows.Forms.TextBox tb_ConfSenha;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_trcSenha;
        private System.Windows.Forms.Button bt_verificar;
        private System.Windows.Forms.Label label3;
    }
}