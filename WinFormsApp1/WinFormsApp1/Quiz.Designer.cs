namespace WinFormsApp1
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "퀴즈번호 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(205, 9);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 0;
            label2.Text = "30";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 299);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 0;
            label3.Text = "답 입력 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(48, 49);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 0;
            label4.Text = "3번";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(213, 49);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 0;
            label5.Text = "남은 시간 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(309, 49);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 0;
            label6.Text = "1:48";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(269, 295);
            button1.Name = "button1";
            button1.Size = new Size(58, 31);
            button1.TabIndex = 3;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(-1, 49);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 0;
            label7.Text = "기회 :";
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(359, 330);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Quiz";
            Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label7;
    }
}