using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPAssignment6
{
    public partial class ColorMixer : UserControl
    {
        public int redValue;
        public int greenValue;
        public int blueValue;
        public ColorMixer()
        {
            InitializeComponent();
        }
        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redValue = redTrackBar.Value;
            greenValue = greenTrackBar.Value;
            blueValue = blueTrackBar.Value;
            colorDisplay.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
            redColor.Text = redValue.ToString();
            greenColor.Text = greenValue.ToString();
            blueColor.Text = blueValue.ToString();

        }
        private void ColoMixer_Load(object sender, EventArgs e)
        {

        }
    }
}
