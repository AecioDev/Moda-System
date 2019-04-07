namespace Moda_System.Formularios.Cadastros
{
    partial class Precos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Precos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.tb_descProg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_valPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_despro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_desc = new System.Windows.Forms.Label();
            this.bt_AltTabPre = new System.Windows.Forms.Button();
            this.bt_cadTabPre = new System.Windows.Forms.Button();
            this.cb_tabPre = new System.Windows.Forms.ComboBox();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_cuspro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_margem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 50);
            this.panel1.TabIndex = 418;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 150;
            this.label5.Text = "Cadastro de Preço";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.fechar_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(381, 12);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(27, 27);
            this.bt_Fechar.TabIndex = 149;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // tb_descProg
            // 
            this.tb_descProg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_descProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_descProg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_descProg.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_descProg.Location = new System.Drawing.Point(305, 199);
            this.tb_descProg.Name = "tb_descProg";
            this.tb_descProg.Size = new System.Drawing.Size(95, 23);
            this.tb_descProg.TabIndex = 6;
            this.tb_descProg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_descProg_KeyPress);
            this.tb_descProg.Leave += new System.EventHandler(this.tb_valPro_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(302, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 426;
            this.label3.Text = "Desconto Max.";
            // 
            // tb_valPro
            // 
            this.tb_valPro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_valPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_valPro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_valPro.Location = new System.Drawing.Point(145, 199);
            this.tb_valPro.Name = "tb_valPro";
            this.tb_valPro.Size = new System.Drawing.Size(122, 23);
            this.tb_valPro.TabIndex = 5;
            this.tb_valPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valPro_KeyPress);
            this.tb_valPro.Leave += new System.EventHandler(this.tb_valPro_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(142, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 427;
            this.label2.Text = "Valor do Produto";
            // 
            // tb_despro
            // 
            this.tb_despro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_despro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_despro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_despro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_despro.Location = new System.Drawing.Point(84, 9);
            this.tb_despro.Name = "tb_despro";
            this.tb_despro.ReadOnly = true;
            this.tb_despro.Size = new System.Drawing.Size(301, 23);
            this.tb_despro.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 428;
            this.label4.Text = "Produto";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_desc.Location = new System.Drawing.Point(17, 142);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(53, 21);
            this.lb_desc.TabIndex = 429;
            this.lb_desc.Text = "Tabela";
            // 
            // bt_AltTabPre
            // 
            this.bt_AltTabPre.FlatAppearance.BorderSize = 0;
            this.bt_AltTabPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AltTabPre.Image = global::Moda_System.Properties.Resources.edit_32x32;
            this.bt_AltTabPre.Location = new System.Drawing.Point(361, 139);
            this.bt_AltTabPre.Name = "bt_AltTabPre";
            this.bt_AltTabPre.Size = new System.Drawing.Size(33, 31);
            this.bt_AltTabPre.TabIndex = 4;
            this.bt_AltTabPre.UseVisualStyleBackColor = true;
            this.bt_AltTabPre.Click += new System.EventHandler(this.bt_AltTabPre_Click);
            // 
            // bt_cadTabPre
            // 
            this.bt_cadTabPre.FlatAppearance.BorderSize = 0;
            this.bt_cadTabPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadTabPre.Image = global::Moda_System.Properties.Resources.mais_32x32;
            this.bt_cadTabPre.Location = new System.Drawing.Point(322, 139);
            this.bt_cadTabPre.Name = "bt_cadTabPre";
            this.bt_cadTabPre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_cadTabPre.Size = new System.Drawing.Size(33, 31);
            this.bt_cadTabPre.TabIndex = 3;
            this.bt_cadTabPre.UseVisualStyleBackColor = true;
            this.bt_cadTabPre.Click += new System.EventHandler(this.bt_cadTabPre_Click);
            // 
            // cb_tabPre
            // 
            this.cb_tabPre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_tabPre.DisplayMember = "desctabpre";
            this.cb_tabPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tabPre.FormattingEnabled = true;
            this.cb_tabPre.Location = new System.Drawing.Point(76, 140);
            this.cb_tabPre.Name = "cb_tabPre";
            this.cb_tabPre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_tabPre.Size = new System.Drawing.Size(240, 28);
            this.cb_tabPre.TabIndex = 2;
            this.cb_tabPre.ValueMember = "seqtabpre";
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Gravar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gravar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Gravar.Image = global::Moda_System.Properties.Resources.check1_32x32;
            this.bt_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Gravar.Location = new System.Drawing.Point(244, 233);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(156, 45);
            this.bt_Gravar.TabIndex = 7;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.tb_cuspro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_despro);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(9, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 67);
            this.panel2.TabIndex = 430;
            // 
            // tb_cuspro
            // 
            this.tb_cuspro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_cuspro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cuspro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_cuspro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_cuspro.Location = new System.Drawing.Point(167, 38);
            this.tb_cuspro.Name = "tb_cuspro";
            this.tb_cuspro.ReadOnly = true;
            this.tb_cuspro.Size = new System.Drawing.Size(218, 23);
            this.tb_cuspro.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 428;
            this.label1.Text = "Custo de Reposição";
            // 
            // tb_margem
            // 
            this.tb_margem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_margem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_margem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_margem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_margem.Location = new System.Drawing.Point(22, 199);
            this.tb_margem.Name = "tb_margem";
            this.tb_margem.Size = new System.Drawing.Size(85, 23);
            this.tb_margem.TabIndex = 5;
            this.tb_margem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valPro_KeyPress);
            this.tb_margem.Leave += new System.EventHandler(this.tb_margem_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(18, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 427;
            this.label6.Text = "Margem Pretendida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(106, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 427;
            this.label7.Text = "%";
            // 
            // Precos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(419, 291);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_AltTabPre);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_cadTabPre);
            this.Controls.Add(this.cb_tabPre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.tb_descProg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_margem);
            this.Controls.Add(this.tb_valPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Precos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precos";
            this.Load += new System.EventHandler(this.Precos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_descProg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_valPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_despro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button bt_AltTabPre;
        private System.Windows.Forms.Button bt_cadTabPre;
        private System.Windows.Forms.ComboBox cb_tabPre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_cuspro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_margem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}