namespace Moda_System.Formularios.Inicio
{
    partial class Acesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            this.tb_Rodape = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Usuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_senUser = new System.Windows.Forms.TextBox();
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Acessar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Rodape
            // 
            this.tb_Rodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Rodape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Rodape.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rodape.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Rodape.Location = new System.Drawing.Point(6, 224);
            this.tb_Rodape.Name = "tb_Rodape";
            this.tb_Rodape.Size = new System.Drawing.Size(393, 36);
            this.tb_Rodape.TabIndex = 100;
            this.tb_Rodape.Text = "Bem Vindo!!!";
            this.tb_Rodape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 50);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acesso ao Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(130, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuário:";
            // 
            // cb_Usuarios
            // 
            this.cb_Usuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_Usuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Usuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Usuarios.DisplayMember = "LoginUser";
            this.cb_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Usuarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cb_Usuarios.ForeColor = System.Drawing.Color.Black;
            this.cb_Usuarios.FormattingEnabled = true;
            this.cb_Usuarios.Location = new System.Drawing.Point(209, 86);
            this.cb_Usuarios.Name = "cb_Usuarios";
            this.cb_Usuarios.Size = new System.Drawing.Size(157, 27);
            this.cb_Usuarios.TabIndex = 0;
            this.cb_Usuarios.ValueMember = "UsuarioId";
            this.cb_Usuarios.SelectedIndexChanged += new System.EventHandler(this.cb_Usuarios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(130, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Senha:";
            // 
            // tb_senUser
            // 
            this.tb_senUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_senUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tb_senUser.ForeColor = System.Drawing.Color.Black;
            this.tb_senUser.Location = new System.Drawing.Point(209, 124);
            this.tb_senUser.Name = "tb_senUser";
            this.tb_senUser.Size = new System.Drawing.Size(157, 27);
            this.tb_senUser.TabIndex = 1;
            this.tb_senUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senUser.UseSystemPasswordChar = true;
            // 
            // pb_User
            // 
            this.pb_User.Image = global::Moda_System.Properties.Resources.Keys_icon;
            this.pb_User.Location = new System.Drawing.Point(6, 77);
            this.pb_User.Name = "pb_User";
            this.pb_User.Size = new System.Drawing.Size(101, 128);
            this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_User.TabIndex = 27;
            this.pb_User.TabStop = false;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_Sair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.bt_Sair.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Sair.Image = global::Moda_System.Properties.Resources.Logout_32x32;
            this.bt_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sair.Location = new System.Drawing.Point(132, 165);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(113, 36);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.Text = "     Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Acessar
            // 
            this.bt_Acessar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Acessar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Acessar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Acessar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Acessar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.bt_Acessar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Acessar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Acessar.Image")));
            this.bt_Acessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Acessar.Location = new System.Drawing.Point(265, 165);
            this.bt_Acessar.Name = "bt_Acessar";
            this.bt_Acessar.Size = new System.Drawing.Size(113, 36);
            this.bt_Acessar.TabIndex = 2;
            this.bt_Acessar.Text = "Entrar       ";
            this.bt_Acessar.UseVisualStyleBackColor = false;
            this.bt_Acessar.Click += new System.EventHandler(this.bt_Acessar_Click);
            // 
            // Acesso
            // 
            this.AcceptButton = this.bt_Acessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(403, 266);
            this.Controls.Add(this.tb_Rodape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_User);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Acessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Usuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_senUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.Acesso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Rodape;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Usuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senUser;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Acessar;
        private System.Windows.Forms.Label label1;
    }
}