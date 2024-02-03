using System.Media;

namespace NoughtsAndCrosses
{
    public partial class MainForm : Form
    {

        private Board gameBoard;
        private GameVerify gameVerify;
        private char player = 'o';
        private string playerSymbol;
        public MainForm()
        {
            InitializeComponent();

            gameBoard = new Board();
            gameVerify = new GameVerify();

        }

        public string play(int x, int y)
        {
            string playerSymbol = "default";
            if (gameVerify.currentPlayer(player) == 'x')
            {

                if (gameBoard.ModifyBoard(x, y, 'x'))
                {
                    player = 'x';
                    playerSymbol = "X";
                }
            }
            else
            {
                if (gameBoard.ModifyBoard(x, y, 'o'))
                {
                    player = 'o';
                    playerSymbol = "O";
                }

            }

            if (gameVerify.Verify(gameBoard.board) == 'o')
            {
                MessageBox.Show("O wins!");
                this.Close();
            }
            else if (gameVerify.Verify(gameBoard.board) == 'x')
            {
                MessageBox.Show("X wins!");
                this.Close();
            }
            else if (gameVerify.Verify(gameBoard.board) == '1')
            {
                MessageBox.Show("Tie!");
                this.Close();
            }

            return playerSymbol;
        }

        private void cell1_Click(object sender, EventArgs e)
        {
            playerSymbol = play(0, 0);
            if (playerSymbol != "default")
            {
                cell1.Text = playerSymbol;
            }
        }

        private void cell2_Click(object sender, EventArgs e)
        {
            playerSymbol = play(0, 1);
            if (playerSymbol != "default")
            {
                cell2.Text = playerSymbol;
            }
        }

        private void cell3_Click(object sender, EventArgs e)
        {
            playerSymbol = play(0, 2);
            if (playerSymbol != "default")
            {
                cell3.Text = playerSymbol;
            }
        }

        private void cell4_Click(object sender, EventArgs e)
        {
            playerSymbol = play(1, 0);
            if (playerSymbol != "default")
            {
                cell4.Text = playerSymbol;
            }
        }

        private void cell5_Click(object sender, EventArgs e)
        {
            playerSymbol = play(1, 1);
            if (playerSymbol != "default")
            {
                cell5.Text = playerSymbol;
            }
        }

        private void cell6_Click(object sender, EventArgs e)
        {
            playerSymbol = play(1, 2);
            if (playerSymbol != "default")
            {
                cell6.Text = playerSymbol;
            }
        }

        private void cell7_Click(object sender, EventArgs e)
        {
            playerSymbol = play(2, 0);
            if (playerSymbol != "default")
            {
                cell7.Text = playerSymbol;
            }
        }

        private void cell8_Click(object sender, EventArgs e)
        {
            playerSymbol = play(2, 1);
            if (playerSymbol != "default")
            {
                cell8.Text = playerSymbol;
            }
        }

        private void cell9_Click(object sender, EventArgs e)
        {
            playerSymbol = play(2, 2);
            if (playerSymbol != "default")
            {
                cell9.Text = playerSymbol;
            }
        }
    }
}
