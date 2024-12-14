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
    public partial class AddTraineeForm : BaseForm
    {
        public int SumSeconds { get; private set; }
        public Trainee Trainee { get; private set; }
        public AddTraineeForm()
        {
            InitializeComponent();


            timeRun_up_box.Text = "0";
            work_box.Text = "0";
            relaxBox.Text = "0";
            restBox.Text = "0";
            cycleBox.Text = "1";

            SumSeconds = 0;

            TextAlignCenter(timeRun_up_box);
            TextAlignCenter(work_box);
            TextAlignCenter(relaxBox);
            TextAlignCenter(restBox);
            TextAlignCenter(cycleBox);

            work_label.Text = "Работа\nмин";
            relax_label.Text = "Отдых\nмин";
            rest_label.Text = "Заминка\nмин";
            cycle_label.Text = "Циклы";

        }

        private void TextAlignCenter(TextBox box)
        {
            box.TextAlign = HorizontalAlignment.Center;
        }


        private void ClickPlus(TextBox box)
        {
            if (int.TryParse(box.Text, out int currentValue))
            {
                currentValue++; // Увеличиваем значение
                box.Text = currentValue.ToString(); // Обновляем текстовое поле
            }
        }
        private void butPlusRunUp_Click(object sender, EventArgs e) => ClickPlus(timeRun_up_box);
        private void butPlusWork_Click(object sender, EventArgs e) => ClickPlus(work_box);
        private void butPlusRelax_Click(object sender, EventArgs e) => ClickPlus(relaxBox);
        private void butPlusRest_Click(object sender, EventArgs e) => ClickPlus(restBox);
        private void butPlusCycle_Click(object sender, EventArgs e) => ClickPlus(cycleBox);


        private void ClickMinus(TextBox box)
        {
            if (int.TryParse(box.Text, out int currentValue))
            {
                currentValue--; // Увеличиваем значение
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                box.Text = currentValue.ToString(); // Обновляем текстовое поле

            }
        }
        private void ClickMinusCycle(TextBox box)
        {
            if (int.TryParse(box.Text, out int currentValue))
            {
                currentValue--; // Увеличиваем значение
                if (currentValue < 1)
                {
                    currentValue = 1;
                }
                box.Text = currentValue.ToString(); // Обновляем текстовое поле

            }
        }

        private void butMinusRunUp_Click(object sender, EventArgs e) => ClickMinus(timeRun_up_box);
        private void butMinusWork_Click(object sender, EventArgs e) => ClickMinus(work_box);
        private void butMinusRelax_Click(object sender, EventArgs e) => ClickMinus(relaxBox);
        private void butMinusRest_Click(object sender, EventArgs e) => ClickMinus(restBox);
        private void butMinusCycle_Click(object sender, EventArgs e) => ClickMinusCycle(cycleBox);



        private void KeyPressForBox(KeyPressEventArgs e, TextBox box) //проверка на ввод только цифр
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //IsControl является ли символ управляющим (например, клавиши Backspace,Enter и другие специальные клавиши IsDigit является ли символ цифрой
            {
                e.Handled = true; // Отменяем ввод
                box.Text = "0";
            }
        }
        private void timeRun_up_box_KeyPress(object sender, KeyPressEventArgs e) => KeyPressForBox(e, timeRun_up_box);
        private void work_box_KeyPress(object sender, KeyPressEventArgs e) => KeyPressForBox(e, work_box);
        private void relaxBox_KeyPress(object sender, KeyPressEventArgs e) => KeyPressForBox(e, relaxBox);




        private void butMinusRunUp_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.minus, butMinusRunUp);
        private void butPlusRunUp_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, butPlusRunUp);
        private void butMinusWork_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.minus, butMinusWork);
        private void butPlusWork_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, butPlusWork);
        private void butMinusRelax_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.minus, butMinusRelax);
        private void butPlusRelax_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, butPlusRelax);
        private void butMinusRest_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.minus, butMinusRest);
        private void butPlusRest_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, butPlusRest);
        private void butMinusCycle_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.minus, butMinusCycle);
        private void butPlusCycle_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.plus, butPlusCycle);
        private void butConfirm_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.confirm, butConfirm);
        private void closeBut_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, Properties.Resources.close, closeBut);


        private void pictureBox1_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.men, pictureBox1);
        private void pictureBox2_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.pen, pictureBox2);
        private void pictureBox3_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.barbell, pictureBox3);
        private void pictureBox4_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.relax, pictureBox4);
        private void pictureBox5_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.sofa, pictureBox5);
        private void pictureBox6_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, Properties.Resources.cycle, pictureBox6);


        private void butConfirm_Click(object sender, EventArgs e)
        {
            string title = title_box.Text;
            int cycle = int.Parse(cycleBox.Text);
            int runUpTime = int.Parse(timeRun_up_box.Text) * 60;
            int workTime = int.Parse(work_box.Text) * 60;
            int relaxTime = int.Parse(relaxBox.Text) * 60;
            int restTime = int.Parse(restBox.Text) * 60;
            Trainee = new Trainee(title, cycle, runUpTime, workTime, relaxTime, restTime);
            SumSeconds = runUpTime + (workTime + relaxTime) * cycle + restTime; // Устанавливаем значение в секундах перед закрытием формы
            this.DialogResult = DialogResult.OK; //устанавливаем результат диалога
            this.Close();
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //устанавливаем результат диалога
            this.Close();
        }
        private void SelectAllInBox(EventArgs e, Control box)
        {
            if (box is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }

        private void timeRun_up_box_Click(object sender, EventArgs e) => SelectAllInBox(e, timeRun_up_box);
        private void work_box_Click(object sender, EventArgs e) => SelectAllInBox(e, work_box);
        private void relaxBox_Click(object sender, EventArgs e) => SelectAllInBox(e, relaxBox);
        private void restBox_Click(object sender, EventArgs e) => SelectAllInBox(e, restBox);
        private void cycleBox_Click(object sender, EventArgs e) => SelectAllInBox(e, cycleBox);

    }

}


