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
    public partial class BaseForm : Form
    {
        
        protected void DrawPictureBoxImage(PaintEventArgs e, byte[] imageData, PictureBox pictureBox) //назначение картинок для полей
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                using (Image image = Image.FromStream(ms))
                {
                    e.Graphics.DrawImage(image, 0, 0, pictureBox.Width, pictureBox.Height);
                }
            }
        }
        protected void DrawButtonImage(PaintEventArgs e, byte[] imageData, Control button) //назначение картинок для кнопок
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                using (Image image = Image.FromStream(ms))
                {
                    e.Graphics.DrawImage(image, 0, 0, button.Width, button.Height);
                }
            }
        }

    }
}
