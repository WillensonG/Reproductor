using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnRepro_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
