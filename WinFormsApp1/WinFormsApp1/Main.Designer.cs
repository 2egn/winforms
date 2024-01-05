namespace WinFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "지점", "테마" });
            comboBox1.Location = new Point(82, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(50, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "테마";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "예약 TOP5";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(34, 282);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 2;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(479, 282);
            button2.Name = "button2";
            button2.Size = new Size(83, 29);
            button2.TabIndex = 3;
            button2.Text = "예약현황";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Enabled = false;
            button3.Location = new Point(390, 282);
            button3.Name = "button3";
            button3.Size = new Size(83, 29);
            button3.TabIndex = 4;
            button3.Text = "방탈출게임";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Enabled = false;
            button4.Location = new Point(301, 282);
            button4.Name = "button4";
            button4.Size = new Size(83, 29);
            button4.TabIndex = 5;
            button4.Text = "게시판";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Enabled = false;
            button5.Location = new Point(212, 282);
            button5.Name = "button5";
            button5.Size = new Size(83, 29);
            button5.TabIndex = 6;
            button5.Text = "검색";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Enabled = false;
            button6.Location = new Point(123, 282);
            button6.Name = "button6";
            button6.Size = new Size(83, 29);
            button6.TabIndex = 7;
            button6.Text = "마이페이지";
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 162);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(274, 212);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 9;
            label2.Text = "고양이";
            label2.Click += label2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 342);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Main";
            Text = "메인";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
