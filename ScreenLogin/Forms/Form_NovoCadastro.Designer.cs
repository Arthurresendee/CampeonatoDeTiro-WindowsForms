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
            panel1 = new Panel();
            dtp_Nascimento = new DateTimePicker();
            lbl_usuarioExistente = new Label();
            lbl_confirmaSenha = new Label();
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
            label6 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            txt_numeroDeTelefone = new TextBox();
            label4 = new Label();
            txt_nomeCompleto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            gpb_genero.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtp_Nascimento);
            panel1.Controls.Add(lbl_usuarioExistente);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_confirmaSenha);
            panel1.Controls.Add(btn_cadastrar);
            panel1.Controls.Add(txt_confirmarSenha);
            panel1.Controls.Add(txt_NomeDeUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(gpb_genero);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_numeroDeTelefone);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_nomeCompleto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(185, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 417);
            panel1.TabIndex = 0;
            // 
            // dtp_Nascimento
            // 
            dtp_Nascimento.Location = new Point(55, 165);
            dtp_Nascimento.Name = "dtp_Nascimento";
            dtp_Nascimento.Size = new Size(358, 23);
            dtp_Nascimento.TabIndex = 18;
            // 
            // lbl_usuarioExistente
            // 
            lbl_usuarioExistente.AutoSize = true;
            lbl_usuarioExistente.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuarioExistente.ForeColor = Color.Red;
            lbl_usuarioExistente.Location = new Point(324, 292);
            lbl_usuarioExistente.Name = "lbl_usuarioExistente";
            lbl_usuarioExistente.Size = new Size(89, 12);
            lbl_usuarioExistente.TabIndex = 17;
            lbl_usuarioExistente.Text = "Usuário já existente";
            // 
            // lbl_confirmaSenha
            // 
            lbl_confirmaSenha.AutoSize = true;
            lbl_confirmaSenha.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_confirmaSenha.ForeColor = Color.Red;
            lbl_confirmaSenha.Location = new Point(284, 352);
            lbl_confirmaSenha.Name = "lbl_confirmaSenha";
            lbl_confirmaSenha.Size = new Size(110, 12);
            lbl_confirmaSenha.TabIndex = 5;
            lbl_confirmaSenha.Text = "Senha não corresponde";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.FlatAppearance.BorderColor = Color.Yellow;
            btn_cadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = SystemColors.WindowText;
            btn_cadastrar.Location = new Point(176, 370);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(109, 25);
            btn_cadastrar.TabIndex = 16;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += button1_Click;
            // 
            // txt_confirmarSenha
            // 
            txt_confirmarSenha.Location = new Point(239, 326);
            txt_confirmarSenha.Name = "txt_confirmarSenha";
            txt_confirmarSenha.Size = new Size(155, 23);
            txt_confirmarSenha.TabIndex = 15;
            // 
            // txt_NomeDeUsuario
            // 
            txt_NomeDeUsuario.Location = new Point(239, 266);
            txt_NomeDeUsuario.Name = "txt_NomeDeUsuario";
            txt_NomeDeUsuario.Size = new Size(174, 23);
            txt_NomeDeUsuario.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 248);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 7;
            label5.Text = "Nome De Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 308);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 14;
            label8.Text = "Confirmar Senha";
            label8.Click += label8_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(55, 326);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(155, 23);
            txt_senha.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 308);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Senha";
            // 
            // gpb_genero
            // 
            gpb_genero.Controls.Add(radioButton3);
            gpb_genero.Controls.Add(radioButton2);
            gpb_genero.Controls.Add(radioButton1);
            gpb_genero.ForeColor = Color.White;
            gpb_genero.Location = new Point(55, 202);
            gpb_genero.Name = "gpb_genero";
            gpb_genero.Size = new Size(155, 87);
            gpb_genero.TabIndex = 11;
            gpb_genero.TabStop = false;
            gpb_genero.Text = "Gênero";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(25, 60);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(111, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Prefiro não dizer";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(25, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 148);
            label6.Name = "label6";
            label6.Size = new Size(111, 13);
            label6.TabIndex = 9;
            label6.Text = "Data De Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 193);
            label3.Name = "label3";
            label3.Size = new Size(112, 13);
            label3.TabIndex = 3;
            label3.Text = "Numero De Telefone";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(55, 118);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(358, 23);
            txt_email.TabIndex = 6;
            // 
            // txt_numeroDeTelefone
            // 
            txt_numeroDeTelefone.Location = new Point(239, 210);
            txt_numeroDeTelefone.Name = "txt_numeroDeTelefone";
            txt_numeroDeTelefone.Size = new Size(174, 23);
            txt_numeroDeTelefone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 101);
            label4.Name = "label4";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // txt_nomeCompleto
            // 
            txt_nomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            txt_nomeCompleto.Location = new Point(55, 71);
            txt_nomeCompleto.Name = "txt_nomeCompleto";
            txt_nomeCompleto.Size = new Size(358, 23);
            txt_nomeCompleto.TabIndex = 2;
            txt_nomeCompleto.TextChanged += txt_nomeCompleto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 13);
            label2.TabIndex = 1;
            label2.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(160, 8);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Novo Usuário";
            label1.Click += label1_Click;
            // 
            // Form_NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(830, 465);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Form_NovoCadastro";
            Text = "Novo Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpb_genero.ResumeLayout(false);
            gpb_genero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private TextBox txt_NomeDeUsuario;
        private Label label5;
        private TextBox txt_email;
        private Label label4;
        private TextBox txt_numeroDeTelefone;
        private Label label3;
        private TextBox txt_nomeCompleto;
        private Label label2;
        private GroupBox gpb_genero;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txt_confirmarSenha;
        private Label label8;
        private TextBox txt_senha;
        private Label label7;
        private Button btn_cadastrar;
        private Label lbl_confirmaSenha;
        private Label lbl_usuarioExistente;
        private DateTimePicker dtp_Nascimento;
    }
}