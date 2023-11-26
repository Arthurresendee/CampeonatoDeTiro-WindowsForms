namespace ScreenLogin
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbl_erroLogin2 = new Label();
            lbl_erroLogin = new Label();
            linklbl_cadastro = new LinkLabel();
            linklbl_recuperaSenha = new LinkLabel();
            btn_Login = new Button();
            txt_usuario = new TextBox();
            label1 = new Label();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            lbl_usuario = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_erroLogin2);
            panel1.Controls.Add(lbl_erroLogin);
            panel1.Controls.Add(linklbl_cadastro);
            panel1.Controls.Add(linklbl_recuperaSenha);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(lbl_usuario);
            panel1.Location = new Point(435, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 357);
            panel1.TabIndex = 11;
            // 
            // lbl_erroLogin2
            // 
            lbl_erroLogin2.AutoSize = true;
            lbl_erroLogin2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_erroLogin2.Location = new Point(129, 225);
            lbl_erroLogin2.Name = "lbl_erroLogin2";
            lbl_erroLogin2.Size = new Size(114, 12);
            lbl_erroLogin2.TabIndex = 6;
            lbl_erroLogin2.Text = "Email ou senha incorreto";
            // 
            // lbl_erroLogin
            // 
            lbl_erroLogin.AutoSize = true;
            lbl_erroLogin.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_erroLogin.Location = new Point(129, 155);
            lbl_erroLogin.Name = "lbl_erroLogin";
            lbl_erroLogin.Size = new Size(114, 12);
            lbl_erroLogin.TabIndex = 4;
            lbl_erroLogin.Text = "Email ou senha incorreto";
            // 
            // linklbl_cadastro
            // 
            linklbl_cadastro.ActiveLinkColor = SystemColors.MenuHighlight;
            linklbl_cadastro.AutoSize = true;
            linklbl_cadastro.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_cadastro.LinkColor = Color.White;
            linklbl_cadastro.Location = new Point(40, 317);
            linklbl_cadastro.Name = "linklbl_cadastro";
            linklbl_cadastro.Size = new Size(99, 12);
            linklbl_cadastro.TabIndex = 0;
            linklbl_cadastro.TabStop = true;
            linklbl_cadastro.Text = "Não Possui Cadastro?";
            linklbl_cadastro.LinkClicked += linklbl_cadastro_LinkClicked;
            // 
            // linklbl_recuperaSenha
            // 
            linklbl_recuperaSenha.ActiveLinkColor = SystemColors.MenuHighlight;
            linklbl_recuperaSenha.AutoSize = true;
            linklbl_recuperaSenha.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_recuperaSenha.LinkColor = Color.White;
            linklbl_recuperaSenha.Location = new Point(147, 317);
            linklbl_recuperaSenha.Name = "linklbl_recuperaSenha";
            linklbl_recuperaSenha.Size = new Size(98, 12);
            linklbl_recuperaSenha.TabIndex = 0;
            linklbl_recuperaSenha.TabStop = true;
            linklbl_recuperaSenha.Text = "Esqueceu sua senha?";
            linklbl_recuperaSenha.LinkClicked += linklbl_recuperaSenha_LinkClicked;
            linklbl_recuperaSenha.MouseClick += linklbl_recuperaSenha_MouseClick;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ActiveCaptionText;
            btn_Login.Location = new Point(87, 266);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 33);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.ForeColor = SystemColors.WindowText;
            txt_usuario.Location = new Point(37, 129);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(206, 23);
            txt_usuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(87, 26);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(37, 199);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(206, 23);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = SystemColors.ControlText;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.ForeColor = Color.FloralWhite;
            lbl_senha.Location = new Point(37, 175);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(53, 21);
            lbl_senha.TabIndex = 0;
            lbl_senha.Text = "Senha";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = SystemColors.ControlText;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = Color.FloralWhite;
            lbl_usuario.Location = new Point(37, 105);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(64, 21);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(135, 200);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(244, 46);
            label5.TabIndex = 0;
            label5.Text = "shooting Club";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlText;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(77, 162);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(210, 46);
            label4.TabIndex = 0;
            label4.Text = "Welcome to";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form_Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Login;
        private TextBox txt_usuario;
        private Label label1;
        private TextBox txt_senha;
        private Label lbl_senha;
        private Label lbl_usuario;
        private Label label5;
        private Label label4;
        private LinkLabel linklbl_recuperaSenha;
        private LinkLabel linklbl_cadastro;
        private Label lbl_erroLogin2;
        private Label lbl_erroLogin;
    }
}