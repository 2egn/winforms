namespace WinFormsApp1
{
    partial class Board
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "2", "에로스의 초대 간단후기", "room3", "2021-11-11", "786" }, -1);
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            Number = new ColumnHeader();
            Title = new ColumnHeader();
            Id = new ColumnHeader();
            AssignDate = new ColumnHeader();
            View = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "페이지 정보 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 13);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "1/5 ";
            // 
            // button1
            // 
            button1.Location = new Point(117, 5);
            button1.Name = "button1";
            button1.Size = new Size(67, 31);
            button1.TabIndex = 1;
            button1.Text = "◀";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(190, 5);
            button2.Name = "button2";
            button2.Size = new Size(67, 31);
            button2.TabIndex = 1;
            button2.Text = "▶";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 13);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "분류 :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "제목", "아이디" });
            comboBox1.Location = new Point(375, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "제목";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(464, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(570, 7);
            button3.Name = "button3";
            button3.Size = new Size(58, 27);
            button3.TabIndex = 4;
            button3.Text = "검색";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(634, 7);
            button4.Name = "button4";
            button4.Size = new Size(84, 27);
            button4.TabIndex = 4;
            button4.Text = "게시물 작성";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Number, Title, Id, AssignDate, View });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(696, 386);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            Number.Text = "번호";
            Number.Width = 75;
            // 
            // Title
            // 
            Title.Text = "제목";
            Title.TextAlign = HorizontalAlignment.Center;
            Title.Width = 250;
            // 
            // Id
            // 
            Id.Text = "아이디";
            Id.TextAlign = HorizontalAlignment.Center;
            Id.Width = 140;
            // 
            // AssignDate
            // 
            AssignDate.Text = "등록일";
            AssignDate.TextAlign = HorizontalAlignment.Center;
            AssignDate.Width = 140;
            // 
            // View
            // 
            View.Text = "조회";
            View.TextAlign = HorizontalAlignment.Center;
            View.Width = 90;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Board";
            Text = "게시판";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private ColumnHeader Number;
        private ColumnHeader Title;
        private ColumnHeader Id;
        private ColumnHeader AssignDate;
        private ColumnHeader View;
    }
}