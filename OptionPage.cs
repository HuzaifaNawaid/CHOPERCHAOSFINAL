using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHOPER_CHAOS
{
    public partial class OptionPage : Form
    {
        public OptionPage()
        {
            InitializeComponent();
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\CHOPER CHAOS\CHOPER CHAOS\Resources\background music.wav");
            player.PlayLooping();
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\CHOPER CHAOS\CHOPER CHAOS\Resources\background music.wav");
            player.Stop();
        }
    }
}
