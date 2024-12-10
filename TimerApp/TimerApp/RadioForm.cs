using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class RadioForm : Form
    {
        public RadioForm()
        {
            InitializeComponent();
        }

        private void confirmRadioBut_Click(object sender, EventArgs e)
        {
            if (monteCarloBut.Checked)
            {
                GoToRadio("https://montecarlo.ru/");
            }
            else if (europaPlBut.Checked)
            {
                GoToRadio("https://europaplus.ru/");
            }
            else if (energyBut.Checked)
            {
                GoToRadio("https://www.energyfm.ru/");
            }
            else if (hitFmBut.Checked)
            {
                GoToRadio("https://hitfm.ru/");
            }
            else if (maximumBut.Checked)
            {
                GoToRadio("https://maximum.ru/");
            }


            this.Close();
        }
        private void GoToRadio(string url)
        {
            Process.Start((new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }));
        }




        private void DrawButtonImage(PaintEventArgs e, byte[] imageData, Control button) //назначение картинок для кнопок
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                using (Image image = Image.FromStream(ms))
                {
                    e.Graphics.DrawImage(image, 0, 0, button.Width, button.Height);
                }
            }
        }
        private void confirmRadioBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.confirm, confirmRadioBut);
        private void closeRadioBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeRadioBut);

        private void closeRadioBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
