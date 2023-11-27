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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(154, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 372);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(160, 17);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Novo Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 63);
            label2.Name = "label2";
            label2.Size = new Size(90, 13);
            label2.TabIndex = 1;
            label2.Text = "Nome Completo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 161);
            label3.Name = "label3";
            label3.Size = new Size(112, 13);
            label3.TabIndex = 3;
            label3.Text = "Numero De Telefone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 110);
            label4.Name = "label4";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(55, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 311);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 7;
            label5.Text = "Nome De Usuario";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(239, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(239, 213);
            label6.Name = "label6";
            label6.Size = new Size(111, 13);
            label6.TabIndex = 9;
            label6.Text = "Data De Nascimento";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(55, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 146);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(30, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(111, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Prefiro não dizer";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(239, 279);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 261);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Senha";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(239, 329);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 23);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 311);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 14;
            label8.Text = "Confirmar Senha";
            label8.Click += label8_Click;
            // 
            // Form_NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(830, 465);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Form_NovoCadastro";
            Text = "Novo Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
    }
}