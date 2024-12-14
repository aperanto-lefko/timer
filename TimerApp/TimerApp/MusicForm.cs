using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        private CancellationTokenSource cancellationTokenSource; //отслеживание отмены работы потока
        private bool isRewind;

        public MusicForm()
        {
            InitializeComponent();
            fullTimer = new System.Windows.Forms.Timer();
            fullTimer.Interval = 1000; // Интервал 1 секунда
            fullTimer.Tick += Timer_TickFull;

            trackTimer = new System.Windows.Forms.Timer();
            trackTimer.Interval = 1000; // Интервал 1 секунда
            trackTimer.Tick += Timer_TickTrack;
            waveOut = new WaveOutEvent(); //WaveOutEven для воспроизведения
            pauseBut.Enabled = false;
            playBut.Enabled = false;
            rewindBut.Enabled = false;
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
        private void rewindBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.rewind, rewindBut);


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
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //папка мои документы

                //"E:\\ITMO\\Windows C#\\Timer\\TimerApp\\music";

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {
                    if (musicFiles == null)
                    {
                        musicFiles = new Queue<string>(openFileDialog.FileNames); //создаем новую очередь из файлов музыки 
                        foreach (string file in musicFiles)
                        {
                            using (audioFileReader = new AudioFileReader(file)) ;
                            playListTime += audioFileReader.TotalTime;
                        }
                    }
                    else
                    {
                        foreach (string file in openFileDialog.FileNames)
                        {
                            musicFiles.Enqueue(file);
                            using (audioFileReader = new AudioFileReader(file)) ;
                            playListTime += audioFileReader.TotalTime;
                        }
                    }

                    plListTimeLab.Text = $"Общее время: {playListTime.ToString((@"mm\:ss"))}";
                    SetPlayListLabel(musicFiles); //после создания очереди формируем список треков

                    playBut.Enabled = true;

                }
            }
        }

        private void SetPlayListLabel(Queue<string> queue)
        {
            if (playListLab.InvokeRequired)
            {
                playListLab.Invoke(new Action(() => SetPlayListLabel(queue)));
            }
            else
            {
                StringBuilder sb = new StringBuilder(); //создание playlist
                foreach (var item in musicFiles)
                {
                    sb.AppendLine(Path.GetFileName(item));
                }
                playListLab.Text = sb.ToString();
            }
        }

        private void playBut_Click(object sender, EventArgs e)
        {
            playBut.Enabled = false;
            rewindBut.Enabled = true;
            pauseBut.Enabled = true;

            if (!isPlaying && !isPaused)
            {
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;
                isPlaying = true;
                isPaused = false;
                plListTimeLab.Text = $"Общее время: {playListTime.ToString((@"mm\:ss"))}";
                Task.Run(() => PlayNextTrack(token), token); //Task.Run создает задачу, которая выполняется асинхронно
                fullTimer.Start();
                trackTimer.Start();
            }
            else if (isPaused) //если были на паузе
            {

                waveOut?.Play();
                isPaused = false;
                isPlaying = true;
                fullTimer.Start();
                trackTimer.Start();
            }
        }
        private void pauseBut_Click(object sender, EventArgs e)
        {
            playBut.Enabled = true;
            rewindBut.Enabled = false;
            pauseBut.Enabled = false;

            fullTimer.Stop();
            trackTimer.Stop();

            isPaused = true;
            isPlaying = false;

        }
        private void rewindBut_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                isRewind = true;
            }
        }

        private void PlayNextTrack(CancellationToken token)
        {

            if (musicFiles.Count > 0 && isPlaying)
            {
                try
                {
                    if (isRewind) //пересчет времени при перемотке
                    {
                        playListTime = TimeSpan.Zero;
                        foreach (string track in musicFiles)
                        {
                            using (audioFileReader = new AudioFileReader(track)) ;
                            playListTime += audioFileReader.TotalTime;
                        }
                        Task.Run(() => UpdatePlayListTimeLabel(playListTime));
                        isRewind = false;
                    }
                    string file = musicFiles.Dequeue();

                    Task.Run(() => SetPlayListLabel(musicFiles)); //устанавливаем список песен без играющей песни, отдельный поток, т.к. обновление метки из другого потока недопустимо

                    using (audioFileReader = new AudioFileReader(file))
                    {
                        waveOut.Init(audioFileReader); //инициализация waveOut с помощью audioFileReader
                        trackTime = audioFileReader.TotalTime;
                        trackTitle = Path.GetFileName(file);

                        Task.Run(() => UpdateTrackLabel(trackTitle, trackTime)); //начальное значение метки
                        waveOut.Play(); //воспроизведение
                        //подписываемся на событие когда трек кончился/остановился
                        waveOut.PlaybackStopped += OnPlaybackStopped;

                        while (!token.IsCancellationRequested | isPaused | isRewind) //проверяем состояние флага
                        {
                            Thread.Sleep(100); //проверка с интервалом
                            if (token.IsCancellationRequested)
                            {
                                return;
                            }
                            if (isPaused && waveOut?.PlaybackState == PlaybackState.Playing)
                            {
                                while (!isPlaying)
                                {
                                    waveOut?.Pause();
                                    Thread.Sleep(100);
                                    
                                    if (isPlaying)
                                    {
                                        waveOut?.Play();
                                        break;
                                    }
                                    else if (token.IsCancellationRequested)
                                    {
                                        return;
                                    }
                                }
                            }
                            if (isRewind)
                            {
                                waveOut?.Stop();
                                break;
                            }
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    return;
                }
            }

        }

        private void UpdatePlayListTimeLabel(TimeSpan playListTime)
        {
            if (plListTimeLab.InvokeRequired)
            {
                plListTimeLab.Invoke(new Action(() => UpdatePlayListTimeLabel(playListTime)));

            }
            else
            {
                plListTimeLab.Text = $"Общее время: {playListTime.ToString((@"mm\:ss"))}";
            }
        }

        private void UpdateTrackLabel(string title, TimeSpan trackTime)
        {
            if (trackLab.InvokeRequired) // проверяет, вызывается ли метод из другого потока относительно того, в котором был создан trackLab. Элементы управления интерфейса
                                         //(например, метки на форме) могут обновляться только из главного потока (UI поток).
                                         //Если InvokeRequired истинно (т.е. метод вызывается не из главного потока), то следует сделать следующее:
                                         //нас интересует trackLab, поэтому InvokeRequired привязан к нему
            {
                trackLab.Invoke(new Action(() => UpdateTrackLabel(title, trackTime))); //здесь мы говорим программе: "Запусти метод UpdateLabel снова,
                                                                                       //но теперь в главном потоке". Это безопасно и позволит обновить
                                                                                       //текст метки без ошибок.
                                                                                       //Здесь мы создаем анонимный метод (Action), который вызывает
                                                                                       //UpdateLabel с теми же параметрами, что и текущий вызов.

            }
            else
            {
                trackLab.Text = $"{title} : {trackTime.ToString(@"mm\:ss")}";
            }
        }

       
        private void NextTrack()
        {

            if (musicFiles.Count != 0) //если в очереди еще остались треки-запускаем следующий
            {
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;
                Task.Run(() => PlayNextTrack(token), token);
            }
            else
            {
                cancellationTokenSource.Cancel();
                isPlaying = false;
                isPaused = false;
                isRewind = false;
                fullTimer.Stop();
                trackTimer.Stop();
                plListTimeLab.Text = ""; //обнуление меток с таймерами
                trackLab.Text = "";
            }
        }
        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            waveOut.PlaybackStopped -= OnPlaybackStopped;
            NextTrack();
        }
        
    }
}


