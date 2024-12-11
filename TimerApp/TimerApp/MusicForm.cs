using NAudio.Wave;
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
    public partial class MusicForm : BaseForm
    {
        private List<string> musicFiles = new List<string>();
        private WaveOutEvent waveOut; // объект для воспроизведения аудиофайлов. WaveOutEvent — это класс из библиотеки NAudio, который позволяет воспроизводить звук.
        private AudioFileReader audioFileReader; //объект, который используется для чтения аудиофайлов (например, WAV, MP3 и т.д.) и получения информации о них
        public MusicForm()
        {
            InitializeComponent();
           
        }

        private void addMusicBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, addMusicBut);

        private void closeBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeBut);
        private void pauseBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.pause, pauseBut);
        private void playBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.play, playBut);

        private void setSizeForm()
        {
            this.Height = tableLayoutPanel1.Height + tableLayoutPanel2.Height + tableLayoutPanel3.Height;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 0, 0, tableLayoutPanel2.Width, 0); //рисование линии между двух точек с координатами по верху tablLP
            pen.Dispose();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 0, tableLayoutPanel1.Height, tableLayoutPanel1.Width, tableLayoutPanel1.Height); 
            pen.Dispose();
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMusicBut_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) //открытие окна для выбора
            {
                openFileDialog.Filter = "Audio files |*.mp3;*.wav;*.aac;*.flac";
                openFileDialog.Title = "Выберите файлы для воспроизведения";
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = "E:\\ITMO\\Windows C#\\Timer\\TimerApp\\music";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                   
                {
                    musicFiles.AddRange(openFileDialog.FileNames
                        .Select(filePath => Path.GetFileName(filePath)));
                        

                    

                    StringBuilder sb = new StringBuilder();
                    foreach (var item in musicFiles)
                    {
                        sb.AppendLine(item);
                    }
                    playListLab.Text = sb.ToString();
                   // tableLayoutPanel3.Height = musicFiles.Count * 30;
                    //setSizeForm();
                }
            }
        }

       
    }
}

