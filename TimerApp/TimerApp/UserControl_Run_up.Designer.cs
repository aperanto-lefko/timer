namespace TimerApp
{
    partial class UserControl_Run_up
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lab_run_up = new Label();
            timeBox1 = new TextBox();
            butMinus = new Button();
            butPlus1 = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AntiqueWhite;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(butMinus, 1, 0);
            tableLayoutPanel1.Controls.Add(butPlus1, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(350, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lab_run_up);
            panel1.Controls.Add(timeBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(177, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 64);
            panel1.TabIndex = 0;
            // 
            // lab_run_up
            // 
            lab_run_up.BackColor = Color.AntiqueWhite;
            lab_run_up.Dock = DockStyle.Fill;
            lab_run_up.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lab_run_up.Location = new Point(0, 0);
            lab_run_up.Name = "lab_run_up";
            lab_run_up.Size = new Size(81, 34);
            lab_run_up.TabIndex = 1;
            lab_run_up.Text = "Подготовка мин";
            lab_run_up.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeBox1
            // 
            timeBox1.Dock = DockStyle.Bottom;
            timeBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timeBox1.Location = new Point(0, 34);
            timeBox1.Name = "timeBox1";
            timeBox1.Size = new Size(81, 30);
            timeBox1.TabIndex = 0;
            // 
            // butMinus
            // 
            butMinus.BackColor = Color.AntiqueWhite;
            butMinus.Dock = DockStyle.Fill;
            butMinus.Location = new Point(90, 3);
            butMinus.Name = "butMinus";
            butMinus.Size = new Size(81, 64);
            butMinus.TabIndex = 1;
            butMinus.UseVisualStyleBackColor = false;
            butMinus.Click += butMinus_Click;
            butMinus.Paint += butMinus_Paint;
            // 
            // butPlus1
            // 
            butPlus1.BackColor = Color.AntiqueWhite;
            butPlus1.Dock = DockStyle.Fill;
            butPlus1.Location = new Point(264, 3);
            butPlus1.Name = "butPlus1";
            butPlus1.Size = new Size(83, 64);
            butPlus1.TabIndex = 2;
            butPlus1.UseVisualStyleBackColor = false;
            butPlus1.Click += butPlus1_Click;
            butPlus1.Paint += butPlus1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 64);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // UserControl_Run_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserControl_Run_up";
            Size = new Size(350, 70);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lab_run_up;
        private TextBox timeBox1;
        private Button butMinus;
        private Button butPlus1;
        private PictureBox pictureBox1;
    }
}
