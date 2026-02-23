using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cookiePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            cookiePictureBox.Image = Properties.Resources.cookie;
        }

        private void cookiePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            cookiePictureBox.Image = Properties.Resources.enlargedCookie;
        }
    }
}
