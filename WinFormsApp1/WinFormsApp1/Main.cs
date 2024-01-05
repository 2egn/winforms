namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            Login login = new Login();
            login.Show();
            Register register = new Register();
            register.Show();
            MyPage mypage = new MyPage();
            mypage.Show();
            Search search = new Search();
            search.Show();
            introduce introduce = new introduce();
            introduce.Show();
            Board board = new Board();
            board.Show();
            Reservation reservation = new Reservation();
            reservation.Show();
            Assignment assignment = new Assignment();
            assignment.Show();
            GameList gameList = new GameList();
            gameList.Show();
            Quiz quiz = new Quiz();
            quiz.Show();
            ReservationChart reservationChart = new ReservationChart();
            reservationChart.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
