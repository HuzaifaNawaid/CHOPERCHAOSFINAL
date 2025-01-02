namespace CHOPER_CHAOS
{
    partial class OptionPage
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
            this.btn_mute = new System.Windows.Forms.PictureBox();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.option_menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mute
            // 
            this.btn_mute.Image = global::CHOPER_CHAOS.Properties.Resources.sound_off;
            this.btn_mute.Location = new System.Drawing.Point(518, 234);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(96, 87);
            this.btn_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_mute.TabIndex = 3;
            this.btn_mute.TabStop = false;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // btn_sound
            // 
            this.btn_sound.Image = global::CHOPER_CHAOS.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(335, 234);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(103, 87);
            this.btn_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_sound.TabIndex = 2;
            this.btn_sound.TabStop = false;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // option_menu
            // 
            this.option_menu.Image = global::CHOPER_CHAOS.Properties.Resources.option_menu;
            this.option_menu.Location = new System.Drawing.Point(207, 23);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(529, 430);
            this.option_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option_menu.TabIndex = 0;
            this.option_menu.TabStop = false;
            // 
            // OptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 478);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.option_menu);
            this.Name = "OptionPage";
            this.Text = "OptionPage";
            ((System.ComponentModel.ISupportInitialize)(this.btn_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox option_menu;
        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.PictureBox btn_mute;
    }
}