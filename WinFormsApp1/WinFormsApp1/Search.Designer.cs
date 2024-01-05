namespace WinFormsApp1
{
    partial class Search
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
            ListViewItem listViewItem1 = new ListViewItem("전국");
            ListViewItem listViewItem2 = new ListViewItem("강원");
            ListViewItem listViewItem3 = new ListViewItem("경기");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            Date = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 45);
            label1.TabIndex = 0;
            label1.Text = "방탈출 카페 검색";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 62);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "장르";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "전체", "장르1", "장르2", "장르3", "장르4" });
            comboBox1.Location = new Point(478, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(59, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "전체";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 62);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "테마";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(584, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(731, 53);
            button1.Name = "button1";
            button1.Size = new Size(61, 32);
            button1.TabIndex = 5;
            button1.Text = "검색";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { Date });
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(12, 87);
            listView1.Name = "listView1";
            listView1.RightToLeftLayout = true;
            listView1.Size = new Size(94, 351);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Date
            // 
            Date.Text = "날짜";
            Date.Width = 90;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(112, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(680, 351);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search";
            Text = "검색";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Date;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}