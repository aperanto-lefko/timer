using System.Collections;
using System.Drawing.Text;
using System.Windows.Forms;
namespace TimerApp
{
    public partial class TimerStartForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private int seconds;
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


        }
        private void Timer_Tick(object sender, EventArgs e) //задание работы таймера
        {
            if (seconds > 0)
            {
                seconds--;
                labelTimer.Font = new Font("Comic Sans MS", 90, FontStyle.Bold);
                labelTimer.Text = seconds.ToString(); // Обновляем текст метки
                CenterLabelTimer();
            }
            else
            {
                timer.Stop();

            }
        }
        private void CenterLabelTimer() //установка места таймера
        {
            labelTimer.Location = new Point(this.Width / 2 - labelTimer.Width / 2, (this.Height / 2 - labelTimer.Height / 2) - 50);
        }


        private void DrawButtonImage(PaintEventArgs e, string imagePath, Control button) //назначение картинок для кнопок
        {
            using (Image image = Image.FromFile(imagePath))
            {
                e.Graphics.DrawImage(image, 0, 0, button.Width, button.Height);
            }
        }

        private void butAddTrainee_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\add_time.png", butAddTrainee);
        private void butPause_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\pause.png", butPause);
        private void butPlay_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\play.png", butPlay);



        private void butAddTrainee_Click(object sender, EventArgs e)
        {
            AddTraineeForm addTraineeForm = new AddTraineeForm();
            if (addTraineeForm.ShowDialog() == DialogResult.OK)
            {// Ожидаем, пока форма 2 закроется
                greeting_label.Visible = false;
                butPause.Visible = true;
                butPlay.Visible = true;
                butAddTrainee.Visible = false;

                Trainee trainee = addTraineeForm.Trainee;
                timeStages = new Queue<int>();
                timeStages.Enqueue(trainee.RunUpTime);
               
                for(int i = 0; i<trainee.Cycles; i++)
                {
                    timeStages.Enqueue(trainee.WorkTime);
                    timeStages.Enqueue(trainee.RelaxTime);
                }
                timeStages.Enqueue(trainee.RestTime);

                while (timeStages.Count > 0)
                {
                    seconds = timeStages.Dequeue();
                }

                labelTimer.Font = new Font("Comic Sans MS", 90, FontStyle.Bold);
                labelTimer.Text = seconds.ToString();
                CenterLabelTimer();
                //labelTimer.Text = addTraineeForm.SumSeconds.ToString(); //устанавливаем начальное значение таймера
                /*Label traineeLabel = new Label();
                traineeLabel.Location = new Point(30, 30);
                traineeLabel.AutoSize = true;
                traineeLabel.Text = addTraineeForm.Trainee.ToString();
                this.Controls.Add(traineeLabel);*/
                //timer.Start();

            }
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
