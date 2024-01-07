namespace WinFormsApp1
{
    public partial class Main : Form
    {
        Login login = new Login();
        public Main()
        {
            InitializeComponent();
            
            login.LoginEvent += new Login.LoginEventHandler(OnLogin);

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
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

        public void OnLogin()
        {
            login_button.Text = "·Î±×¾Æ¿ô";
            mypage_button.Enabled = true;
            search_button.Enabled=true;
            board_button.Enabled=true;
            game_button.Enabled=true;

        }
    }
}
