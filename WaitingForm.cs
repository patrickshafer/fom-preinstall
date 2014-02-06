using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fom_waiting
{
    public partial class WaitingForm : Form
    {

        public WaitingForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WaitingForm_Load(object sender, EventArgs e)
        {
            string[] SoundList = {
                                     @"Resources\Music\Tokyo\Enter.wav",
                                     @"Resources\Music\Tokyo\Enter2.wav",
                                     @"Resources\Music\Paris\Enter.wav",
                                     @"Resources\Music\Menu\Standard.wav"
                                 };
            string SelectedSound = SoundList[new Random().Next(SoundList.Length)];


            if (System.IO.File.Exists(SelectedSound))
            {
                MP3Player player = new MP3Player();
                player.Open(SelectedSound);
                player.Play(false);
            }
        }
    }
}
