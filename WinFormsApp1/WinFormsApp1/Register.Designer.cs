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
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label2 = new Label();
            PwTextBox = new TextBox();
            label3 = new Label();
            PwCheckTextBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            DayCombo = new ComboBox();
            button1 = new Button();
            MonthCombo = new ComboBox();
            YearCombo = new ComboBox();
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
            // NameTextBox
            // 
            NameTextBox.Location = new Point(108, 18);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(183, 23);
            NameTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(108, 47);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(183, 23);
            IdTextBox.TabIndex = 3;
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
            // PwTextBox
            // 
            PwTextBox.Location = new Point(108, 76);
            PwTextBox.Name = "PwTextBox";
            PwTextBox.Size = new Size(183, 23);
            PwTextBox.TabIndex = 5;
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
            // PwCheckTextBox
            // 
            PwCheckTextBox.Location = new Point(108, 105);
            PwCheckTextBox.Name = "PwCheckTextBox";
            PwCheckTextBox.Size = new Size(183, 23);
            PwCheckTextBox.TabIndex = 7;
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
            label8.Location = new Point(228, 139);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 14;
            label8.Text = "월";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 140);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 16;
            label9.Text = "일";
            // 
            // DayCombo
            // 
            DayCombo.DropDownHeight = 90;
            DayCombo.FormattingEnabled = true;
            DayCombo.ImeMode = ImeMode.NoControl;
            DayCombo.IntegralHeight = false;
            DayCombo.ItemHeight = 15;
            DayCombo.Location = new Point(250, 134);
            DayCombo.Name = "DayCombo";
            DayCombo.Size = new Size(41, 23);
            DayCombo.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(119, 180);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 20;
            button1.Text = "회원가입";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MonthCombo
            // 
            MonthCombo.DropDownHeight = 90;
            MonthCombo.FormattingEnabled = true;
            MonthCombo.ImeMode = ImeMode.NoControl;
            MonthCombo.IntegralHeight = false;
            MonthCombo.ItemHeight = 15;
            MonthCombo.Location = new Point(188, 134);
            MonthCombo.Name = "MonthCombo";
            MonthCombo.Size = new Size(41, 23);
            MonthCombo.TabIndex = 18;
            MonthCombo.SelectedIndexChanged += MonthCombo_SelectedIndexChanged;
            // 
            // YearCombo
            // 
            YearCombo.DropDownHeight = 90;
            YearCombo.FormattingEnabled = true;
            YearCombo.ImeMode = ImeMode.NoControl;
            YearCombo.IntegralHeight = false;
            YearCombo.ItemHeight = 15;
            YearCombo.Location = new Point(108, 134);
            YearCombo.Name = "YearCombo";
            YearCombo.Size = new Size(60, 23);
            YearCombo.TabIndex = 17;
            YearCombo.SelectedIndexChanged += YearCombo_SelectedIndexChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 222);
            Controls.Add(button1);
            Controls.Add(DayCombo);
            Controls.Add(MonthCombo);
            Controls.Add(YearCombo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PwCheckTextBox);
            Controls.Add(label4);
            Controls.Add(PwTextBox);
            Controls.Add(label3);
            Controls.Add(IdTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "Register";
            Text = "회원가입";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private TextBox IdTextBox;
        private Label label2;
        private TextBox PwTextBox;
        private Label label3;
        private TextBox PwCheckTextBox;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox DayCombo;
        private Button button1;
        private ComboBox MonthCombo;
        private ComboBox YearCombo;
    }
}