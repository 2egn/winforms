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
using System.Numerics;




namespace WinFormsApp1
{

    public partial class Login : Form
    {

        public delegate void LoginEventHandler();
        public event LoginEventHandler LoginEvent;
        private Form ParentForm;
        public Login(Form parentForm = null)
        {
            InitializeComponent();
            this.ParentForm = parentForm;
        }

        static string server = "127.0.0.1";
        static string database = "2024지방_1";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";


        private void login_button_Click(object sender, EventArgs e)
        {
            var isValidAccount = false;
            var inputId = textBox1.Text.ToString();
            var inputPw = textBox2.Text.ToString();
            if (!string.IsNullOrEmpty(inputId) && !string.IsNullOrEmpty(inputPw))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        string commandstring = $"SELECT * FROM dbo.[user] WHERE u_id='{inputId}' AND u_pw ='{inputPw}'";
                        var cmd = new SqlCommand(commandstring, conn);
                        var rs = cmd.ExecuteReader();
                        isValidAccount = rs.Read();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (isValidAccount)
                {
                    MessageBox.Show($"{inputId}님 환영합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoginEvent();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원 정보가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("빈칸이 있습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void assign_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register register = new Register(this);

            register.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
        }
    }
}
