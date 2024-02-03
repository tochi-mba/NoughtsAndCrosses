using System.Media;

namespace NoughtsAndCrosses
{
    public partial class MainForm : Form
    {

        private Board gameBoard;
        private GameVerify gameVerify;
        private char player = 'o';
        public MainForm()
        {
            InitializeComponent();

            gameBoard = new Board();
            gameVerify = new GameVerify();

        }

        private void cell1_Click(object sender, EventArgs e)
        {
            if (gameVerify.currentPlayer(player) == 'x')
            {

                if (gameBoard.ModifyBoard(0, 0, 'x'))
                {
                    player = 'x';
                    cell1.Text = "X";
                }
            }
            else
            {
                if (gameBoard.ModifyBoard(0, 0, 'o'))
                {
                    player = 'o';
                    cell1.Text = "O";
                }
                
            }

            if (gameVerify.Verify(gameBoard.board) == 'o')
            {
                MessageBox.Show("O wins!");
            }else if (gameVerify.Verify(gameBoard.board) == '')

        }

        private void cell2_Click(object sender, EventArgs e)
        {

        }

        private void cell3_Click(object sender, EventArgs e)
        {

        }

        private void cell4_Click(object sender, EventArgs e)
        {

        }

        private void cell5_Click(object sender, EventArgs e)
        {

        }

        private void cell6_Click(object sender, EventArgs e)
        {

        }

        private void cell7_Click(object sender, EventArgs e)
        {

        }

        private void cell8_Click(object sender, EventArgs e)
        {

        }

        private void cell9_Click(object sender, EventArgs e)
        {

        }
    }
}
