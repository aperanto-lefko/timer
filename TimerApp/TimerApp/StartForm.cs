using System.Collections;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
namespace TimerApp
{
    public partial class TimerStartForm : BaseForm
    {
        AddTraineeForm addTraineeForm;
        RadioForm radioForm;
        private System.Windows.Forms.Timer timer;  //������ �� ������� �� ������
        private System.Windows.Forms.Timer fullTimer;  //������ �� ������ �����
        Trainee trainee;
        private int timeStage;
        private string titleStage;
        private int sumSeconds;
        private Queue<int> timeStages; //������ ���� ��������� ��������
        private Queue<String> titleStages; //������ �������� ��������� ��������
        private int index = 0;


        public TimerStartForm()
        {
            InitializeComponent();

            butPause.Visible = false;
            butPlay.Visible = false;
            tableLayoutPanel3.Visible = false;
            radioBut.Visible = false;
            musicBut.Visible = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // �������� 1 �������
            timer.Tick += Timer_Tick;
            fullTimer = new System.Windows.Forms.Timer();
            fullTimer.Interval = 1000; // �������� 1 �������
            fullTimer.Tick += Timer_TickFull;

        }
        private void Timer_TickFull(object sender, EventArgs e)
        {
            if (sumSeconds > 0)
            {
                sumSeconds--;
                SetFontValueForFullTimer(new Font("Comic Sans MS", 40, FontStyle.Bold), sumSeconds);
            }
        }

        private void SetFontValueForTitleTimer(string title, int sec)
        {
            labelTitleTimer.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            labelTitleTimer.Text = $"{title}:{sec:D2}"; // ��������������: name:SS
            CenterLabelTitleTimer();
        }

        private void Timer_Tick(object sender, EventArgs e) //������� ������ �������
        {
            if (timeStage > 0)
            {
                timeStage--;
                if (timeStage >= 1000 && timeStage < 10000) //��� 4-� ������� �������� �������
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 100, FontStyle.Bold), timeStage);
                }
                else
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 150, FontStyle.Bold), timeStage);

                }
            }
            else
            {
                if (timeStages.Count > 0)
                {
                    timeStage = timeStages.Dequeue();
                    labelTimer.Text = timeStage.ToString(); // ��������� ����� �����
                    CenterLabelTimer();
                    //������ �������� ��� �������� �������� �����
                    titleStage = titleStages.Dequeue();
                    int titleStageTime = timeStage;
                    SetFontValueForTitleTimer(titleStage, titleStageTime);
                }

                else
                {
                    timer.Stop();

                }
            }
        }

        private void butAddTrainee_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.add_time, butAddTrainee);
        private void butPause_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.pause, butPause);
        private void butPlay_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.play, butPlay);
        private void radioBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.radio, radioBut);
        private void musicBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.music, musicBut);
        private void fixTraineeBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.menu, fixTraineeBut);



        private void butAddTrainee_Click(object sender, EventArgs e)
        {
            addTraineeForm = new AddTraineeForm();
            AddTrainee();
        }
        private void AddTrainee()
        {
            if (addTraineeForm.ShowDialog() == DialogResult.OK)
            {// �������, ���� ����� 2 ���������

                butPause.Visible = true;
                butPlay.Visible = true;
                radioBut.Visible = true;
                musicBut.Visible = true;
                butAddTrainee.Visible = false;
                pictureBox1.Visible = false;
                titelLabel.Visible = false;
                tableLayoutPanel3.Visible = true;
                tableLayoutPanel2.Visible = false;

                trainee = addTraineeForm.Trainee;

                sumSeconds = addTraineeForm.SumSeconds;
                traineeInfoLabel.Text = trainee.ToString(); //������� �������� ����������

                if (!string.IsNullOrEmpty(trainee.Title))
                {
                    titleTraineeLabel.Text = trainee.Title.ToString(); //������������� �������� ����������
                }
                titleTraineeLabel.Location = new Point(((this.Width - titleTraineeLabel.Width) / 2), (this.Height - titleTraineeLabel.Height) / 2 - 250);

                timeStages = new Queue<int>(); //������� ������������������� ��� �������
                titleStages = new Queue<string>(); //������� ������������������� �������� ������

                if (trainee.RunUpTime != 0)
                {
                    timeStages.Enqueue(trainee.RunUpTime);
                    titleStages.Enqueue("����������");
                }
                for (int i = 0; i < trainee.Cycles; i++)
                {
                    if (trainee.WorkTime != 0)
                    {
                        timeStages.Enqueue(trainee.WorkTime);
                        titleStages.Enqueue("������");
                    }
                    if (trainee.RelaxTime != 0)
                    {
                        timeStages.Enqueue(trainee.RelaxTime);
                        titleStages.Enqueue("�����");
                    }
                }
                if (trainee.RestTime != 0)
                {
                    timeStages.Enqueue(trainee.RestTime);
                    titleStages.Enqueue("������������");
                }
                if (timeStages.Count > 0)
                {
                    timeStage = timeStages.Dequeue();
                    titleStage = titleStages.Dequeue();

                }
                //��������� ���������� �������� ��� ������� ������
                if (timeStage >= 1000 && timeStage < 10000)
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 100, FontStyle.Bold), timeStage);
                }
                else
                {
                    SetFontValueForTimer(new Font("Comic Sans MS", 150, FontStyle.Bold), timeStage);
                }
                //��������� ���������� �������� ��� ������� �������
                SetFontValueForFullTimer(new Font("Comic Sans MS", 40, FontStyle.Bold), sumSeconds);
            }
            //��������� ���������� �������� ��� ������� � ���������

            if (titleStage != null)
            {
                SetFontValueForTitleTimer(titleStage, timeStage);
            }
        }


        private void butPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            fullTimer.Stop();


        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
            fullTimer.Start();

        }
        private void SetFontValueForTimer(Font font, int sec)
        {
            labelTimer.Font = font;
            labelTimer.Text = sec.ToString(); // ��������� ����� �����
            CenterLabelTimer();
        }
        private void SetFontValueForFullTimer(Font font, int totalSeconds)
        {
            labelFullTimer.Font = font;
            int min = totalSeconds / 60;
            int sec = totalSeconds % 60;
            labelFullTimer.Text = $"{min:D2}:{sec:D2}"; // ��������������: MM:SS
            CenterLabelFullTimer();
        }
        private void CenterLabelTimer() //��������� ����� ������� �� �������
        {
            labelTimer.Location = new Point(this.Width / 2 - labelTimer.Width / 2, (this.Height / 2 - labelTimer.Height / 2) - 10);
        }
        private void CenterLabelFullTimer()
        {
            labelFullTimer.Location = new Point(this.Width / 2 - labelFullTimer.Width / 2, (this.Height / 2 - labelFullTimer.Height / 2 - 200));
        }
        private void CenterLabelTitleTimer()
        {
            labelTitleTimer.Location = new Point(this.Width / 2 - labelTitleTimer.Width / 2, (this.Height / 2 - labelFullTimer.Height / 2 - 100));
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

        private void fixTraineeBut_Click(object sender, EventArgs e)
        {
            if (addTraineeForm == null || addTraineeForm.IsDisposed)
            {
                addTraineeForm = new AddTraineeForm();
            }

            AddTrainee();

        }

        private void radioBut_Click(object sender, EventArgs e)
        {
            if (radioForm == null || radioForm.IsDisposed)
            {
                radioForm = new RadioForm();
            }
            radioForm.Show();
        }

        private void musicBut_Click(object sender, EventArgs e)
        {
            MusicForm musicForm = new MusicForm();
            musicForm.Show();
        }
    }
}
