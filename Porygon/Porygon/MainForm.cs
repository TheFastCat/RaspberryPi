using System;
using System.Windows.Forms;

namespace Porygon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
