using System;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Linq;
using System.Drawing;
using Porygon.Properties;

namespace Porygon
{
    public partial class MainForm : Form
    {
        private Random _random = new Random();
        private int _currentIndex = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
            int rand;
            do
            { rand = _random.Next(0,16);}
            while(rand == _currentIndex);

            _currentIndex = rand;
            
            switch(_currentIndex)
            {
                case 0: this.pictureBox.Image = Resources.active; break;
                case 1: this.pictureBox.Image = Resources.artificial; break;
                case 2: this.pictureBox.Image = Resources.backgroundmove; break;
                case 3: this.pictureBox.Image = Resources.classic; break;
                case 4: this.pictureBox.Image = Resources.classy; break;
                case 5: this.pictureBox.Image = Resources.code; break;
                case 6: this.pictureBox.Image = Resources.freakout; break;
                case 7: this.pictureBox.Image = Resources.fuzz; break;
                case 8: this.pictureBox.Image = Resources.glitch; break;
                case 9: this.pictureBox.Image = Resources.happy; break;
                case 10: this.pictureBox.Image = Resources.hyper; break;
                case 11: this.pictureBox.Image = Resources.lofi; break;
                case 12: this.pictureBox.Image = Resources.matrix; break;
                case 13: this.pictureBox.Image = Resources.miamivice; break;
                case 14: this.pictureBox.Image = Resources.party; break;
                case 15: this.pictureBox.Image = Resources.rotating; break;
                case 16: this.pictureBox.Image = Resources.surprise; break;
                case 17: this.pictureBox.Image = Resources.threed; break;
            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
