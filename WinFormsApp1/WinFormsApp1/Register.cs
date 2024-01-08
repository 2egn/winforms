using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{

    public partial class Register : Form
    {

        VisibilityHandler visibilityhandler = new VisibilityHandler();

        private Form parentForm;
        public Register(Form parentForm)
        {
            InitializeComponent();
            BaseComboItemAdd();
            this.parentForm = parentForm;
        }

        static string server = "127.0.0.1";
        static string database = "sqler_test";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";

        private void button1_Click(object sender, EventArgs e)
        {
            var InputName = NameTextBox.Text.ToString();
            var InputId = IdTextBox.Text.ToString();
            var InputPw = PwTextBox.Text.ToString();
            var InputPwCheck = PwCheckTextBox.Text.ToString();
            var year = int.Parse(YearCombo.SelectedItem.ToString());
            var month = int.Parse(MonthCombo.SelectedItem.ToString());
            var day = int.Parse(DayCombo.SelectedItem.ToString());
            string date = $"{year}-{month}-{day}";
            var isValidAccount = false;
            if (string.IsNullOrEmpty(InputName) || string.IsNullOrEmpty(InputId) || string.IsNullOrEmpty(InputPw) || string.IsNullOrEmpty(InputPwCheck))
            {
                MessageBox.Show("빈칸이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (InputPw != InputPwCheck)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string commandstring = $"SELECT * FROM dbo.[user] WHERE u_id='{InputId}'";
                    var cmd = new SqlCommand(commandstring, conn);
                    var rs = cmd.ExecuteReader();
                    isValidAccount = rs.Read();//true if ID exists, false otheriwse
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (InputId.Length < 4 || InputId.Length > 8 || isValidAccount)
            {
                MessageBox.Show("사용할 수 없는 아이디 입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!checkcommonletter(InputId, InputPw))
            {
                MessageBox.Show("비밀번호는 아이디와 4글자 이상 연속으로 겹쳐질 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string commandstring = $"INSERT INTO dbo.[user] VALUES ('{InputId}','{InputPw}','{InputName}','{date}');";
                    var cmd = new SqlCommand(commandstring, conn);
                    var rs = cmd.ExecuteReader();
                    isValidAccount = rs.Read();//true if ID exists, false otheriwse
                    MessageBox.Show($"{InputName}님 환영합니다", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        static DateTime now = DateTime.Now;
        private void BaseComboItemAdd()
        {

            for (int i = 1900; i <= now.Year; i++)
            {
                YearCombo.Items.Add(i.ToString());
            }
            YearCombo.SelectedItem = now.Year.ToString();

            MonthCombo.Items.Clear();
            for (int i = 1; i <= now.Month; i++)
            {
                if (i <= 9) MonthCombo.Items.Add($"0{i}");
                else MonthCombo.Items.Add(i);
            }
            MonthCombo.SelectedIndex = now.Month - 1;

            lastdaychange(int.Parse(YearCombo.SelectedItem.ToString()), int.Parse(MonthCombo.SelectedItem.ToString()));
            DayCombo.SelectedIndex = now.Day - 1;

        }

        private void YearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(YearCombo.SelectedItem.ToString()) != now.Year)//!2024
            {
                for (int i = MonthCombo.Items.Count + 1; i <= 12; i++)
                {
                    if (i <= 9) MonthCombo.Items.Add($"0{i}");
                    else MonthCombo.Items.Add(i);
                }
                lastdaychange(int.Parse(YearCombo.SelectedItem.ToString()), int.Parse(MonthCombo.SelectedItem.ToString()));
            }
            else//2024
            {
                MonthCombo.Items.Clear();
                for (int i = 1; i <= now.Month; i++)
                {
                    if (i <= 9) MonthCombo.Items.Add($"0{i}");
                    else MonthCombo.Items.Add(i);
                }
                if (MonthCombo.SelectedIndex > now.Month) MonthCombo.SelectedIndex = now.Month - 1;
                //최근년도로 설정했을 때 설정된 월이 현재 존재하는 올해의 월 범위에 포함하지않을 때, 현재의 달로 설정.
            }

        }

        private void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastdaychange(int.Parse(YearCombo.SelectedItem.ToString()), int.Parse(MonthCombo.SelectedItem.ToString()));
        }
        private void lastdaychange(int Lyear, int Lmonth)
        {
            int lastdayofmonth = DateTime.DaysInMonth(Lyear, Lmonth);
            if (DayCombo.Items.Count > 0)
            {
                if (DayCombo.Items.Count > lastdayofmonth)
                {
                    for (int i = DayCombo.Items.Count; i > lastdayofmonth; i--)
                    {
                        DayCombo.Items.RemoveAt(i - 1);
                    }
                }
                else if (DayCombo.Items.Count < lastdayofmonth)
                {
                    for (int i = DayCombo.Items.Count + 1; i <= lastdayofmonth; i++)
                    {
                        DayCombo.Items.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= lastdayofmonth; i++)
                {
                    if (i <= 9) DayCombo.Items.Add($"0{i}");
                    else DayCombo.Items.Add(i);
                }
            }
        }
        private bool checkcommonletter(string idstring, string pwstring)
        {//id와 pw에서 4자리 이상 공통된 글자 있을 때
            for (int i = 0; i < idstring.Length - 3; i++)
            {
                string checkstring = idstring.Substring(i, 4);
                if (pwstring.Contains(checkstring))
                {
                    return false;
                }
            }
            return true;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            parentForm.Visible = true;
        }
    }

}