//-----------------------------------------
//библиотека winmm.dll

/*
namespace TimerApp
{
    public partial class MusicForm : BaseForm
    {
        private Queue<string> musicFiles;


        private bool isPaused;
        private bool isPlaying;
        private int playListTime;
        private int trackTime;
        private string trackTitle;
        private System.Windows.Forms.Timer fullTimer;  //таймер на полное время
        private System.Windows.Forms.Timer trackTimer;
        private CancellationTokenSource cancellationTokenSource; //отслеживание отмены работы потока
        string command;
        string error = new string(' ', 128);
        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern int mciSendString(string command, string buffer, int bufferSize, IntPtr hwndCallback);
        //extern: Это ключевое слово указывает, что метод реализован вне текущего контекста, в данном случае —
        //в нативной библиотеке(DLL). В данном случае, это функция из библиотеки Windows API.
        //mciSendString:Это имя метода, который используется для отправки команд в интерфейс управления мультимедиа (MCI) Windows.
        //command- команда, отправляемую в MCI. Команды могут включать в себя такие действия, как "play", "stop", "pause", "open", и т.д.
        //buffer:параметр, который используется для возврата информации о выполнении команды. В данном случае, он может быть null, если нет необходимости в возвращаемых данных.
        //bufferSize параметр, который указывает размер буфера, переданного в параметре buffer. Обычно указывается длина строки buffer, если он используется.
        //IntPtr hwndCallback: дескриптор окна для обратного вызова. Он может использоваться для асинхронного выполнения команд, но в большинстве случаев его можно
        //оставить IntPtr.Zero (что означает отсутствие обратного вызова).

        private void CreateMciSendString(string command)
        {
            mciSendString(command, error, error.Length, IntPtr.Zero);
        }



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

            playListTime--; // Уменьшаем TimeSpan на 1 секунду
            plListTimeLab.Text = $"Общее время: {ConvertMillisecondsToMinutesSeconds(playListTime)}"; // Обновляем текст метки

        }
        private void Timer_TickTrack(object sender, EventArgs e)
        {
            trackTime--;
            trackLab.Text = $"{trackTitle} : {ConvertMillisecondsToMinutesSeconds(trackTime)}";
        }
        public static string ConvertMillisecondsToMinutesSeconds(int milliseconds)
        {
            // общее количество секунд
            int totalSeconds = milliseconds / 1000;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }
        public int GetDuration(string filePath) //длительность трека
        {

            string command = $"open \"{filePath}\" alias mp3file";
            //$"open \"{filePath}\" type mpegaudio alias mp3file";
            CreateMciSendString(command);

            // Запрашиваем длительность в миллисекундах
            //string durationBuffer = new string(' ', 128);
            string durationBuffer = new string(' ', 128);
            //mciSendString("status mp3file length", durationBuffer, durationBuffer.Length, IntPtr.Zero);
            mciSendString("status mp3file length", durationBuffer, durationBuffer.Length, IntPtr.Zero);
            // Закрываем файл
            CreateMciSendString("close mp3file");

            // Преобразуем длительность из строки в целое число
            if (int.TryParse(durationBuffer.Trim(), out int duration))
            {
                return duration; // Длительность в миллисекундах
            }
            return 0; // в случае ошибки
        }

        private void addMusicBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, addMusicBut);

        private void closeBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeBut);
        private void pauseBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.pause, pauseBut);
        private void playBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.play, playBut);
        private void rewindBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.rewind, rewindBut);


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

            cancellationTokenSource.Cancel();
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
                        playListTime += GetDuration(file);
                    }

                    plListTimeLab.Text = $"Общее время: {ConvertMillisecondsToMinutesSeconds(playListTime)}";
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
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;
                isPlaying = true;
                //заблокировать кнопку


                PlayNextTrack(token); //Task.Run создает задачу, которая выполняется асинхронно
                fullTimer.Start();
                trackTimer.Start();
            }
            else if (isPaused) //если были на паузе
            {
                //заблокировать кнопку
                CreateMciSendString("resume mp3file"); //команда на возобновление трека
                isPaused = false;
                isPlaying = true;
                fullTimer.Start();
                trackTimer.Start();
            }
        }


        private void PlayNextTrack(CancellationToken token)
        {

            if (musicFiles.Count > 0 && isPlaying)
            {
                string file = musicFiles.Dequeue();
                trackTitle = Path.GetFileName(file);
                trackTime = GetDuration(file);
                SetPlayListLabel(musicFiles);
                trackLab.Text = $"{trackTitle} : {ConvertMillisecondsToMinutesSeconds(trackTime)}";


                
                Task.Run(() => PlayInThread(token, file), token);



            }
        }

       
        private void PlayInThread(CancellationToken token, string file)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }
            
                CreateMciSendString("close mp3");
                string command = $"open \"{file}\" alias mp3";
                CreateMciSendString(command);
            
            CreateMciSendString("play mp3");
            while (!token.IsCancellationRequested)
            {
                System.Threading.Thread.Sleep(1000);
            }

                CreateMciSendString("close mp3");

            /*
            catch (OperationCanceledException)
            {
                OnPlaybackStopped();
                return;
            }
            OnPlaybackStopped();
    }


    private void pauseBut_Click(object sender, EventArgs e)
    { //заблокировать клавишшу
        if (isPlaying)
        {
            CreateMciSendString("pause mp3file");
            fullTimer.Stop();
            trackTimer.Stop();
            isPaused = true;
            isPlaying = false;
        }
    }


    private void OnPlaybackStopped() //реакция на окончание трека
    {
        cancellationTokenSource.Cancel();

        if (musicFiles.Count != 0) //если в очереди еще остались треки-запускаем следующий
        {
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            PlayNextTrack(token);
        }
        else
        {
            cancellationTokenSource.Cancel();
            isPlaying = false;
            fullTimer.Stop();
            trackTimer.Stop();
            plListTimeLab.Text = ""; //обнуление меток с таймерами
            trackLab.Text = "";
        }

    }

    //----------------------
    private void rewindBut_Click(object sender, EventArgs e)
    {
        if (isPaused)
        {

        }
        else if (isPlaying)
        {
            OnPlaybackStopped();
        }
    }
}
}

*/

