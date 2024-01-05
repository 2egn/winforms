namespace WinFormsApp1
{
    partial class Assignment
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(61, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "lorem ipsum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "등록일";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(61, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "lorem ipsum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "제목";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(61, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 23);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "내용";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(61, 140);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 130);
            textBox4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 302);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "공개여부";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(73, 300);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "비공개";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(140, 300);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "공개";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(118, 356);
            button1.Name = "button1";
            button1.Size = new Size(71, 35);
            button1.TabIndex = 3;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(195, 356);
            button2.Name = "button2";
            button2.Size = new Size(71, 35);
            button2.TabIndex = 3;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            // 
            // Assignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 403);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Assignment";
            Text = "등록";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
    }
}