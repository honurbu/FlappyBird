﻿
namespace FlappyBird_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bird = new System.Windows.Forms.PictureBox();
            this.picturebox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(291, 730);
            this.label2.Margin = new System.Windows.Forms.Padding(12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başla";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::FlappyBird_Game.Properties.Resources.ground;
            this.pictureBox_Ground.Location = new System.Drawing.Point(-20, 660);
            this.pictureBox_Ground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(867, 161);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 3;
            this.pictureBox_Ground.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.pictureBox_Bottom.Location = new System.Drawing.Point(359, 441);
            this.pictureBox_Bottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(169, 277);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 2;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_Bird
            // 
            this.pictureBox_Bird.Image = global::FlappyBird_Game.Properties.Resources.bird;
            this.pictureBox_Bird.Location = new System.Drawing.Point(51, 230);
            this.pictureBox_Bird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Bird.Name = "pictureBox_Bird";
            this.pictureBox_Bird.Size = new System.Drawing.Size(95, 80);
            this.pictureBox_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bird.TabIndex = 1;
            this.pictureBox_Bird.TabStop = false;
            // 
            // picturebox_top
            // 
            this.picturebox_top.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.picturebox_top.Location = new System.Drawing.Point(493, -1);
            this.picturebox_top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picturebox_top.Name = "picturebox_top";
            this.picturebox_top.Size = new System.Drawing.Size(169, 233);
            this.picturebox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_top.TabIndex = 0;
            this.picturebox_top.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird_Game.Properties.Resources.gameover;
            this.pictureBox1.Location = new System.Drawing.Point(291, 263);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(797, 810);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.pictureBox_Bird);
            this.Controls.Add(this.picturebox_top);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_top;
        private System.Windows.Forms.PictureBox pictureBox_Bird;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_GameControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

