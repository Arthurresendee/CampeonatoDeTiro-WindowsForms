namespace Login
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            btn_Login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(87, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(37, 105);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlText;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(37, 175);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlText;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(71, 151);
            label4.Name = "label4";
            label4.Size = new Size(210, 46);
            label4.TabIndex = 3;
            label4.Text = "Welcome to";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(151, 190);
            label5.Name = "label5";
            label5.Size = new Size(244, 46);
            label5.TabIndex = 4;
            label5.Text = "shooting Club";
            label5.Click += label5_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(37, 129);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(206, 23);
            txt_username.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(37, 199);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(206, 23);
            txt_password.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(476, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 328);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(126, 225);
            label6.Name = "label6";
            label6.Size = new Size(117, 12);
            label6.TabIndex = 8;
            label6.Text = "you forgot the password?";
            label6.Click += label6_Click;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ActiveCaptionText;
            btn_Login.Location = new Point(87, 257);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 33);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(812, 385);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.OldLace;
            Name = "Form1";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_username;
        private TextBox txt_password;
        private Panel panel1;
        private Button btn_Login;
        private Label label6;
    }
}