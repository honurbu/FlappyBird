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
            }
        }

        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER! Press Enter to restart";
            isGameStarted = false;

            // Boruların başlangıç konumunu sıfırla
            pictureBox_Bottom.Left = 800;
            picturebox_top.Left = 950;

            // Kuşun başlangıç pozisyonunu ayarla
            pictureBox_Bird.Top = 100;

            // Skoru sıfırla
            score = 0;
            label1.Text = "SCORE: " + score;
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!isGameStarted)
                {
                    isGameStarted = true;

                    // Oyuncunun seçtiği zorluğa göre hızı ayarla
                    if (comboBox_Difficulty.SelectedItem.ToString() == "Kolay")
                    {
                        pipeSpeed = 5;
                    }
                    else if (comboBox_Difficulty.SelectedItem.ToString() == "Orta")
                    {
                        pipeSpeed = 8;
                    }
                    else if (comboBox_Difficulty.SelectedItem.ToString() == "Zor")
                    {
                        pipeSpeed = 12;
                    }

                    timer_GameControl.Start();
                }
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Zorluk seçeneklerini ekleyin
            comboBox_Difficulty.Items.Add("Kolay");
            comboBox_Difficulty.Items.Add("Orta");
            comboBox_Difficulty.Items.Add("Zor");


            comboBox_Difficulty.DropDownStyle = ComboBoxStyle.DropDownList;

            // Varsayılan olarak Orta zorluk seçili olsun
            comboBox_Difficulty.SelectedItem = "Orta";
        }
    }
}
