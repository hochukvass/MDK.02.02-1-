namespace MDK._02._02_ПР1_Мамедханова
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int a, b, c;
        long score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = rand.Next(9);
            b = rand.Next(9);
            c = rand.Next(9);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label2.Text = Convert.ToString(a);
            label3.Text = Convert.ToString(b);
            label4.Text = Convert.ToString(c);

            if (a == 7 && b == 7 && c == 7)
            {
                label1.Text = "ЭЭЭОООДЖЕКПОТ!!!!";
                score += 10000;
                label5.Text = "Счёт: " + score;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (a == b && b == c)
            {
                score += 7000;
                label5.Text = "Счёт: " + score;
                label1.Text = "уже лучше";
            }
            else if (a == b || b == c || a == c)
            {
                score += 3000;
                label5.Text = "Счёт: " + score;
                label1.Text = "крути дальше";
            }
            else
            {
                score -= 1000;
                label5.Text = "Счёт: " + score;
                label1.Text = "пока гавно";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
