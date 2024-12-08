using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class UserControl_Run_up : UserControl
    {
        public string SumMinits { get; private set; }
        public UserControl_Run_up()
        {
            InitializeComponent();
            timeBox1.Text = "0";
            SumMinits = "0";
            timeBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void butMinus_Paint(object sender, PaintEventArgs e)
        {
            Image minus = Image.FromFile("Resources\\minus.png");
            e.Graphics.DrawImage(minus, 0, 0, butMinus.Width, butMinus.Height);
        }

        private void butPlus1_Paint(object sender, PaintEventArgs e)
        {
            Image minus = Image.FromFile("Resources\\plus.png");
            e.Graphics.DrawImage(minus, 0, 0, butMinus.Width, butMinus.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image men = Image.FromFile("Resources\\men.png");
            e.Graphics.DrawImage(men, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void butPlus1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timeBox1.Text, out int currentValue))
            {
                currentValue++; // Увеличиваем значение

                timeBox1.Text = currentValue.ToString(); // Обновляем текстовое поле

            }
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timeBox1.Text, out int currentValue))
            {
                currentValue--; // Увеличиваем значение
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                timeBox1.Text = currentValue.ToString(); // Обновляем текстовое поле

            }
        }
    }
}
