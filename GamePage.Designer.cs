namespace CHOPER_CHAOS
{
    partial class GamePage
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.lblgameover = new System.Windows.Forms.Label();
            this.RESTART = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.game_overbox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtlevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.game_overbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(233, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(104, 31);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = global::CHOPER_CHAOS.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(758, 201);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(130, 98);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::CHOPER_CHAOS.Properties.Resources.helicopter;
            this.player.Location = new System.Drawing.Point(47, 114);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(154, 74);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.BackColor = System.Drawing.Color.Transparent;
            this.pillar2.Image = global::CHOPER_CHAOS.Properties.Resources.pillar2final;
            this.pillar2.Location = new System.Drawing.Point(257, 265);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(107, 227);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // pillar1
            // 
            this.pillar1.BackColor = System.Drawing.Color.Transparent;
            this.pillar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pillar1.Image = global::CHOPER_CHAOS.Properties.Resources.pillar1final;
            this.pillar1.Location = new System.Drawing.Point(594, -21);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(102, 201);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.ForeColor = System.Drawing.Color.White;
            this.lblgameover.Location = new System.Drawing.Point(243, 59);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(429, 73);
            this.lblgameover.TabIndex = 0;
            this.lblgameover.Text = "GAME OVER";
            // 
            // RESTART
            // 
            this.RESTART.AutoSize = true;
            this.RESTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESTART.ForeColor = System.Drawing.Color.Black;
            this.RESTART.Location = new System.Drawing.Point(330, 171);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(255, 55);
            this.RESTART.TabIndex = 1;
            this.RESTART.Text = "RESTART";
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.Black;
            this.EXIT.Location = new System.Drawing.Point(402, 273);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(134, 55);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CHOPER_CHAOS.Properties.Resources.alien3;
            this.pictureBox2.Location = new System.Drawing.Point(691, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CHOPER_CHAOS.Properties.Resources.alien3;
            this.pictureBox3.Location = new System.Drawing.Point(61, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // game_overbox
            // 
            this.game_overbox.BackColor = System.Drawing.Color.Transparent;
            this.game_overbox.Controls.Add(this.pictureBox3);
            this.game_overbox.Controls.Add(this.pictureBox2);
            this.game_overbox.Controls.Add(this.EXIT);
            this.game_overbox.Controls.Add(this.RESTART);
            this.game_overbox.Controls.Add(this.lblgameover);
            this.game_overbox.Location = new System.Drawing.Point(-8, -8);
            this.game_overbox.Name = "game_overbox";
            this.game_overbox.Size = new System.Drawing.Size(943, 526);
            this.game_overbox.TabIndex = 5;
            this.game_overbox.TabStop = false;
            this.game_overbox.Text = "GAME OVER";
            // 
            // txtlevel
            // 
            this.txtlevel.AutoSize = true;
            this.txtlevel.BackColor = System.Drawing.Color.Transparent;
            this.txtlevel.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlevel.ForeColor = System.Drawing.Color.White;
            this.txtlevel.Location = new System.Drawing.Point(74, 9);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(98, 31);
            this.txtlevel.TabIndex = 6;
            this.txtlevel.Text = "Level  1";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHOPER_CHAOS.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 478);
            this.Controls.Add(this.game_overbox);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.txtlevel);
            this.Name = "GamePage";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.game_overbox.ResumeLayout(false);
            this.game_overbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.Label RESTART;
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox game_overbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label txtlevel;
    }
}

