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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;
        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_hover;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_normal;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GamePage game = new GamePage();
            game.ShowDialog();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            OptionPage option = new OptionPage();
            option.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\CHOPER CHAOS\CHOPER CHAOS\Resources\background music.wav");
            player.PlayLooping();

        }
       
    }
}
