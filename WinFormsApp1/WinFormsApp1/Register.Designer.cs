namespace WinFormsApp1
{
    partial class Register
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "이름";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "아이디";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "비밀번호";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "비밀번호 확인";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 135);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "생년월일";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 138);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 12;
            label7.Text = "년";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 139);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 14;
            label8.Text = "월";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(288, 140);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 16;
            label9.Text = "일";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 23);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(188, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(35, 23);
            comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(250, 134);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(35, 23);
            comboBox3.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(119, 180);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 20;
            button1.Text = "회원가입";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 222);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Register";
            Text = "회원가입";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
    }
}