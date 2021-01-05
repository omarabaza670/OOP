using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int garvity = 20;

        int speed = 15;

        Random r = new Random();

        int Score = 0;

        int HighScore = 0;

        int LastScore = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Flappy.Top += garvity;
            TubeUp.Left -= speed;
            TubeDown.Left -= speed;

            lblScore.Text = $"Your Score Now : {Score}";

            if (TubeDown.Left < 0)
            {
                
                TubeDown.Left = r.Next(780, 840);
                Score++;
                
            }

            if (TubeUp.Left < 0)
            {
                TubeUp.Left = r.Next(500, 650);
                Score++;
                
                
            }

            

            if (Flappy.Bounds.IntersectsWith(TubeDown.Bounds) || Flappy.Bounds.IntersectsWith(TubeUp.Bounds) || Flappy.Bounds.IntersectsWith(Land.Bounds))
            {
                timer1.Stop();
                lblScore.Text = $"Game Over Your Score : {Score}";

                if (Score > LastScore)
                {
                    HighScore = Score;
                    lblHighScore.Text = $"HighScore : {HighScore}";
                }
                else
                 {

                    lblHighScore.Text = $"HighScore : {HighScore}";
                }

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (timer1.Enabled == false)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    

                    timer1.Start();

                    Score = 0;

                    lblScore.Text = $"Your Score : {Score}";

                    LastScore = Score;

                    lblHighScore.Text = $"HighScore : {HighScore}";

                    if (Score > LastScore)
                    {

                        HighScore = Score;
                        lblHighScore.Text = $"HighScore : {HighScore}";

                    }
                    else
                    {

                        lblHighScore.Text = $"HighScore : {HighScore}";

                    }
                    

                    
                    TubeDown.Left = r.Next(780, 840);

                    TubeUp.Left = r.Next(500, 600);

                    Flappy.Top = 50;


                    
                }
            }
            
            if ( e.KeyCode == Keys.Space)
            {
                garvity = -15;
            }
            
            if (Flappy.Top < 2) 
            {  
                Flappy.Top = 3;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                garvity = 15;
            }
        }
    }
}
