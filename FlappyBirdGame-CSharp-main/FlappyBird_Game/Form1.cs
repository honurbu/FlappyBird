using System;
using System.Windows.Forms;

namespace FlappyBird_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed;
        int gravity = 5;
        int score = 0;
        bool isGameStarted = false;
        int highestScore = 0; 


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            if (isGameStarted)
            {
                pictureBox_Bird.Top += gravity;
                pictureBox_Bottom.Left -= pipeSpeed;
                picturebox_top.Left -= pipeSpeed;
                label1.Text = "SCORE: " + score;

                if (pictureBox_Bottom.Left < -150)
                {
                    pictureBox_Bottom.Left = 800;
                    score++;
                }
                if (picturebox_top.Left < -180)
                {
                    picturebox_top.Left = 950;
                    score++;
                }
                if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Bottom.Bounds) ||
                    pictureBox_Bird.Bounds.IntersectsWith(picturebox_top.Bounds) ||
                    pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) || pictureBox_Bird.Top < -25)
                {
                    EndGame();
                }

                if (score > highestScore)
                {
                    highestScore = score;
                }
            }
        }

        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER! Press Enter to restart";
            isGameStarted = false;
            label2.Visible = true;

            pictureBox_Bottom.Left = 800;
            picturebox_top.Left = 950;

            pictureBox_Bird.Top = 100;

            score = 0;
            label1.Text = "SCORE: " + score;

            if (score > highestScore)
            {
                highestScore = score;
            }

            label3.Text = "Highest Score: " + highestScore;
            pictureBox1.Visible = true;

        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                label2.Visible = false;

                if (!isGameStarted)
                {
                    isGameStarted = true;

                    pipeSpeed = 15;

                    timer_GameControl.Start();

                    Timer speedIncreaseTimer = new Timer();
                    speedIncreaseTimer.Interval = 15000; // 15 seconds
                    speedIncreaseTimer.Tick += SpeedIncreaseTimer_Tick;
                    speedIncreaseTimer.Start();
                }
            }
        }

        private void SpeedIncreaseTimer_Tick(object sender, EventArgs e)
        {
            pipeSpeed += 2;
           
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
