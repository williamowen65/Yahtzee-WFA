namespace Yahtzee_WFA
{
    public partial class GameBoard : Form
    {

        Die[] dice = new Die[6];
        public GameBoard()
        {
            InitializeComponent();

            // Create a die
            Die die1 = new Die(this, PictureBoxDice1);
            Die die2 = new Die(this, PictureBoxDice2);
            Die die3 = new Die(this, PictureBoxDice3);
            Die die4 = new Die(this, PictureBoxDice4);
            Die die5 = new Die(this, PictureBoxDice5);
            Die die6 = new Die(this, PictureBoxDice6);

            // Add the dice to the array
            dice[0] = die1;
            dice[1] = die2;
            dice[2] = die3;
            dice[3] = die4;
            dice[4] = die5;
            dice[5] = die6;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // Roll all the dice
            foreach (Die die in dice)
            {
                if (!die.IsHeld)
                {
                    die.Roll();
                }
            }
        }
    }
}
