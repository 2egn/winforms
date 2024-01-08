namespace WinFormsApp1
{
    public partial class Main : Form
    {

        bool isLogin = false;
        public Main()
        {
            InitializeComponent();
            Login login = new();
            login.LoginEvent += new Login.LoginEventHandler(OnLogin);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {//this button represents Login_Button
            if (isLogin)
            {
                OnLogOut();
                isLogin = false;
            }
            else
            {
                Login login = new(this);
                login.LoginEvent += new Login.LoginEventHandler(OnLogin);
                login.Show();
                this.Visible = false;
            }
        }
        private void mypage_button_Click(object sender, EventArgs e)
        {
            MyPage mypage = new(this);           
            mypage.Show();
            this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void OnLogOut()
        {
            login_button.Text = "로그인";
            mypage_button.Enabled = false;
            search_button.Enabled = false;
            board_button.Enabled = false;
            game_button.Enabled = false;
            isLogin = false;
        }
        public void OnLogin()
        {
            login_button.Text = "로그아웃";
            mypage_button.Enabled = true;
            search_button.Enabled = true;
            board_button.Enabled = true;
            game_button.Enabled = true;
            isLogin = true;
        }

        
    }
}
