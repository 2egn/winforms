namespace WinFormsApp1
{
    partial class GameList
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "21", "2022-01-30", "루팡 광주2호점", "모험", "위험한 레시피" }, -1);
            label1 = new Label();
            listView1 = new ListView();
            Number = new ColumnHeader();
            Date = new ColumnHeader();
            PlaceName = new ColumnHeader();
            Genre = new ColumnHeader();
            ThemeName = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 47);
            label1.TabIndex = 0;
            label1.Text = "회원명 : 김유나";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Number, Date, PlaceName, Genre, ThemeName });
            listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 75);
            listView1.Name = "listView1";
            listView1.Size = new Size(579, 363);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Number
            // 
            Number.Text = "번호";
            Number.Width = 80;
            // 
            // Date
            // 
            Date.Text = "날짜";
            Date.TextAlign = HorizontalAlignment.Center;
            Date.Width = 95;
            // 
            // PlaceName
            // 
            PlaceName.Text = "지점명";
            PlaceName.TextAlign = HorizontalAlignment.Center;
            PlaceName.Width = 160;
            // 
            // Genre
            // 
            Genre.Text = "장르";
            Genre.TextAlign = HorizontalAlignment.Center;
            Genre.Width = 81;
            // 
            // ThemeName
            // 
            ThemeName.Text = "테마명";
            ThemeName.TextAlign = HorizontalAlignment.Center;
            ThemeName.Width = 160;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "GameList";
            Text = "게임리스트";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Number;
        private ColumnHeader Date;
        private ColumnHeader PlaceName;
        private ColumnHeader Genre;
        private ColumnHeader ThemeName;
    }
}