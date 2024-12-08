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
            work_box.Text = "0";
            relaxBox.Text = "0";

            SumSeconds = "0";

            TextAlignCenter(timeRun_up_box);
            TextAlignCenter(work_box);
            TextAlignCenter(relaxBox);

            work_label.Text = "Работа\nмин";
            relax_label.Text = "Отдых\nмин";
            rest_label.Text = "Заминка\nмин";

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

        private void butMinusRunUp_Click(object sender, EventArgs e) => ClickMinus(timeRun_up_box);
        private void butMinusWork_Click(object sender, EventArgs e) => ClickMinus(work_box);
        private void butMinusRelax_Click(object sender, EventArgs e) => ClickMinus(relaxBox);
        private void butMinusRest_Click(object sender, EventArgs e) => ClickMinus(restBox);



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



        private void DrawButtonImage(PaintEventArgs e, string imagePath, Control button) //назначение картинок для кнопок
        {
            using (Image image = Image.FromFile(imagePath))
            {
                e.Graphics.DrawImage(image, 0, 0, button.Width, button.Height);
            }
        }


        private void butMinusRunUp_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\minus.png", butMinusRunUp);
        private void butPlusRunUp_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\plus.png", butPlusRunUp);
        private void butMinusWork_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\minus.png", butMinusWork);
        private void butPlusWork_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\plus.png", butPlusWork);
        private void butMinusRelax_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\minus.png", butMinusRelax);
        private void butPlusRelax_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\plus.png", butPlusRelax);
        private void butConfirm_Paint(object sender, PaintEventArgs e) => DrawButtonImage(e, "Resources\\confirm.png", butConfirm);



        private void DrawPictureBoxImage(PaintEventArgs e, string imagePath, PictureBox pictureBox) //назначение картинок для полей
        {
            using (Image image = Image.FromFile(imagePath))
            {
                e.Graphics.DrawImage(image, 0, 0, pictureBox.Width, pictureBox.Height);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, "Resources\\men.png", pictureBox1);
        private void pictureBox2_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, "Resources\\T.png", pictureBox2);
        private void pictureBox3_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, "Resources\\barbell.png", pictureBox3);
        private void pictureBox4_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, "Resources\\relax.png", pictureBox4);
        private void pictureBox5_Paint(object sender, PaintEventArgs e) => DrawPictureBoxImage(e, "Resources\\sofa.png", pictureBox5);

        private void butConfirm_Click(object sender, EventArgs e)
        {
            SumSeconds = timeRun_up_box.Text; // Устанавливаем значение перед закрытием формы
            this.DialogResult = DialogResult.OK; //устанавливаем результат диалога
            this.Close();
        }

        

        
       
    }

}



/* удалить в конце
 * private void userControl_Run_up1_Load(object sender, EventArgs e)
 {
удалить позднее
 }
*/
/* private void pictureBox1_Paint(object sender, PaintEventArgs e)
 {
     Image men = Image.FromFile("Resources\\men.png");
     e.Graphics.DrawImage(men, 0, 0, pictureBox1.Width, pictureBox1.Height);
 }

 private void pictureBox2_Paint(object sender, PaintEventArgs e)
 {
     Image t = Image.FromFile("Resources\\T.png");
     e.Graphics.DrawImage(t, 0, 0, pictureBox2.Width, pictureBox2.Height);
 }

 private void pictureBox3_Paint(object sender, PaintEventArgs e)
 {
     Image barbell = Image.FromFile("Resources\\barbell.png");
     e.Graphics.DrawImage(barbell, 0, 0, pictureBox3.Width, pictureBox3.Height);
 }

 private void pictureBox4_Paint(object sender, PaintEventArgs e)
 {
     Image relax = Image.FromFile("Resources\\relax.png");
     e.Graphics.DrawImage(relax, 0, 0, pictureBox4.Width, pictureBox4.Height);
/* private void butMinus_Paint(object sender, PaintEventArgs e) //Подготовка
         {
             Image minus = Image.FromFile("Resources\\minus.png");
             e.Graphics.DrawImage(minus, 0, 0, butMinus.Width, butMinus.Height);
         }

         private void butPlus_Paint(object sender, PaintEventArgs e) //Подготовка
         {
             Image plus = Image.FromFile("Resources\\plus.png");
             e.Graphics.DrawImage(plus, 0, 0, butMinus.Width, butMinus.Height);
         }
         private void butPlus_1_Paint(object sender, PaintEventArgs e) //Работа 
         {
             Image plus = Image.FromFile("Resources\\plus.png");
             e.Graphics.DrawImage(plus, 0, 0, butPlus_1.Width, butPlus_1.Height);
         }

         private void butMinus_1_Paint(object sender, PaintEventArgs e) //Работа 
         {
             Image minus = Image.FromFile("Resources\\minus.png");
             e.Graphics.DrawImage(minus, 0, 0, butMinus_1.Width, butMinus_1.Height);
         }

         private void butMinus_2_Paint(object sender, PaintEventArgs e)
         {
             Image minus = Image.FromFile("Resources\\minus.png");
             e.Graphics.DrawImage(minus, 0, 0, butMinus_2.Width, butMinus_2.Height);
         }
         private void butPlus_2_Paint(object sender, PaintEventArgs e)
         {
             Image plus = Image.FromFile("Resources\\plus.png");
             e.Graphics.DrawImage(plus, 0, 0, butPlus_2.Width, butPlus_2.Height);
         }
         private void butConfirm_Paint(object sender, PaintEventArgs e)
         {
             Image confirm = Image.FromFile("Resources\\confirm.png");
             e.Graphics.DrawImage(confirm, 0, 0, butConfirm.Width, butConfirm.Height);
         }
        */

/* private void timeRun_up_box_KeyPress(object sender, KeyPressEventArgs e)
 {
     if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //IsControl является ли символ управляющим (например, клавиши Backspace,
                                                                 //Enter и другие специальные клавиши
                                                                 //IsDigit является ли символ цифрой

     {
         e.Handled = true; // Отменяем ввод
         timeRun_up_box.Text = "0";

     }
 }*/
/*private void butMinus_Click(object sender, EventArgs e)
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
        }*/
/*private void butPlus_Click(object sender, EventArgs e)
       {
           if (int.TryParse(timeRun_up_box.Text, out int currentValue))
           {
               currentValue++; // Увеличиваем значение

               timeRun_up_box.Text = currentValue.ToString(); // Обновляем текстовое поле

           }
       }*/