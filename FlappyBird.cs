using System.Media;
namespace FlappyBirdGame
{
    public partial class FormFlappyBird : Form
    {
        public FormFlappyBird()
        {
            InitializeComponent();

            PicBxGround.Controls.Add(LbScore);
            LbScore.Left = 20;
            LbScore.Top = 25;

        }

        SoundPlayer sp = new SoundPlayer("AudioDollarChillStep.wav");

        int gravity = 15, pipespeed = 8, score = 0;
        bool gameover = false;

        Random randompipe = new Random();

        private void FormFlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            { gravity = -15; }
        }

        private void FormFlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            { gravity = 15; }

            if (gameover && e.KeyCode == Keys.R)
            {
                RestartGame();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PicBxBird.Top += gravity;
            PicBxPipeDown.Left -= pipespeed;
            PicBxPipeUp.Left -= pipespeed;
            LbScore.Text = $"Score: {score}";

            if (PicBxPipeDown.Left < -150)
            {
                PicBxPipeDown.Left = randompipe.Next(351, 801);
                score += 1;
            }
            if (PicBxPipeUp.Left < -200)
            {
                PicBxPipeUp.Left = randompipe.Next(501, 951);
                score += 1;
            }

            if (PicBxBird.Bounds.IntersectsWith(PicBxPipeDown.Bounds) ||
                PicBxBird.Bounds.IntersectsWith(PicBxPipeUp.Bounds) ||
                PicBxBird.Bounds.IntersectsWith(PicBxGround.Bounds) || PicBxBird.Top < -20)
            {
                EndGame();
            }

            if (score > 6) { pipespeed = 12; }
            if (score > 12) { pipespeed = 16; }
            if (score > 18) { pipespeed = 20; }
        }


        private void RestartGame()
        {
            gameover = false;

            PicBxBird.Location = new Point(50, 250);
            PicBxPipeDown.Left = 400;
            PicBxPipeUp.Left = 650;

            score = 0;
            pipespeed = 8;
            LbScore.Text = "Score: 0";
            PicBxRestart.Enabled = false;
            PicBxRestart.Visible = false;
            BtnStartGame.Enabled = false;
            BtnStartGame.Visible = false;
            GameTimer.Start();

            sp.PlayLooping();
        }
        private void EndGame()
        {
            GameTimer.Stop();
            LbScore.Text += " - Game Over !! Press 'R' To Restart";
            gameover = true;

            PicBxRestart.Enabled = true;
            PicBxRestart.Visible = true;

            sp.Stop();
        }


        private void PicBxBtnStart_Click(object sender, EventArgs e)
        {
            foreach (Control x in Controls)
            {
                if (x.Name == BtnStartGame.Name || x.Name == PicBxRestart.Name)
                { RestartGame(); }
            }

        }

        private void FormFlappyBird_Load(object sender, EventArgs e)
        {

        }
    }
}
