using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun_Game___Inlämmning
{
    public partial class Form1 : Form
    {
        enum ShotgunMove { Reload, Shoot, ShootShotgun, Block };

        Player user = new Player();
        Player computer = new Player();

        private static Color COLOR_ENABLED = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));   // Green
        private static Color COLOR_DISABLED = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));  // Red

        public Form1()
        {
            InitializeComponent();

            UpdateBulletsLoadedDisplays();
            UpdateUserButtons();
        }

        private void MakeMove(ShotgunMove userMove)
        {
            ShotgunMove computerMove = GetComputerMove();

            // Update bulletLoaded counts for both players.
            UpdateBulletLoadedCounts(user, userMove);
            UpdateBulletLoadedCounts(computer, computerMove);

            UpdateUserButtons();
            UpdatePreviousMoveDisplays(userMove, computerMove);
            UpdateBulletsLoadedDisplays();

            string outcomeMessage = null;
            string captionMessage = "";
            if (MoveWins(userMove, computerMove))
            {   // User wins!
                outcomeMessage = "You win! ☺";
                captionMessage = "Congratulations!";
            }
            else if (MoveWins(computerMove, userMove))
            {   // Computer wins :)
                outcomeMessage = "You lose! ☹";
                captionMessage = "Sorry...";
            }
            if (outcomeMessage != null)  // Game has ended.
            {
                string composedMessage = $"{outcomeMessage}\n\nPlay again?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(composedMessage, captionMessage, buttons);

                if (result == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void UpdateBulletLoadedCounts(Player player, ShotgunMove move)
        {
            if (move == ShotgunMove.Reload)
            {
                player.bulletsLoaded += 1;
            }
            else if (move == ShotgunMove.Shoot)
            {
                player.bulletsLoaded -= 1;
            }
            else if (move == ShotgunMove.ShootShotgun)
            {
                player.bulletsLoaded -= 3;
            }
        }

        /* Update the enabled state of the user's buttons, showing whether they can be used. */
        private void UpdateUserButtons()
        {
            SetButtonEnabledState(buttonShoot, !(user.bulletsLoaded < 1));
            SetButtonEnabledState(buttonShootShotgun, !(user.bulletsLoaded < 3));
        }

        /* Set the enabled state of the given button to the given enabled state. */
        private void SetButtonEnabledState(Button button, bool enabled)
        {
            button.Enabled = enabled;
            if (enabled)
            {
                button.BackColor = COLOR_ENABLED;
            }
            else
            {
                button.BackColor = COLOR_DISABLED;
            }
        }

        /* Enable the given button. */
        private void EnableButton(Button button)
        {
        }

        /* Update the displays showing each player's last move. */
        private void UpdatePreviousMoveDisplays(ShotgunMove userMove, ShotgunMove computerMove)
        {
            textBoxUserPreviousMove.Text = ShotgunMoveToString(userMove);
            textBoxComputerPreviousMove.Text = ShotgunMoveToString(computerMove);
        }

        /* Convert the given ShotgunMove to an 3rd-person string. */
        private string ShotgunMoveToString(ShotgunMove move)
        {
            switch (move)
            {
                case ShotgunMove.Reload: return "reloads.";
                case ShotgunMove.Shoot: return "shoots!";
                case ShotgunMove.ShootShotgun: return "shoots with a shotgun!";
                case ShotgunMove.Block: return "blocks.";

                default: throw new ArgumentException("Not a valid ShotgunMove: " + move.ToString());
            }
        }

        /* Update the contents of the bullets loaded text boxes. */
        private void UpdateBulletsLoadedDisplays()
        {
            string templateText = "Bullets: ";
            textBoxUserBulletsLoaded.Text = templateText + user.bulletsLoaded.ToString();
            textBoxComputerBulletsLoaded.Text = templateText + computer.bulletsLoaded.ToString();
        }

        /* Return whether or not move1 beats move2, winning the game. */
        private bool MoveWins(ShotgunMove move1, ShotgunMove move2)
        {
            return
                (move1 == ShotgunMove.ShootShotgun && move2 != ShotgunMove.ShootShotgun) ||
                (move1 == ShotgunMove.Shoot && move2 == ShotgunMove.Reload);
        }
        
        /* Reset the game. */
        private void ResetGame()
        {
            user = new Player();
            computer = new Player();

            UpdateBulletsLoadedDisplays();
            UpdateUserButtons();

            textBoxUserPreviousMove.Text = "";
            textBoxComputerPreviousMove.Text = "";
        }

        /* AI for determining the computer's move. */
        private ShotgunMove GetComputerMove()
        {
            if (computer.bulletsLoaded == 3)
            {   // Shotgun acquired - shoot for guarenteed win.
                return ShotgunMove.ShootShotgun;
            }
            else if (user.bulletsLoaded == 0)
            {   // No reason to block.
                if (computer.bulletsLoaded == 0)
                {   // No bullets - must reload.
                    return ShotgunMove.Reload;
                }
                else if (computer.bulletsLoaded == 2)
                {   // Go for 3 bullets = shotgun = guarenteed win next turn.
                    return ShotgunMove.Reload;
                }
                else
                {
                    return RandomMove(ShotgunMove.Reload, ShotgunMove.Shoot);
                }
            }
            else
            {
                if (computer.bulletsLoaded == 0)
                {   // Can't shoot.
                    return RandomMove(ShotgunMove.Reload, ShotgunMove.Block);
                }
                else
                {
                    return RandomMove(ShotgunMove.Reload, ShotgunMove.Shoot, ShotgunMove.Block);
                }
            }
        }

        /* Return a random move from the given moves. */
        private ShotgunMove RandomMove(params ShotgunMove[] moves)
        {
            int randomIndex = new Random().Next(moves.Length);
            ShotgunMove randomMove = (ShotgunMove)moves.GetValue(randomIndex);
            return randomMove;
        }


        private void buttonReload_Click(object sender, EventArgs e)
        {
            MakeMove(ShotgunMove.Reload);
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            MakeMove(ShotgunMove.Shoot);
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            MakeMove(ShotgunMove.Block);
        }

        private void buttonShootShotgun_Click(object sender, EventArgs e)
        {
            MakeMove(ShotgunMove.ShootShotgun);
        }

    }
}
