namespace WinFormsApp1
{
    partial class MyPage
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "2022-01-29", "17:30", "고스트키 순천점", "위험한 레시피", "2", "42,000" }, -1);
            label1 = new Label();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            Date = new ColumnHeader();
            Time = new ColumnHeader();
            Cafe_Name = new ColumnHeader();
            Theme_Name = new ColumnHeader();
            Population = new ColumnHeader();
            Price = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "날짜 :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "전체", "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" });
            comboBox1.Location = new Point(56, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 23);
            comboBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { Date, Time, Cafe_Name, Theme_Name, Population, Price });
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 35);
            listView1.Name = "listView1";
            listView1.RightToLeftLayout = true;
            listView1.Size = new Size(503, 201);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Date
            // 
            Date.Text = "날짜";
            Date.TextAlign = HorizontalAlignment.Center;
            Date.Width = 90;
            // 
            // Time
            // 
            Time.Text = "시간";
            Time.TextAlign = HorizontalAlignment.Center;
            // 
            // Cafe_Name
            // 
            Cafe_Name.Text = "카페 이름";
            Cafe_Name.TextAlign = HorizontalAlignment.Center;
            Cafe_Name.Width = 100;
            // 
            // Theme_Name
            // 
            Theme_Name.Text = "테마명";
            Theme_Name.TextAlign = HorizontalAlignment.Center;
            Theme_Name.Width = 100;
            // 
            // Population
            // 
            Population.Text = "인원수";
            Population.TextAlign = HorizontalAlignment.Center;
            // 
            // Price
            // 
            Price.Text = "가격";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 242);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "총 금액 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 242);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "843,000";
            // 
            // MyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 266);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "MyPage";
            Text = "마이페이지";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader Time;
        private ColumnHeader Cafe_Name;
        private ColumnHeader Theme_Name;
        private ColumnHeader Population;
        private ColumnHeader Price;
        private ColumnHeader Date;
        private Label label2;
        private Label label3;
    }
}