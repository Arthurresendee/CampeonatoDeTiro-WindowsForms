namespace ScreenLogin
{
    partial class Form_NovoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NovoCadastro));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txt_DataDeAniversarioInvalida = new TextBox();
            txt_senhaConfirmadaInvalida = new TextBox();
            txt_senhaInvalida = new TextBox();
            txt_emailInvalido = new TextBox();
            txt_usuarioInvalido = new TextBox();
            txt_numeroDeTelefoneInvalido = new TextBox();
            txt_nomeInvalido = new TextBox();
            dtp_Nascimento = new DateTimePicker();
            label6 = new Label();
            btn_cadastrar = new Button();
            txt_confirmarSenha = new TextBox();
            txt_NomeDeUsuario = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txt_senha = new TextBox();
            label7 = new Label();
            gpb_genero = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            txt_email = new TextBox();
            txt_numeroDeTelefone = new TextBox();
            label4 = new Label();
            txt_nomeCompleto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            gpb_genero.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 461);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txt_DataDeAniversarioInvalida);
            panel2.Controls.Add(txt_senhaConfirmadaInvalida);
            panel2.Controls.Add(txt_senhaInvalida);
            panel2.Controls.Add(txt_emailInvalido);
            panel2.Controls.Add(txt_usuarioInvalido);
            panel2.Controls.Add(txt_numeroDeTelefoneInvalido);
            panel2.Controls.Add(txt_nomeInvalido);
            panel2.Controls.Add(dtp_Nascimento);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_cadastrar);
            panel2.Controls.Add(txt_confirmarSenha);
            panel2.Controls.Add(txt_NomeDeUsuario);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_senha);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(gpb_genero);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(txt_numeroDeTelefone);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_nomeCompleto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(341, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 461);
            panel2.TabIndex = 1;
            // 
            // txt_DataDeAniversarioInvalida
            // 
            txt_DataDeAniversarioInvalida.BackColor = Color.WhiteSmoke;
            txt_DataDeAniversarioInvalida.BorderStyle = BorderStyle.None;
            txt_DataDeAniversarioInvalida.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DataDeAniversarioInvalida.ForeColor = Color.Red;
            txt_DataDeAniversarioInvalida.Location = new Point(316, 219);
            txt_DataDeAniversarioInvalida.Name = "txt_DataDeAniversarioInvalida";
            txt_DataDeAniversarioInvalida.Size = new Size(163, 13);
            txt_DataDeAniversarioInvalida.TabIndex = 50;
            txt_DataDeAniversarioInvalida.Text = "Data De Aniversário Inválida";
            txt_DataDeAniversarioInvalida.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_senhaConfirmadaInvalida
            // 
            txt_senhaConfirmadaInvalida.BackColor = Color.WhiteSmoke;
            txt_senhaConfirmadaInvalida.BorderStyle = BorderStyle.None;
            txt_senhaConfirmadaInvalida.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senhaConfirmadaInvalida.ForeColor = Color.Red;
            txt_senhaConfirmadaInvalida.Location = new Point(351, 380);
            txt_senhaConfirmadaInvalida.Name = "txt_senhaConfirmadaInvalida";
            txt_senhaConfirmadaInvalida.Size = new Size(128, 13);
            txt_senhaConfirmadaInvalida.TabIndex = 49;
            txt_senhaConfirmadaInvalida.Text = "Senhas não coincidem";
            txt_senhaConfirmadaInvalida.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_senhaInvalida
            // 
            txt_senhaInvalida.BackColor = Color.WhiteSmoke;
            txt_senhaInvalida.BorderStyle = BorderStyle.None;
            txt_senhaInvalida.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senhaInvalida.ForeColor = Color.Red;
            txt_senhaInvalida.Location = new Point(82, 380);
            txt_senhaInvalida.Name = "txt_senhaInvalida";
            txt_senhaInvalida.Size = new Size(168, 13);
            txt_senhaInvalida.TabIndex = 48;
            txt_senhaInvalida.Text = "Senha deve ter 4 caracteres no mínimo";
            txt_senhaInvalida.TextAlign = HorizontalAlignment.Right;
            txt_senhaInvalida.TextChanged += txt_senhaInvalida_TextChanged;
            // 
            // txt_emailInvalido
            // 
            txt_emailInvalido.BackColor = Color.WhiteSmoke;
            txt_emailInvalido.BorderStyle = BorderStyle.None;
            txt_emailInvalido.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_emailInvalido.ForeColor = Color.Red;
            txt_emailInvalido.Location = new Point(316, 172);
            txt_emailInvalido.Name = "txt_emailInvalido";
            txt_emailInvalido.Size = new Size(163, 13);
            txt_emailInvalido.TabIndex = 47;
            txt_emailInvalido.Text = "Email Inválido";
            txt_emailInvalido.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_usuarioInvalido
            // 
            txt_usuarioInvalido.BackColor = Color.WhiteSmoke;
            txt_usuarioInvalido.BorderStyle = BorderStyle.None;
            txt_usuarioInvalido.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuarioInvalido.ForeColor = Color.Red;
            txt_usuarioInvalido.Location = new Point(283, 325);
            txt_usuarioInvalido.Name = "txt_usuarioInvalido";
            txt_usuarioInvalido.RightToLeft = RightToLeft.No;
            txt_usuarioInvalido.Size = new Size(196, 13);
            txt_usuarioInvalido.TabIndex = 46;
            txt_usuarioInvalido.Text = "Nome de usuario inválido.";
            txt_usuarioInvalido.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_numeroDeTelefoneInvalido
            // 
            txt_numeroDeTelefoneInvalido.BackColor = Color.WhiteSmoke;
            txt_numeroDeTelefoneInvalido.BorderStyle = BorderStyle.None;
            txt_numeroDeTelefoneInvalido.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_numeroDeTelefoneInvalido.ForeColor = Color.Red;
            txt_numeroDeTelefoneInvalido.Location = new Point(316, 269);
            txt_numeroDeTelefoneInvalido.Name = "txt_numeroDeTelefoneInvalido";
            txt_numeroDeTelefoneInvalido.Size = new Size(163, 13);
            txt_numeroDeTelefoneInvalido.TabIndex = 45;
            txt_numeroDeTelefoneInvalido.Text = "Numero de telefone inválido";
            txt_numeroDeTelefoneInvalido.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_nomeInvalido
            // 
            txt_nomeInvalido.BackColor = Color.WhiteSmoke;
            txt_nomeInvalido.BorderStyle = BorderStyle.None;
            txt_nomeInvalido.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeInvalido.ForeColor = Color.Red;
            txt_nomeInvalido.Location = new Point(316, 125);
            txt_nomeInvalido.Name = "txt_nomeInvalido";
            txt_nomeInvalido.Size = new Size(163, 13);
            txt_nomeInvalido.TabIndex = 43;
            txt_nomeInvalido.Text = "Nome Inválido";
            txt_nomeInvalido.TextAlign = HorizontalAlignment.Right;
            // 
            // dtp_Nascimento
            // 
            dtp_Nascimento.Location = new Point(65, 196);
            dtp_Nascimento.Name = "dtp_Nascimento";
            dtp_Nascimento.Size = new Size(414, 23);
            dtp_Nascimento.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(71, 179);
            label6.Name = "label6";
            label6.Size = new Size(111, 13);
            label6.TabIndex = 29;
            label6.Text = "Data De Nascimento";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.Highlight;
            btn_cadastrar.FlatAppearance.BorderColor = Color.Yellow;
            btn_cadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = SystemColors.HighlightText;
            btn_cadastrar.Location = new Point(211, 412);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(109, 41);
            btn_cadastrar.TabIndex = 12;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txt_confirmarSenha
            // 
            txt_confirmarSenha.Location = new Point(270, 357);
            txt_confirmarSenha.Name = "txt_confirmarSenha";
            txt_confirmarSenha.Size = new Size(209, 23);
            txt_confirmarSenha.TabIndex = 11;
            txt_confirmarSenha.UseSystemPasswordChar = true;
            // 
            // txt_NomeDeUsuario
            // 
            txt_NomeDeUsuario.Location = new Point(270, 302);
            txt_NomeDeUsuario.Name = "txt_NomeDeUsuario";
            txt_NomeDeUsuario.Size = new Size(209, 23);
            txt_NomeDeUsuario.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(270, 284);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 27;
            label5.Text = "Nome De Usuario";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(270, 339);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 33;
            label8.Text = "Confirmar Senha";
            label8.Click += label8_Click_1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(65, 357);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(187, 23);
            txt_senha.TabIndex = 10;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(65, 339);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 31;
            label7.Text = "Senha";
            // 
            // gpb_genero
            // 
            gpb_genero.Controls.Add(radioButton3);
            gpb_genero.Controls.Add(radioButton2);
            gpb_genero.Controls.Add(radioButton1);
            gpb_genero.ForeColor = SystemColors.Highlight;
            gpb_genero.Location = new Point(65, 233);
            gpb_genero.Name = "gpb_genero";
            gpb_genero.Size = new Size(187, 92);
            gpb_genero.TabIndex = 4;
            gpb_genero.TabStop = false;
            gpb_genero.Text = "Gênero";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.MenuHighlight;
            radioButton3.Location = new Point(43, 65);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(111, 19);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "Prefiro não dizer";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.MenuHighlight;
            radioButton2.Location = new Point(43, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.MenuHighlight;
            radioButton1.Location = new Point(43, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(270, 229);
            label3.Name = "label3";
            label3.Size = new Size(112, 13);
            label3.TabIndex = 22;
            label3.Text = "Numero De Telefone";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(65, 149);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(414, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_numeroDeTelefone
            // 
            txt_numeroDeTelefone.Location = new Point(270, 246);
            txt_numeroDeTelefone.Name = "txt_numeroDeTelefone";
            txt_numeroDeTelefone.Size = new Size(209, 23);
            txt_numeroDeTelefone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(65, 133);
            label4.Name = "label4";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // txt_nomeCompleto
            // 
            txt_nomeCompleto.Location = new Point(65, 102);
            txt_nomeCompleto.Name = "txt_nomeCompleto";
            txt_nomeCompleto.Size = new Size(414, 23);
            txt_nomeCompleto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(65, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 13);
            label2.TabIndex = 12;
            label2.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(195, 39);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 11;
            label1.Text = "Novo Usuário";
            // 
            // Form_NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Form_NovoCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Cadastro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gpb_genero.ResumeLayout(false);
            gpb_genero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtp_Nascimento;
        private Label label6;
        private Button btn_cadastrar;
        private TextBox txt_confirmarSenha;
        private TextBox txt_NomeDeUsuario;
        private Label label5;
        private Label label8;
        private TextBox txt_senha;
        private Label label7;
        private GroupBox gpb_genero;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox txt_email;
        private TextBox txt_numeroDeTelefone;
        private Label label4;
        private TextBox txt_nomeCompleto;
        private Label label2;
        private Label label1;
        private TextBox txt_nomeInvalido;
        private TextBox txt_emailInvalido;
        private TextBox txt_usuarioInvalido;
        private TextBox txt_numeroDeTelefoneInvalido;
        private TextBox txt_senhaConfirmadaInvalida;
        private TextBox txt_senhaInvalida;
        private TextBox txt_DataDeAniversarioInvalida;
        private PictureBox pictureBox1;
    }
}