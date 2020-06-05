using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColorUpdate();
        }
        ToolTip ttColor = new ToolTip();
        string curColor;
        public void ColorUpdate()
        {
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            curColor = "#" + trackBarRed.Value.ToString("X") + trackBarGreen.Value.ToString("X") + trackBarBlue.Value.ToString("X");
            Clipboard.SetText(curColor);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }


        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }

        private void pictureBoxColor_MouseHover(object sender, EventArgs e)
        {
            ttColor.SetToolTip(pictureBoxColor, curColor);
        }
    }
}