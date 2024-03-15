using System.Diagnostics;
using System.Windows.Forms;

namespace ControlsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZANKA NO TACHI");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=vL5TDOjPjWY&ab_channel=CarolinaAyala",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar el valor del ProgressBar con el valor del NumericUpDown
            progressBar1.Minimum = (int)numericUpDown1.Minimum;
            progressBar1.Maximum = (int)numericUpDown1.Maximum;
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                notifyIcon1.Icon =SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Your Form has been minimized"; notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Your Form has come back to Normal"; 
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
    }
}
