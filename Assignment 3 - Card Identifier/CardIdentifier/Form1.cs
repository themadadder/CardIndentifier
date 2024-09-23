namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardNameOut.Text = "Three of Clubs";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sevenOfHearts_Click(object sender, EventArgs e)
        {
            cardNameOut.Text = "Seven of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardNameOut.Text = "Ace of Spades";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cardNameOut.Text = "Jack of Diamonds";
        }

        private void kingOfHearts_Click(object sender, EventArgs e)
        {
            cardNameOut.Text = "King of Hearts";
        }
    }
}
