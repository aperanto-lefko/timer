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
    public partial class AddTraineeForm : Form
    {
        public string SumSeconds { get; private set; }
        public AddTraineeForm()
        {
            InitializeComponent();
            timeRun_up_box.Text = "0";
            SumSeconds = "0";
            timeRun_up_box.TextAlign = HorizontalAlignment.Center;
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timeRun_up_box.Text, out int currentValue))
            {
                currentValue++; // Увеличиваем значение

                timeRun_up_box.Text = currentValue.ToString(); // Обновляем текстовое поле
               
            }
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timeRun_up_box.Text, out int currentValue))
            {
                currentValue--; // Увеличиваем значение
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                timeRun_up_box.Text = currentValue.ToString(); // Обновляем текстовое поле
                
            }
        }

        private void butMinus_Paint(object sender, PaintEventArgs e)
        {
            Image minus = Image.FromFile("Resources\\minus.png");
            e.Graphics.DrawImage(minus, 0, 0, butMinus.Width, butMinus.Height);
        }

        private void butPlus_Paint(object sender, PaintEventArgs e)
        {
            Image minus = Image.FromFile("Resources\\plus.png");
            e.Graphics.DrawImage(minus, 0, 0, butMinus.Width, butMinus.Height);
        }

        private void timeRun_up_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //IsControl является ли символ управляющим (например, клавиши Backspace,
                                                                        //Enter и другие специальные клавиши
                                                                        //IsDigit является ли символ цифрой

            {
                e.Handled = true; // Отменяем ввод
                timeRun_up_box.Text = "0";
               
            }
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            SumSeconds = timeRun_up_box.Text; // Устанавливаем значение перед закрытием формы
            this.DialogResult = DialogResult.OK; //устанавливаем результат диалога
            this.Close();
        }
    }
}
