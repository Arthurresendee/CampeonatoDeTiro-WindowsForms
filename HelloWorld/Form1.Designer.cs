namespace HelloWorld
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
            Btn_ClickThis = new Button();
            lbl_HelloWorld = new Label();
            SuspendLayout();
            // 
            // Btn_ClickThis
            // 
            Btn_ClickThis.Location = new Point(30, 42);
            Btn_ClickThis.Name = "Btn_ClickThis";
            Btn_ClickThis.Size = new Size(75, 23);
            Btn_ClickThis.TabIndex = 0;
            Btn_ClickThis.Text = "Click This";
            Btn_ClickThis.UseVisualStyleBackColor = true;
            Btn_ClickThis.Click += Btn_ClickThis_Click;
            // 
            // lbl_HelloWorld
            // 
            lbl_HelloWorld.AutoSize = true;
            lbl_HelloWorld.Location = new Point(31, 20);
            lbl_HelloWorld.Name = "lbl_HelloWorld";
            lbl_HelloWorld.Size = new Size(38, 15);
            lbl_HelloWorld.TabIndex = 1;
            lbl_HelloWorld.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 323);
            Controls.Add(lbl_HelloWorld);
            Controls.Add(Btn_ClickThis);
            Name = "Form1";
            Text = "Hello World";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_ClickThis;
        private Label lbl_HelloWorld;
    }
}