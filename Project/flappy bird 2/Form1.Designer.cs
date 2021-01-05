
namespace flappy_bird_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.Land = new System.Windows.Forms.PictureBox();
            this.TubeDown = new System.Windows.Forms.PictureBox();
            this.TubeUp = new System.Windows.Forms.PictureBox();
            this.Flappy = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Land)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(397, 433);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(103, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Flappy Game";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHighScore.Location = new System.Drawing.Point(64, 433);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(88, 17);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "High Score";
            // 
            // Land
            // 
            this.Land.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Land.Image = global::flappy_bird_2.Properties.Resources.land2;
            this.Land.Location = new System.Drawing.Point(0, 411);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(905, 57);
            this.Land.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Land.TabIndex = 3;
            this.Land.TabStop = false;
            // 
            // TubeDown
            // 
            this.TubeDown.BackColor = System.Drawing.Color.Transparent;
            this.TubeDown.Image = global::flappy_bird_2.Properties.Resources.tube1;
            this.TubeDown.Location = new System.Drawing.Point(787, 256);
            this.TubeDown.Name = "TubeDown";
            this.TubeDown.Size = new System.Drawing.Size(54, 161);
            this.TubeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TubeDown.TabIndex = 2;
            this.TubeDown.TabStop = false;
            // 
            // TubeUp
            // 
            this.TubeUp.BackColor = System.Drawing.Color.Transparent;
            this.TubeUp.Image = global::flappy_bird_2.Properties.Resources.tube2;
            this.TubeUp.Location = new System.Drawing.Point(423, 0);
            this.TubeUp.Name = "TubeUp";
            this.TubeUp.Size = new System.Drawing.Size(54, 161);
            this.TubeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TubeUp.TabIndex = 1;
            this.TubeUp.TabStop = false;
            // 
            // Flappy
            // 
            this.Flappy.BackColor = System.Drawing.Color.Transparent;
            this.Flappy.Image = global::flappy_bird_2.Properties.Resources.flappy;
            this.Flappy.Location = new System.Drawing.Point(150, 12);
            this.Flappy.Name = "Flappy";
            this.Flappy.Size = new System.Drawing.Size(79, 50);
            this.Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy.TabIndex = 0;
            this.Flappy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::flappy_bird_2.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.ClientSize = new System.Drawing.Size(904, 466);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.TubeDown);
            this.Controls.Add(this.TubeUp);
            this.Controls.Add(this.Flappy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Land)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Flappy;
        private System.Windows.Forms.PictureBox TubeUp;
        private System.Windows.Forms.PictureBox TubeDown;
        private System.Windows.Forms.PictureBox Land;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

