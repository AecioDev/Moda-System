namespace Moda_System.Formularios.Cadastros
{
    partial class TabelaPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaPreco));
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.cb_tipPreco = new System.Windows.Forms.ComboBox();
            this.tb_lucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_desc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bt_Gravar.Location = new System.Drawing.Point(248, 151);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(160, 45);
            this.bt_Gravar.TabIndex = 435;
            this.bt_Gravar.Text = "Gravar Dados";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // cb_tipPreco
            // 
            this.cb_tipPreco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_tipPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cb_tipPreco.FormattingEnabled = true;
            this.cb_tipPreco.Items.AddRange(new object[] {
            "Se Maior",
            "Se Menor",
            "Não Calcular"});
            this.cb_tipPreco.Location = new System.Drawing.Point(190, 101);
            this.cb_tipPreco.Name = "cb_tipPreco";
            this.cb_tipPreco.Size = new System.Drawing.Size(194, 28);
            this.cb_tipPreco.TabIndex = 436;
            // 
            // tb_lucro
            // 
            this.tb_lucro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_lucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_lucro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_lucro.Location = new System.Drawing.Point(83, 141);
            this.tb_lucro.Name = "tb_lucro";
            this.tb_lucro.Size = new System.Drawing.Size(85, 23);
            this.tb_lucro.TabIndex = 431;
            this.tb_lucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lucro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(171, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 433;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 434;
            this.label2.Text = "Margem";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_descricao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_descricao.Location = new System.Drawing.Point(83, 67);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(301, 23);
            this.tb_descricao.TabIndex = 430;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 435;
            this.label5.Text = "Calcular Preço na Entrada";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_desc.Location = new System.Drawing.Point(25, 72);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(41, 15);
            this.lb_desc.TabIndex = 429;
            this.lb_desc.Text = "Tabela";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 50);
            this.panel1.TabIndex = 432;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 152;
            this.label4.Text = "Tabela de Preço";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Fechar.Image = global::Moda_System.Properties.Resources.fechar_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(379, 12);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(27, 27);
            this.bt_Fechar.TabIndex = 151;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // TabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(416, 210);
            this.Controls.Add(this.cb_tipPreco);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.tb_lucro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabelaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelaPreco";
            this.Load += new System.EventHandler(this.TabelaPreco_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_tipPreco;
        private System.Windows.Forms.TextBox tb_lucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Fechar;
    }
}