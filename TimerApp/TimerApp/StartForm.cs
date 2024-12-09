using System.Collections;
using System.Drawing.Text;
using System.Windows.Forms;
namespace TimerApp
{
    public partial class TimerStartForm : Form
    {
        private System.Windows.Forms.Timer timer;  //таймер на секунды по этапам
        private System.Windows.Forms.Timer fullTimer;  //таймер на полное время
        private int seconds;
        private int minutes;
        private Queue<int> timeStages;
        private int index = 0;

        public TimerStartForm()
        {
            InitializeComponent();
            butPause.Visible = false;
            butPlay.Visible = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Интервал 1 секунда
            timer.Tick += Timer_Tick;
            fullTimer = new System.Windows.Forms.Timer();
            fullTimer.Interval = 1000; // Интервал 1 секунда
            fullTimer.Tick += Timer_TickFull;
            

        }
        private void Timer_TickFull(object sender, EventArgs e)
        {
            if (minutes > 0)
            {
                minutes--;
                SetFontValueForFullTimer(new Font("Comic Sans MS", 40, FontStyle.Bold), minutes);
            }
        }



        private void Timer_Tick(object sender, EventArgs e) //задание работы таймера
        {
            if (seconds > 0)
            {
                seconds--;
                if (seconds >= 1000 && seconds < 10000) //для 4-х значных значений таймера
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 100, FontStyle.Bold), seconds);
                }
                else
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 150, FontStyle.Bold), seconds);

                }
            }
            else
            {
                if (timeStages.Count > 0)
                {
                    seconds = timeStages.Dequeue();
                    labelTimer.Text = seconds.ToString(); // Обновляем текст метки
                    CenterLabelTimer();
                }

                else
                {
                    timer.Stop();

                }
            }
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

        private void butAddTrainee_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.add_time, butAddTrainee);
        private void butPause_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.pause, butPause);
        private void butPlay_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.play, butPlay);


        private void butAddTrainee_Click(object sender, EventArgs e)
        {
            AddTraineeForm addTraineeForm = new AddTraineeForm();
            if (addTraineeForm.ShowDialog() == DialogResult.OK)
            {// Ожидаем, пока форма 2 закроется

                butPause.Visible = true;
                butPlay.Visible = true;
                butAddTrainee.Visible = false;
                pictureBox1.Visible = false;

                Trainee trainee = addTraineeForm.Trainee;

                minutes = addTraineeForm.SumSeconds;

                if (!string.IsNullOrEmpty(trainee.Title))
                {
                    titleTraineeLabel.Text = trainee.Title.ToString();
                }
                titleTraineeLabel.Location = new Point(((this.Width - titleTraineeLabel.Width) / 2), (this.Height - titleTraineeLabel.Height) / 2 - 250);
                timeStages = new Queue<int>(); //очередь последовательностей для таймера

                if (trainee.RunUpTime != 0)
                {
                    timeStages.Enqueue(trainee.RunUpTime);
                }
                for (int i = 0; i < trainee.Cycles; i++)
                {
                    if (trainee.WorkTime != 0)
                    {
                        timeStages.Enqueue(trainee.WorkTime);
                    }
                    if (trainee.RelaxTime != 0)
                    {
                        timeStages.Enqueue(trainee.RelaxTime);
                    }
                }
                if (trainee.RestTime != 0)
                {
                    timeStages.Enqueue(trainee.RestTime);
                }
                if (timeStages.Count > 0)
                {
                    seconds = timeStages.Dequeue();

                }
                //установка начального значения для таймера этапов
                if (seconds >= 1000 && seconds < 10000)
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 100, FontStyle.Bold), seconds);
                }
                else
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 150, FontStyle.Bold), seconds);
                }
                //установка начального значения для таймера полного
                SetFontValueForFullTimer(new Font("Comic Sans MS", 40, FontStyle.Bold), minutes);
            }
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            fullTimer.Stop();
            butAddTrainee.Visible = true;
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
            fullTimer.Start();
        }
        private void SetFontValueForTimer(Font font, int sec)
        {
            labelTimer.Font = font;
            labelTimer.Text = sec.ToString(); // Обновляем текст метки
            CenterLabelTimer();
        }
        private void SetFontValueForFullTimer(Font font, int totalSeconds)
        {
            labelFullTimer.Font = font;
            int min = totalSeconds / 60;
            int sec = totalSeconds % 60;
            labelFullTimer.Text = $"{min:D2}:{sec:D2}"; // Форматирование: MM:SS
            CenterLabelFullTimer();
        }
        private void CenterLabelTimer() //установка места таймера на секунды
        {
            labelTimer.Location = new Point(this.Width / 2 - labelTimer.Width / 2, (this.Height / 2 - labelTimer.Height / 2) - 30);
        }
        private void CenterLabelFullTimer()
        {
            labelFullTimer.Location = new Point(this.Width / 2 - labelFullTimer.Width / 2, (this.Height / 2 - labelFullTimer.Height / 2 - 200));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(Properties.Resources.timerApp))
            {
                using (Image image = Image.FromStream(ms))
                {
                    e.Graphics.DrawImage(image, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
            }
        }

        
    }
}
