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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            panel1 = new Panel();
            linklbl_cadastro = new LinkLabel();
            linklbl_recuperaSenha = new LinkLabel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_erroLogin2 = new Label();
            txt_senha = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_erroLogin = new Label();
            txt_usuario = new TextBox();
            label1 = new Label();
            btn_Login = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linklbl_cadastro);
            panel1.Controls.Add(linklbl_recuperaSenha);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Login);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(340, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 461);
            panel1.TabIndex = 11;
            // 
            // linklbl_cadastro
            // 
            linklbl_cadastro.ActiveLinkColor = SystemColors.MenuHighlight;
            linklbl_cadastro.AutoSize = true;
            linklbl_cadastro.BackColor = Color.Maroon;
            linklbl_cadastro.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_cadastro.LinkColor = Color.White;
            linklbl_cadastro.Location = new Point(261, 318);
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
            linklbl_recuperaSenha.BackColor = Color.Maroon;
            linklbl_recuperaSenha.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_recuperaSenha.LinkColor = Color.White;
            linklbl_recuperaSenha.Location = new Point(366, 318);
            linklbl_recuperaSenha.Name = "linklbl_recuperaSenha";
            linklbl_recuperaSenha.Size = new Size(98, 12);
            linklbl_recuperaSenha.TabIndex = 0;
            linklbl_recuperaSenha.TabStop = true;
            linklbl_recuperaSenha.Text = "Esqueceu sua senha?";
            linklbl_recuperaSenha.LinkClicked += linklbl_recuperaSenha_LinkClicked;
            linklbl_recuperaSenha.MouseClick += linklbl_recuperaSenha_MouseClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lbl_erroLogin2);
            panel4.Controls.Add(txt_senha);
            panel4.Location = new Point(-2, 247);
            panel4.Name = "panel4";
            panel4.Size = new Size(544, 34);
            panel4.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // lbl_erroLogin2
            // 
            lbl_erroLogin2.AutoSize = true;
            lbl_erroLogin2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_erroLogin2.ForeColor = Color.Red;
            lbl_erroLogin2.Location = new Point(416, 9);
            lbl_erroLogin2.Name = "lbl_erroLogin2";
            lbl_erroLogin2.Size = new Size(60, 15);
            lbl_erroLogin2.TabIndex = 6;
            lbl_erroLogin2.Text = "Incorreto";
            // 
            // txt_senha
            // 
            txt_senha.BackColor = Color.Snow;
            txt_senha.Location = new Point(76, 6);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(411, 23);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lbl_erroLogin);
            panel3.Controls.Add(txt_usuario);
            panel3.Location = new Point(-4, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(544, 34);
            panel3.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lbl_erroLogin
            // 
            lbl_erroLogin.AutoSize = true;
            lbl_erroLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_erroLogin.ForeColor = Color.Red;
            lbl_erroLogin.Location = new Point(418, 9);
            lbl_erroLogin.Name = "lbl_erroLogin";
            lbl_erroLogin.Size = new Size(60, 15);
            lbl_erroLogin.TabIndex = 4;
            lbl_erroLogin.Text = "Incorreto";
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.Snow;
            txt_usuario.ForeColor = SystemColors.WindowText;
            txt_usuario.Location = new Point(78, 6);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(411, 23);
            txt_usuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(39, 140);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 7;
            label1.Text = "Entrar na minha conta";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ActiveCaptionText;
            btn_Login.Location = new Point(26, 305);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 33);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 461);
            panel2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 383);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "ARR Tech";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 368);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Develop by";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(113, 234);
            label3.Name = "label3";
            label3.Size = new Size(180, 37);
            label3.TabIndex = 8;
            label3.Text = "ShootingClub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(25, 197);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 7;
            label2.Text = "Welcome to the";
            label2.Click += label2_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(884, 461);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Login;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private LinkLabel linklbl_recuperaSenha;
        private LinkLabel linklbl_cadastro;
        private Label lbl_erroLogin2;
        private Label lbl_erroLogin;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}