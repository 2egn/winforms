namespace WinFormsApp1
{
    partial class Reservation
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
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label20 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label22 = new Label();
            label21 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 47);
            label1.TabIndex = 0;
            label1.Text = "방탈출 예약";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(186, 56);
            label2.Name = "label2";
            label2.Size = new Size(167, 17);
            label2.TabIndex = 1;
            label2.Text = "Room Escape Reservation";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 36);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(199, 11);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 3;
            label6.Text = "▷";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 2;
            label5.Text = "◁";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(74, 11);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Apr, 5, 2022";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label10);
            panel2.Location = new Point(228, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 36);
            panel2.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(25, 11);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 0;
            label10.Text = "시간";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(345, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 300);
            panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(125, 259);
            button2.Name = "button2";
            button2.Size = new Size(61, 25);
            button2.TabIndex = 1;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(58, 259);
            button1.Name = "button1";
            button1.Size = new Size(61, 25);
            button1.TabIndex = 1;
            button1.Text = "예약";
            button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(3, 216);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 0;
            label13.Text = "총금액";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(3, 178);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 0;
            label12.Text = "인원수";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(3, 144);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 0;
            label11.Text = "가격";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(3, 114);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 0;
            label9.Text = "시간";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 79);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "테마";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 47);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 0;
            label7.Text = "지점";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(82, 216);
            label20.Name = "label20";
            label20.Size = new Size(78, 15);
            label20.TabIndex = 0;
            label20.Text = "Lorem ipsum";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(82, 144);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 0;
            label18.Text = "Lorem ipsum";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(82, 114);
            label17.Name = "label17";
            label17.Size = new Size(78, 15);
            label17.TabIndex = 0;
            label17.Text = "Lorem ipsum";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(82, 79);
            label16.Name = "label16";
            label16.Size = new Size(78, 15);
            label16.TabIndex = 0;
            label16.Text = "Lorem ipsum";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(82, 47);
            label15.Name = "label15";
            label15.Size = new Size(78, 15);
            label15.TabIndex = 0;
            label15.Text = "Lorem ipsum";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(82, 11);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 0;
            label14.Text = "Lorem ipsum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "날짜";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label21);
            panel4.Location = new Point(314, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(25, 299);
            panel4.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 272);
            label22.Name = "label22";
            label22.Size = new Size(19, 15);
            label22.TabIndex = 0;
            label22.Text = "▼";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 8);
            label21.Name = "label21";
            label21.Size = new Size(19, 15);
            label21.TabIndex = 0;
            label21.Text = "▲";
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 389);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reservation";
            Text = "예약";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Label label10;
        private Panel panel3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label20;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Panel panel4;
        private Label label22;
        private Label label21;
        private TextBox textBox1;
    }
}