namespace TimerApp
{
    partial class TimerStartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            butPause = new Button();
            butPlay = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            butAddTrainee = new Button();
            labelTimer = new Label();
            panel1 = new Panel();
            greeting_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(butPause, 0, 0);
            tableLayoutPanel1.Controls.Add(butPlay, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // butPause
            // 
            butPause.BackColor = Color.AntiqueWhite;
            butPause.Dock = DockStyle.Fill;
            butPause.Location = new Point(3, 3);
            butPause.Name = "butPause";
            butPause.Size = new Size(90, 70);
            butPause.TabIndex = 0;
            butPause.UseVisualStyleBackColor = false;
            butPause.Click += butPause_Click;
            butPause.Paint += butPause_Paint;
            // 
            // butPlay
            // 
            butPlay.BackColor = Color.AntiqueWhite;
            butPlay.Dock = DockStyle.Fill;
            butPlay.Location = new Point(291, 3);
            butPlay.Name = "butPlay";
            butPlay.Size = new Size(90, 70);
            butPlay.TabIndex = 1;
            butPlay.UseVisualStyleBackColor = false;
            butPlay.Click += butPlay_Click;
            butPlay.Paint += butPlay_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(butAddTrainee, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 581);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(384, 80);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // butAddTrainee
            // 
            butAddTrainee.BackColor = Color.AntiqueWhite;
            butAddTrainee.Dock = DockStyle.Fill;
            butAddTrainee.Location = new Point(291, 3);
            butAddTrainee.Name = "butAddTrainee";
            butAddTrainee.Size = new Size(90, 74);
            butAddTrainee.TabIndex = 0;
            butAddTrainee.UseVisualStyleBackColor = false;
            butAddTrainee.Click += butAddTrainee_Click;
            butAddTrainee.Paint += butAddTrainee_Paint;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(183, 185);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 15);
            labelTimer.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(greeting_label);
            panel1.Location = new Point(0, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 100);
            panel1.TabIndex = 3;
            // 
            // greeting_label
            // 
            greeting_label.Dock = DockStyle.Fill;
            greeting_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            greeting_label.Location = new Point(0, 0);
            greeting_label.Name = "greeting_label";
            greeting_label.Size = new Size(384, 100);
            greeting_label.TabIndex = 0;
            greeting_label.Text = "Приложение \"Таймер\" для занятия спортом. Чтобы добавить тренировку нажмите значок с часами";
            greeting_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimerStartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(384, 661);
            Controls.Add(panel1);
            Controls.Add(labelTimer);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ControlText;
            Location = new Point(400, 400);
            Name = "TimerStartForm";
            Text = "TimerApp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button butAddTrainee;
        private Label labelTimer;
        private Panel panel1;
        private Label greeting_label;
        private Button butPause;
        private Button butPlay;
    }
}
