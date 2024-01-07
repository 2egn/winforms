namespace WinFormsApp1
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            login_button = new Button();
            assign_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 0;
            label1.Text = "방탈출";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "아이디";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 3;
            label3.Text = "비밀번호";
            // 
            // login_button
            // 
            login_button.Location = new Point(12, 169);
            login_button.Name = "login_button";
            login_button.Size = new Size(111, 36);
            login_button.TabIndex = 5;
            login_button.Text = "로그인";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // assign_button
            // 
            assign_button.Location = new Point(131, 169);
            assign_button.Name = "assign_button";
            assign_button.Size = new Size(111, 36);
            assign_button.TabIndex = 6;
            assign_button.Text = "회원가입";
            assign_button.UseVisualStyleBackColor = true;
            assign_button.Click += assign_button_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 229);
            Controls.Add(assign_button);
            Controls.Add(login_button);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button login_button;
        private Button assign_button;
    }
}