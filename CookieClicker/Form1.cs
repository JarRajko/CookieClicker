using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        private int clicks = 0;

        public Form1()
        {
            InitializeComponent();

            cookiePictureBox.Image = Properties.Resources.enlargedCookie;

        }

        private void cookiePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            cookiePictureBox.Image = Properties.Resources.cookie;
            clicks++;
            clicksLabel.Text = "Clicks " + clicks;
        }

        private void cookiePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            cookiePictureBox.Image = Properties.Resources.enlargedCookie;
        }

        private void cookiePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
