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
            login_button = new Button();
            reservation_button = new Button();
            game_button = new Button();
            board_button = new Button();
            search_button = new Button();
            mypage_button = new Button();
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
            // login_button
            // 
            login_button.AutoSize = true;
            login_button.Location = new Point(34, 282);
            login_button.Name = "login_button";
            login_button.Size = new Size(83, 29);
            login_button.TabIndex = 2;
            login_button.Text = "로그인";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += button1_Click;
            // 
            // reservation_button
            // 
            reservation_button.AutoSize = true;
            reservation_button.Location = new Point(479, 282);
            reservation_button.Name = "reservation_button";
            reservation_button.Size = new Size(83, 29);
            reservation_button.TabIndex = 3;
            reservation_button.Text = "예약현황";
            reservation_button.UseVisualStyleBackColor = true;
            reservation_button.Click += button2_Click;
            // 
            // game_button
            // 
            game_button.AutoSize = true;
            game_button.Enabled = false;
            game_button.Location = new Point(390, 282);
            game_button.Name = "game_button";
            game_button.Size = new Size(83, 29);
            game_button.TabIndex = 4;
            game_button.Text = "방탈출게임";
            game_button.UseVisualStyleBackColor = true;
            // 
            // board_button
            // 
            board_button.AutoSize = true;
            board_button.Enabled = false;
            board_button.Location = new Point(301, 282);
            board_button.Name = "board_button";
            board_button.Size = new Size(83, 29);
            board_button.TabIndex = 5;
            board_button.Text = "게시판";
            board_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            search_button.AutoSize = true;
            search_button.Enabled = false;
            search_button.Location = new Point(212, 282);
            search_button.Name = "search_button";
            search_button.Size = new Size(83, 29);
            search_button.TabIndex = 6;
            search_button.Text = "검색";
            search_button.UseVisualStyleBackColor = true;
            // 
            // mypage_button
            // 
            mypage_button.AutoSize = true;
            mypage_button.Enabled = false;
            mypage_button.Location = new Point(123, 282);
            mypage_button.Name = "mypage_button";
            mypage_button.Size = new Size(83, 29);
            mypage_button.TabIndex = 7;
            mypage_button.Text = "마이페이지";
            mypage_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            Controls.Add(mypage_button);
            Controls.Add(search_button);
            Controls.Add(board_button);
            Controls.Add(game_button);
            Controls.Add(reservation_button);
            Controls.Add(login_button);
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
        private Button login_button;
        private Button reservation_button;
        private Button game_button;
        private Button board_button;
        private Button search_button;
        private Button mypage_button;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
