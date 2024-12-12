using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class MusicForm : BaseForm
    {
        private Queue<string> musicFiles = new Queue<string>();

        private WaveOutEvent waveOut; // объект для воспроизведения аудиофайлов. WaveOutEvent — это класс из библиотеки NAudio, который позволяет воспроизводить звук.
        private AudioFileReader audioFileReader; //объект, который используется для чтения аудиофайлов (например, WAV, MP3 и т.д.) и получения информации о них
        private bool isPaused;
        private bool isPlaying;
        
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
            waveOut.Stop();
            waveOut.Dispose();
            this.Close();
        }

        private void addMusicBut_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) //открытие окна для выбора
            {
                openFileDialog.Filter = "Audio files |*.mp3";
                openFileDialog.Title = "Выберите файлы для воспроизведения";
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = "E:\\ITMO\\Windows C#\\Timer\\TimerApp\\music";

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {

                    musicFiles = new Queue<string>(openFileDialog.FileNames); //создаем новую очередь из файлов музыки 
                   

                    StringBuilder sb = new StringBuilder();
                    foreach (var item in musicFiles)
                    {
                        sb.AppendLine(Path.GetFileName(item));
                    }
                    playListLab.Text = sb.ToString();
                    // tableLayoutPanel3.Height = musicFiles.Count * 30;
                    //setSizeForm();
                }
            }
        }
       
        private void playBut_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Task.Run(() => PlayNextTrack()); //Task.Run создает задачу, которая выполняется асинхронно
            }
            else if (isPaused)
            {
                waveOut?.Play();
                isPaused = false;
            }
        }

        private void PlayNextTrack()
        {
            if (musicFiles.Count!=0)
            {
                string file = musicFiles.Dequeue();
                using (audioFileReader = new AudioFileReader(file))
                {
                    waveOut = new WaveOutEvent(); //создается WaveOutEven для воспроизведения каждого файла
                    waveOut.Init(audioFileReader); //инициализация waveOut с помощью audioFileReader
                    waveOut.Play(); //воспроизведение
                    
                    waveOut.PlaybackStopped += OnPlaybackStopped; //подписываемся на событие когда трек кончился/остановился
                                                                  
                    Task.Run(() => UpdateLabel(file, audioFileReader.TotalTime)); //если без потока музыка спотыкается

                }
            }


        }
        private void UpdateLabel(string file, TimeSpan trackTime)
        {
            if (trackLab.InvokeRequired) // проверяет, вызывается ли метод из другого потока. Элементы управления интерфейса
                                         //(например, метки на форме) могут обновляться только из главного потока (UI поток).
                                         //Если InvokeRequired истинно (т.е. метод вызывается не из главного потока), то следует сделать следующее:
            {
                trackLab.Invoke(new Action(() => UpdateLabel(file, trackTime))); //здесь мы говорим программе: "Запусти метод UpdateLabel снова,
                                                                                 //но теперь в главном потоке". Это безопасно и позволит обновить
                                                                                 //текст метки без ошибок.
                                                                                 //Здесь мы создаем анонимный метод (Action), который вызывает
                                                                                 //UpdateLabel с теми же параметрами, что и текущий вызов.
            }
            else
            {
                trackLab.Text = $"{Path.GetFileName(file)} : {trackTime.ToString(@"mm\:ss")}";
            }
        }
        private void pauseBut_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
                isPaused = true;
            }
        }

        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut?.Dispose();
            
            if(musicFiles.Count!=0)
            {
                Task.Run(() => PlayNextTrack());
            } else
            {
                isPlaying = false;
                
            }
        }

    }
}


