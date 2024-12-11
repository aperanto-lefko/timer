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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            butPause = new Button();
            butPlay = new Button();
            radioBut = new Button();
            musicBut = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            butAddTrainee = new Button();
            labelTimer = new Label();
            labelFullTimer = new Label();
            pictureBox1 = new PictureBox();
            titleTraineeLabel = new Label();
            toolTip1 = new ToolTip(components);
            fixTraineeBut = new Button();
            titelLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            traineeInfoLabel = new Label();
            labelTitleTimer = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(radioBut, 2, 0);
            tableLayoutPanel1.Controls.Add(musicBut, 1, 0);
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
            butPause.TabIndex = 1;
            toolTip1.SetToolTip(butPause, "Остановить тренировку");
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
            butPlay.TabIndex = 4;
            toolTip1.SetToolTip(butPlay, "Запустить тренировку");
            butPlay.UseVisualStyleBackColor = false;
            butPlay.Click += butPlay_Click;
            butPlay.Paint += butPlay_Paint;
            // 
            // radioBut
            // 
            radioBut.BackColor = Color.AntiqueWhite;
            radioBut.Dock = DockStyle.Fill;
            radioBut.Location = new Point(195, 3);
            radioBut.Name = "radioBut";
            radioBut.Size = new Size(90, 70);
            radioBut.TabIndex = 3;
            toolTip1.SetToolTip(radioBut, "Выбрать радио");
            radioBut.UseVisualStyleBackColor = false;
            radioBut.Click += radioBut_Click;
            radioBut.Paint += radioBut_Paint;
            // 
            // musicBut
            // 
            musicBut.BackColor = Color.AntiqueWhite;
            musicBut.Dock = DockStyle.Fill;
            musicBut.Location = new Point(99, 3);
            musicBut.Name = "musicBut";
            musicBut.Size = new Size(90, 70);
            musicBut.TabIndex = 5;
            musicBut.UseVisualStyleBackColor = false;
            musicBut.Click += musicBut_Click;
            musicBut.Paint += musicBut_Paint;
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
            toolTip1.SetToolTip(butAddTrainee, "Добавить новую тренировку");
            butAddTrainee.UseVisualStyleBackColor = false;
            butAddTrainee.Click += butAddTrainee_Click;
            butAddTrainee.Paint += butAddTrainee_Paint;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(194, 247);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 15);
            labelTimer.TabIndex = 2;
            // 
            // labelFullTimer
            // 
            labelFullTimer.AutoSize = true;
            labelFullTimer.Location = new Point(194, 123);
            labelFullTimer.Name = "labelFullTimer";
            labelFullTimer.Size = new Size(0, 15);
            labelFullTimer.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 288);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // titleTraineeLabel
            // 
            titleTraineeLabel.Anchor = AnchorStyles.None;
            titleTraineeLabel.AutoSize = true;
            titleTraineeLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleTraineeLabel.Location = new Point(112, 90);
            titleTraineeLabel.Name = "titleTraineeLabel";
            titleTraineeLabel.Size = new Size(0, 38);
            titleTraineeLabel.TabIndex = 6;
            titleTraineeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fixTraineeBut
            // 
            fixTraineeBut.Anchor = AnchorStyles.Top;
            fixTraineeBut.BackColor = Color.AntiqueWhite;
            fixTraineeBut.Location = new Point(326, 3);
            fixTraineeBut.Name = "fixTraineeBut";
            fixTraineeBut.Size = new Size(31, 34);
            fixTraineeBut.TabIndex = 5;
            toolTip1.SetToolTip(fixTraineeBut, "Изменить время тренировки");
            fixTraineeBut.UseVisualStyleBackColor = false;
            fixTraineeBut.Click += fixTraineeBut_Click;
            fixTraineeBut.Paint += fixTraineeBut_Paint;
            // 
            // titelLabel
            // 
            titelLabel.AutoSize = true;
            titelLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titelLabel.Location = new Point(118, 97);
            titelLabel.Name = "titelLabel";
            titelLabel.Size = new Size(154, 30);
            titelLabel.TabIndex = 7;
            titelLabel.Text = "workout timer";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.Controls.Add(traineeInfoLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(fixTraineeBut, 2, 0);
            tableLayoutPanel3.Location = new Point(12, 478);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(360, 160);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // traineeInfoLabel
            // 
            traineeInfoLabel.AutoSize = true;
            traineeInfoLabel.Dock = DockStyle.Fill;
            traineeInfoLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            traineeInfoLabel.Location = new Point(40, 0);
            traineeInfoLabel.Name = "traineeInfoLabel";
            traineeInfoLabel.Size = new Size(280, 160);
            traineeInfoLabel.TabIndex = 0;
            traineeInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleTimer
            // 
            labelTitleTimer.AutoSize = true;
            labelTitleTimer.Location = new Point(184, 88);
            labelTitleTimer.Name = "labelTitleTimer";
            labelTitleTimer.Size = new Size(0, 15);
            labelTitleTimer.TabIndex = 9;
            // 
            // TimerStartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(384, 661);
            Controls.Add(labelTitleTimer);
            Controls.Add(titelLabel);
            Controls.Add(titleTraineeLabel);
            Controls.Add(labelFullTimer);
            Controls.Add(labelTimer);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel3);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Location = new Point(400, 400);
            Name = "TimerStartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimerApp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button butAddTrainee;
        private Label labelTimer;
        private Button butPause;
        private Button butPlay;
        private Label labelFullTimer;
        private PictureBox pictureBox1;
        private Label titleTraineeLabel;
        private ToolTip toolTip1;
        private Label titelLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label traineeInfoLabel;
        private Button fixTraineeBut;
        private Label labelTitleTimer;
        private Button radioBut;
        private Button musicBut;
    }
}
