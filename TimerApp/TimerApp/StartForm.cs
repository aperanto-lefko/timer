using System.Windows.Forms;
namespace TimerApp
{
    public partial class TimerStartForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private int seconds;
        public TimerStartForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Интервал 1 секунда
            timer.Tick += Timer_Tick;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                labelTimer.Text = seconds.ToString(); // Обновляем текст метки
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Время вышло!");
            }
        }

        private void butAddTrainee_Paint(object sender, PaintEventArgs e)
        {
            Image addTime = Image.FromFile("Resources\\add_time.png");
            e.Graphics.DrawImage(addTime, 0, 0, butAddTrainee.Width, butAddTrainee.Height);
        }

        private void butAddTrainee_Click(object sender, EventArgs e)
        {
            AddTraineeForm addTraineeForm = new AddTraineeForm();
            if (addTraineeForm.ShowDialog() == DialogResult.OK) {// Ожидаем, пока форма 2 закроется
                if (int.TryParse(addTraineeForm.SumSeconds, out seconds) && seconds > 0)
                {
                    labelTimer.Text = seconds.ToString(); //устанавливаем начальное значение таймера
                    timer.Start();
                }
        }
        }
    }
}
