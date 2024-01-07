namespace WinFormsApp1
{
    public partial class Main : Form
    {
        
        bool isLogin = false;
        public Main()
        {
            InitializeComponent();
            Login login = new Login();
            login.LoginEvent += new Login.LoginEventHandler(OnLogin);

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                OnLogOut();
                isLogin = false;
            }
            else
            {
                Login login = new Login();
                login.LoginEvent += new Login.LoginEventHandler(OnLogin);
                login.Show();
            }
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
            login_button.Text = "�α���";
            mypage_button.Enabled = false;
            search_button.Enabled = false;
            board_button.Enabled = false;
            game_button.Enabled = false;
            isLogin = false;
        }
        public void OnLogin()
        {
            login_button.Text = "�α׾ƿ�";
            mypage_button.Enabled = true;
            search_button.Enabled=true;
            board_button.Enabled=true;
            game_button.Enabled=true;
            isLogin = true;
        }
    }
}
