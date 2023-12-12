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
            linkLabel1 = new LinkLabel();
            label10 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            txt_usuario = new TextBox();
            panel4 = new Panel();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            txt_senha = new TextBox();
            label1 = new Label();
            btn_Login = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Login);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(340, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 461);
            panel1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(110, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 27);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "arrtechsolucoes@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(59, 408);
            label10.Name = "label10";
            label10.Size = new Size(56, 27);
            label10.TabIndex = 15;
            label10.Text = "Contate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(59, 389);
            label8.Name = "label8";
            label8.Size = new Size(252, 27);
            label8.TabIndex = 13;
            label8.Text = "Quer tratar de algum assunto ou sugerir algo?";
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(201, 278);
            button2.Name = "button2";
            button2.Size = new Size(127, 33);
            button2.TabIndex = 12;
            button2.Text = "Cadastre-se aqui";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseHover += button2_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(334, 278);
            button1.Name = "button1";
            button1.Size = new Size(151, 33);
            button1.TabIndex = 11;
            button1.Text = "Esqueci a senha :(";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(txt_usuario);
            panel3.Location = new Point(-3, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(544, 46);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(408, 16);
            label6.Name = "label6";
            label6.Size = new Size(51, 13);
            label6.TabIndex = 6;
            label6.Text = "Incorreto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.Snow;
            txt_usuario.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.ForeColor = SystemColors.WindowText;
            txt_usuario.Location = new Point(122, 10);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(342, 26);
            txt_usuario.TabIndex = 1;
            txt_usuario.MouseClick += txt_usuario_MouseClick;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(txt_senha);
            panel4.Location = new Point(-2, 211);
            panel4.Name = "panel4";
            panel4.Size = new Size(544, 46);
            panel4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(407, 16);
            label7.Name = "label7";
            label7.Size = new Size(51, 13);
            label7.TabIndex = 7;
            label7.Text = "Incorreto";
            label7.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(62, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = Color.Snow;
            txt_senha.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(121, 11);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(342, 26);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Ebrima", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(60, 89);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 7;
            label1.Text = "Entrar na minha conta";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.MenuHighlight;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.Snow;
            btn_Login.Location = new Point(60, 278);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(112, 33);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
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
            label5.Location = new Point(185, 410);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 10;
            label5.Text = "ARRTechSolucoes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 392);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Develop by";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 85);
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
            label3.Font = new Font("Ebrima", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(113, 245);
            label3.Name = "label3";
            label3.Size = new Size(180, 37);
            label3.TabIndex = 8;
            label3.Text = "ShootingClub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Ebrima", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(53, 208);
            label2.Name = "label2";
            label2.Size = new Size(205, 37);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label10;
        private Label label8;
    }
}