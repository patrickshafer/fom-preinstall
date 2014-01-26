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
            if (System.IO.File.Exists(@"Resources\Music\Tokyo\Enter.wav"))
            {
                MP3Player player = new MP3Player();
                player.Open(@"Resources\Music\Tokyo\Enter.wav");
                player.Play(false);
            }
        }
    }
}
