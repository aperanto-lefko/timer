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
        private Queue<string> musicFiles;

        private WaveOutEvent waveOut; // объект для воспроизведения аудиофайлов. WaveOutEvent — это класс из библиотеки NAudio, который позволяет воспроизводить звук.
        private AudioFileReader audioFileReader; //объект, который используется для чтения аудиофайлов (например, WAV, MP3 и т.д.) и получения информации о них
        private bool isPaused;
        private bool isPlaying;
        private TimeSpan playListTime;
        private TimeSpan trackTime;
        private string trackTitle;
        private System.Windows.Forms.Timer fullTimer;  //таймер на полное время
        private System.Windows.Forms.Timer trackTimer;



        public MusicForm()
        {
            InitializeComponent();
            fullTimer = new System.Windows.Forms.Timer();
            fullTimer.Interval = 1000; // Интервал 1 секунда
            fullTimer.Tick += Timer_TickFull;

            trackTimer = new System.Windows.Forms.Timer();
            trackTimer.Interval = 1000; // Интервал 1 секунда
            trackTimer.Tick += Timer_TickTrack;
        }
        private void Timer_TickFull(object sender, EventArgs e)
        {
            
            playListTime = playListTime.Subtract(TimeSpan.FromSeconds(1)); // Уменьшаем TimeSpan на 1 секунду
            plListTimeLab.Text = $"Общее время: {playListTime.ToString((@"mm\:ss"))}"; // Обновляем текст метки
            
        }
        private void Timer_TickTrack(object sender, EventArgs e)
        {
            trackTime = trackTime.Subtract(TimeSpan.FromSeconds(1));
            trackLab.Text = $"{trackTitle} : {trackTime.ToString(@"mm\:ss")}";
        }

        private void addMusicBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, addMusicBut);

        private void closeBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeBut);
        private void pauseBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.pause, pauseBut);
        private void playBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.play, playBut);



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
            isPlaying = false;

            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
            }
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

                //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //папка мои документы
                //"E:\\ITMO\\Windows C#\\Timer\\TimerApp\\music";

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {
                    if (musicFiles == null)
                    {
                        musicFiles = new Queue<string>(openFileDialog.FileNames); //создаем новую очередь из файлов музыки 
                    }
                    else
                    {
                        foreach (string file in openFileDialog.FileNames)
                            musicFiles.Enqueue(file);
                    }

                    foreach (string file in musicFiles)
                    {
                        using (audioFileReader = new AudioFileReader(file)) ;
                        playListTime += audioFileReader.TotalTime;
                    }
                    
                    plListTimeLab.Text = $"Общее время: {playListTime.ToString((@"mm\:ss"))}";
                    SetPlayListLabel(musicFiles); //после создания очереди формируем список треков

                }
            }
        }
        private void SetPlayListLabel(Queue<string> queue)
        {
            StringBuilder sb = new StringBuilder(); //создание playlist
            foreach (var item in musicFiles)
            {
                sb.AppendLine(Path.GetFileName(item));
            }
            playListLab.Text = sb.ToString();

        }

        private void playBut_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Task.Run(() => PlayNextTrack()); //Task.Run создает задачу, которая выполняется асинхронно
                fullTimer.Start();
                trackTimer.Start();
            }
            else if (isPaused) //если были на паузе
            {
                waveOut?.Play();
                isPaused = false;
                fullTimer.Start();
                trackTimer.Start();
            }
        }

        private void PlayNextTrack()
        {

            if (musicFiles.Count != 0 && isPlaying)
            {
               
                string file = musicFiles.Dequeue();
                SetPlayListLabel(musicFiles);
                using (audioFileReader = new AudioFileReader(file))
                {
                    waveOut = new WaveOutEvent(); //создается WaveOutEven для воспроизведения каждого файла
                    waveOut.Init(audioFileReader); //инициализация waveOut с помощью audioFileReader
                    trackTime = audioFileReader.TotalTime;
                    trackTitle = Path.GetFileName(file);
                    //UpdateLabel(trackTitle, trackTime); //TODO проверить
                    trackLab.Text = $"{trackTitle} : {trackTime.ToString(@"mm\:ss")}"; //начальное значение метки
                    waveOut.Play(); //воспроизведение

                    waveOut.PlaybackStopped += OnPlaybackStopped; //подписываемся на событие когда трек кончился/остановился
                    
                    //Task.Run(() => UpdateLabel(file, trackTime)); //если без потока музыка спотыкается

                }
            }


        }
        /*private void UpdateLabel(string file, TimeSpan trackTime)
        {
            if (trackLab.InvokeRequired) // проверяет, вызывается ли метод из другого потока относительно того, в котором был создан trackLab. Элементы управления интерфейса
                                         //(например, метки на форме) могут обновляться только из главного потока (UI поток).
                                         //Если InvokeRequired истинно (т.е. метод вызывается не из главного потока), то следует сделать следующее:
                                         //нас интересует trackLab, поэтому InvokeRequired привязан к нему
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
        }*/
        private void pauseBut_Click(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
                fullTimer.Stop();
                trackTimer.Stop();
                isPaused = true;
            }
        }

        private void OnPlaybackStopped(object sender, EventArgs e) //реакция на окончание трека
        {
            waveOut?.Dispose();
           
            if (musicFiles.Count != 0)
            {
                
                Task.Run(() => PlayNextTrack());
                
            }
            else
            {
                isPlaying = false;
                fullTimer.Stop();
                trackTimer.Stop();
                plListTimeLab.Text = "";
                trackLab.Text = "";
            }
        }

    }
}


