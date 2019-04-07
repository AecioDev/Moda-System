namespace Moda_System.Formularios.Cadastros
{
    partial class CadVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVendedor));
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.tb_CNPJ = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Tel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Tel1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_perCom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Status.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_Status.Location = new System.Drawing.Point(323, 88);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(81, 23);
            this.cb_Status.TabIndex = 47;
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
            this.bt_Gravar.Location = new System.Drawing.Point(242, 273);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(162, 44);
            this.bt_Gravar.TabIndex = 53;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(16, 239);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(388, 23);
            this.tb_Email.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 50);
            this.panel1.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 32);
            this.label5.TabIndex = 148;
            this.label5.Text = "Cadastro do Vendedor";
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
            // tb_CNPJ
            // 
            this.tb_CNPJ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CNPJ.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CNPJ.Location = new System.Drawing.Point(159, 88);
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(132, 23);
            this.tb_CNPJ.TabIndex = 46;
            this.tb_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CNPJ_KeyPress);
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Nome.Location = new System.Drawing.Point(16, 139);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(388, 23);
            this.tb_Nome.TabIndex = 48;
            // 
            // tb_Tel2
            // 
            this.tb_Tel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Tel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Tel2.Location = new System.Drawing.Point(288, 188);
            this.tb_Tel2.Name = "tb_Tel2";
            this.tb_Tel2.Size = new System.Drawing.Size(116, 23);
            this.tb_Tel2.TabIndex = 51;
            this.tb_Tel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(320, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(142, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Telefone A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(285, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Telefone B";
            // 
            // tb_CPF
            // 
            this.tb_CPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CPF.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CPF.Location = new System.Drawing.Point(16, 89);
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(116, 23);
            this.tb_CPF.TabIndex = 45;
            this.tb_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CPF_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(156, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "CNPJ";
            // 
            // tb_Tel1
            // 
            this.tb_Tel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Tel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Tel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Tel1.Location = new System.Drawing.Point(145, 188);
            this.tb_Tel1.Name = "tb_Tel1";
            this.tb_Tel1.Size = new System.Drawing.Size(116, 23);
            this.tb_Tel1.TabIndex = 50;
            this.tb_Tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(13, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(13, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "E-mail";
            // 
            // tb_perCom
            // 
            this.tb_perCom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_perCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_perCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_perCom.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_perCom.Location = new System.Drawing.Point(16, 188);
            this.tb_perCom.Name = "tb_perCom";
            this.tb_perCom.Size = new System.Drawing.Size(74, 23);
            this.tb_perCom.TabIndex = 50;
            this.tb_perCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_perCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_perCom_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(13, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Comissão";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(89, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "%";
            // 
            // CadVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(419, 331);
            this.Controls.Add(this.tb_perCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_CNPJ);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_Tel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Tel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadVendedor";
            this.Load += new System.EventHandler(this.CadVendedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.TextBox tb_CNPJ;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Tel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Tel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_perCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}