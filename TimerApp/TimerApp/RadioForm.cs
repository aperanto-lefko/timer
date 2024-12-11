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
    public partial class RadioForm : BaseForm
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
            else if (yandexBut.Checked)
            {
                GoToRadio(" https://music.yandex.ru");

            }
            this.Close();
        }
        private void GoToRadio(string url)
        {
            Process.Start((new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }));
        }


        private void confirmRadioBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.confirm, confirmRadioBut);
        private void closeRadioBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeRadioBut);
        private void closeRadioBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
