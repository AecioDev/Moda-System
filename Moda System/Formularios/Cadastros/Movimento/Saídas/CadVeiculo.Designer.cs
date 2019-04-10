namespace Moda_System.Formularios.Cadastros
{
    partial class CadVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVeiculo));
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.tb_DescVeic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LPlaca = new System.Windows.Forms.TextBox();
            this.tb_NPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Motorista = new System.Windows.Forms.Button();
            this.tb_Motorista = new System.Windows.Forms.TextBox();
            this.bt_Estoque = new System.Windows.Forms.Button();
            this.tb_Estoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(126, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Descrição do Veículo";
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
            this.bt_Gravar.Location = new System.Drawing.Point(219, 233);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(162, 44);
            this.bt_Gravar.TabIndex = 5;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
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
            this.panel1.Size = new System.Drawing.Size(391, 50);
            this.panel1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 148;
            this.label5.Text = "Cadastro de Veículo";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.fechar_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(346, 9);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 33);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // tb_DescVeic
            // 
            this.tb_DescVeic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DescVeic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_DescVeic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_DescVeic.Location = new System.Drawing.Point(129, 90);
            this.tb_DescVeic.Name = "tb_DescVeic";
            this.tb_DescVeic.Size = new System.Drawing.Size(239, 24);
            this.tb_DescVeic.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Placa";
            // 
            // tb_LPlaca
            // 
            this.tb_LPlaca.BackColor = System.Drawing.SystemColors.Control;
            this.tb_LPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_LPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_LPlaca.Location = new System.Drawing.Point(13, 90);
            this.tb_LPlaca.Name = "tb_LPlaca";
            this.tb_LPlaca.Size = new System.Drawing.Size(38, 24);
            this.tb_LPlaca.TabIndex = 0;
            this.tb_LPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_NPlaca
            // 
            this.tb_NPlaca.BackColor = System.Drawing.SystemColors.Control;
            this.tb_NPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_NPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_NPlaca.Location = new System.Drawing.Point(63, 90);
            this.tb_NPlaca.Name = "tb_NPlaca";
            this.tb_NPlaca.Size = new System.Drawing.Size(47, 24);
            this.tb_NPlaca.TabIndex = 1;
            this.tb_NPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 219;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Vendedor / Motorista";
            // 
            // bt_Motorista
            // 
            this.bt_Motorista.FlatAppearance.BorderSize = 0;
            this.bt_Motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Motorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Motorista.Image = ((System.Drawing.Image)(resources.GetObject("bt_Motorista.Image")));
            this.bt_Motorista.Location = new System.Drawing.Point(343, 141);
            this.bt_Motorista.Name = "bt_Motorista";
            this.bt_Motorista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Motorista.Size = new System.Drawing.Size(25, 27);
            this.bt_Motorista.TabIndex = 3;
            this.bt_Motorista.UseVisualStyleBackColor = true;
            this.bt_Motorista.Click += new System.EventHandler(this.bt_Motorista_Click);
            // 
            // tb_Motorista
            // 
            this.tb_Motorista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Motorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Motorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Motorista.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Motorista.Location = new System.Drawing.Point(13, 143);
            this.tb_Motorista.Name = "tb_Motorista";
            this.tb_Motorista.ReadOnly = true;
            this.tb_Motorista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Motorista.Size = new System.Drawing.Size(324, 24);
            this.tb_Motorista.TabIndex = 221;
            // 
            // bt_Estoque
            // 
            this.bt_Estoque.FlatAppearance.BorderSize = 0;
            this.bt_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Estoque.Image = ((System.Drawing.Image)(resources.GetObject("bt_Estoque.Image")));
            this.bt_Estoque.Location = new System.Drawing.Point(343, 192);
            this.bt_Estoque.Name = "bt_Estoque";
            this.bt_Estoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Estoque.Size = new System.Drawing.Size(25, 27);
            this.bt_Estoque.TabIndex = 4;
            this.bt_Estoque.UseVisualStyleBackColor = true;
            this.bt_Estoque.Click += new System.EventHandler(this.bt_Estoque_Click);
            // 
            // tb_Estoque
            // 
            this.tb_Estoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Estoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Estoque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Estoque.Location = new System.Drawing.Point(15, 195);
            this.tb_Estoque.Name = "tb_Estoque";
            this.tb_Estoque.ReadOnly = true;
            this.tb_Estoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Estoque.Size = new System.Drawing.Size(322, 24);
            this.tb_Estoque.TabIndex = 224;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 222;
            this.label3.Text = "Local / Estoque";
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(395, 289);
            this.Controls.Add(this.bt_Estoque);
            this.Controls.Add(this.tb_Estoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Motorista);
            this.Controls.Add(this.tb_Motorista);
            this.Controls.Add(this.tb_LPlaca);
            this.Controls.Add(this.tb_NPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_DescVeic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadVeiculo";
            this.Load += new System.EventHandler(this.CadVeiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.TextBox tb_DescVeic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LPlaca;
        private System.Windows.Forms.TextBox tb_NPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Motorista;
        public System.Windows.Forms.TextBox tb_Motorista;
        private System.Windows.Forms.Button bt_Estoque;
        public System.Windows.Forms.TextBox tb_Estoque;
        private System.Windows.Forms.Label label3;
    }
}