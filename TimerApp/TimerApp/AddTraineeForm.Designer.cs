namespace TimerApp
{
    partial class AddTraineeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            timeRun_up_box = new TextBox();
            run_up_label = new Label();
            butMinusRunUp = new Button();
            butPlusRunUp = new Button();
            pictureBox1 = new PictureBox();
            butConfirm = new Button();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            work_box = new TextBox();
            work_label = new Label();
            butMinusWork = new Button();
            butPlusWork = new Button();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            relaxBox = new TextBox();
            relax_label = new Label();
            butMinusRelax = new Button();
            butPlusRelax = new Button();
            pictureBox5 = new PictureBox();
            butMinusRest = new Button();
            butPlusRest = new Button();
            panel5 = new Panel();
            restBox = new TextBox();
            rest_label = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddTraineeLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            TraineeTitleLabel = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(butMinusRunUp, 1, 0);
            tableLayoutPanel1.Controls.Add(butPlusRunUp, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(butConfirm, 3, 5);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 1);
            tableLayoutPanel1.Controls.Add(butMinusWork, 1, 1);
            tableLayoutPanel1.Controls.Add(butPlusWork, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 2, 2);
            tableLayoutPanel1.Controls.Add(butMinusRelax, 1, 2);
            tableLayoutPanel1.Controls.Add(butPlusRelax, 3, 2);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 3);
            tableLayoutPanel1.Controls.Add(butMinusRest, 1, 3);
            tableLayoutPanel1.Controls.Add(butPlusRest, 3, 3);
            tableLayoutPanel1.Controls.Add(panel5, 2, 3);
            tableLayoutPanel1.Location = new Point(0, 138);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(334, 462);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(timeRun_up_box);
            panel1.Controls.Add(run_up_label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(169, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 74);
            panel1.TabIndex = 2;
            // 
            // timeRun_up_box
            // 
            timeRun_up_box.Anchor = AnchorStyles.None;
            timeRun_up_box.BackColor = Color.Linen;
            timeRun_up_box.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timeRun_up_box.Location = new Point(0, 39);
            timeRun_up_box.MaxLength = 7;
            timeRun_up_box.Name = "timeRun_up_box";
            timeRun_up_box.Size = new Size(77, 30);
            timeRun_up_box.TabIndex = 1;
            timeRun_up_box.KeyPress += timeRun_up_box_KeyPress;
            // 
            // run_up_label
            // 
            run_up_label.Dock = DockStyle.Top;
            run_up_label.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            run_up_label.Location = new Point(0, 0);
            run_up_label.Name = "run_up_label";
            run_up_label.Size = new Size(77, 42);
            run_up_label.TabIndex = 0;
            run_up_label.Text = "Подготовка мин";
            run_up_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butMinusRunUp
            // 
            butMinusRunUp.BackColor = Color.AntiqueWhite;
            butMinusRunUp.Dock = DockStyle.Fill;
            butMinusRunUp.ForeColor = SystemColors.ControlText;
            butMinusRunUp.Location = new Point(86, 3);
            butMinusRunUp.Name = "butMinusRunUp";
            butMinusRunUp.Size = new Size(77, 74);
            butMinusRunUp.TabIndex = 3;
            butMinusRunUp.UseVisualStyleBackColor = false;
            butMinusRunUp.Click += butMinusRunUp_Click;
            butMinusRunUp.Paint += butMinusRunUp_Paint;
            // 
            // butPlusRunUp
            // 
            butPlusRunUp.BackColor = Color.AntiqueWhite;
            butPlusRunUp.Dock = DockStyle.Fill;
            butPlusRunUp.Location = new Point(252, 3);
            butPlusRunUp.Name = "butPlusRunUp";
            butPlusRunUp.Size = new Size(79, 74);
            butPlusRunUp.TabIndex = 4;
            butPlusRunUp.UseVisualStyleBackColor = false;
            butPlusRunUp.Click += butPlusRunUp_Click;
            butPlusRunUp.Paint += butPlusRunUp_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 74);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // butConfirm
            // 
            butConfirm.BackColor = Color.AntiqueWhite;
            butConfirm.Dock = DockStyle.Fill;
            butConfirm.Location = new Point(252, 382);
            butConfirm.Name = "butConfirm";
            butConfirm.Size = new Size(79, 77);
            butConfirm.TabIndex = 7;
            butConfirm.UseVisualStyleBackColor = false;
            butConfirm.Click += butConfirm_Click;
            butConfirm.Paint += butConfirm_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(3, 83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 74);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Paint += pictureBox3_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(work_box);
            panel3.Controls.Add(work_label);
            panel3.Location = new Point(169, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 74);
            panel3.TabIndex = 9;
            // 
            // work_box
            // 
            work_box.Anchor = AnchorStyles.None;
            work_box.BackColor = Color.Linen;
            work_box.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            work_box.Location = new Point(0, 42);
            work_box.MaxLength = 7;
            work_box.Name = "work_box";
            work_box.Size = new Size(77, 30);
            work_box.TabIndex = 3;
            work_box.KeyPress += work_box_KeyPress;
            // 
            // work_label
            // 
            work_label.Dock = DockStyle.Top;
            work_label.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            work_label.Location = new Point(0, 0);
            work_label.Name = "work_label";
            work_label.Size = new Size(77, 42);
            work_label.TabIndex = 2;
            work_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butMinusWork
            // 
            butMinusWork.BackColor = Color.AntiqueWhite;
            butMinusWork.Dock = DockStyle.Fill;
            butMinusWork.Location = new Point(86, 83);
            butMinusWork.Name = "butMinusWork";
            butMinusWork.Size = new Size(77, 74);
            butMinusWork.TabIndex = 10;
            butMinusWork.UseVisualStyleBackColor = false;
            butMinusWork.Click += butMinusWork_Click;
            butMinusWork.Paint += butMinusWork_Paint;
            // 
            // butPlusWork
            // 
            butPlusWork.BackColor = Color.AntiqueWhite;
            butPlusWork.Dock = DockStyle.Fill;
            butPlusWork.Location = new Point(252, 83);
            butPlusWork.Name = "butPlusWork";
            butPlusWork.Size = new Size(79, 74);
            butPlusWork.TabIndex = 11;
            butPlusWork.UseVisualStyleBackColor = false;
            butPlusWork.Click += butPlusWork_Click;
            butPlusWork.Paint += butPlusWork_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(3, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 74);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Paint += pictureBox4_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(relaxBox);
            panel4.Controls.Add(relax_label);
            panel4.Location = new Point(169, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(77, 74);
            panel4.TabIndex = 13;
            // 
            // relaxBox
            // 
            relaxBox.Anchor = AnchorStyles.None;
            relaxBox.BackColor = Color.Linen;
            relaxBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            relaxBox.Location = new Point(0, 43);
            relaxBox.MaxLength = 7;
            relaxBox.Name = "relaxBox";
            relaxBox.Size = new Size(77, 30);
            relaxBox.TabIndex = 5;
            relaxBox.KeyPress += relaxBox_KeyPress;
            // 
            // relax_label
            // 
            relax_label.Dock = DockStyle.Top;
            relax_label.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            relax_label.Location = new Point(0, 0);
            relax_label.Name = "relax_label";
            relax_label.Size = new Size(77, 42);
            relax_label.TabIndex = 4;
            relax_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butMinusRelax
            // 
            butMinusRelax.BackColor = Color.AntiqueWhite;
            butMinusRelax.Dock = DockStyle.Fill;
            butMinusRelax.Location = new Point(86, 163);
            butMinusRelax.Name = "butMinusRelax";
            butMinusRelax.Size = new Size(77, 74);
            butMinusRelax.TabIndex = 14;
            butMinusRelax.UseVisualStyleBackColor = false;
            butMinusRelax.Click += butMinusRelax_Click;
            butMinusRelax.Paint += butMinusRelax_Paint;
            // 
            // butPlusRelax
            // 
            butPlusRelax.BackColor = Color.AntiqueWhite;
            butPlusRelax.Dock = DockStyle.Fill;
            butPlusRelax.Location = new Point(252, 163);
            butPlusRelax.Name = "butPlusRelax";
            butPlusRelax.Size = new Size(79, 74);
            butPlusRelax.TabIndex = 15;
            butPlusRelax.UseVisualStyleBackColor = false;
            butPlusRelax.Click += butPlusRelax_Click;
            butPlusRelax.Paint += butPlusRelax_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(3, 243);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 74);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Paint += pictureBox5_Paint;
            // 
            // butMinusRest
            // 
            butMinusRest.BackColor = Color.AntiqueWhite;
            butMinusRest.Dock = DockStyle.Fill;
            butMinusRest.Location = new Point(86, 243);
            butMinusRest.Name = "butMinusRest";
            butMinusRest.Size = new Size(77, 74);
            butMinusRest.TabIndex = 17;
            butMinusRest.UseVisualStyleBackColor = false;
            butMinusRest.Click += butMinusRest_Click;
            // 
            // butPlusRest
            // 
            butPlusRest.BackColor = Color.AntiqueWhite;
            butPlusRest.Dock = DockStyle.Fill;
            butPlusRest.Location = new Point(252, 243);
            butPlusRest.Name = "butPlusRest";
            butPlusRest.Size = new Size(79, 74);
            butPlusRest.TabIndex = 18;
            butPlusRest.UseVisualStyleBackColor = false;
            butPlusRest.Click += butPlusRest_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(restBox);
            panel5.Controls.Add(rest_label);
            panel5.Location = new Point(169, 243);
            panel5.Name = "panel5";
            panel5.Size = new Size(77, 74);
            panel5.TabIndex = 19;
            // 
            // restBox
            // 
            restBox.Anchor = AnchorStyles.None;
            restBox.BackColor = Color.Linen;
            restBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            restBox.Location = new Point(0, 44);
            restBox.MaxLength = 7;
            restBox.Name = "restBox";
            restBox.Size = new Size(77, 30);
            restBox.TabIndex = 7;
            // 
            // rest_label
            // 
            rest_label.Dock = DockStyle.Top;
            rest_label.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rest_label.Location = new Point(0, 0);
            rest_label.Name = "rest_label";
            rest_label.Size = new Size(77, 42);
            rest_label.TabIndex = 6;
            rest_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(AddTraineeLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(334, 52);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddTraineeLabel
            // 
            AddTraineeLabel.AutoSize = true;
            AddTraineeLabel.Dock = DockStyle.Fill;
            AddTraineeLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddTraineeLabel.Location = new Point(3, 0);
            AddTraineeLabel.Name = "AddTraineeLabel";
            AddTraineeLabel.Size = new Size(328, 52);
            AddTraineeLabel.TabIndex = 0;
            AddTraineeLabel.Text = "Добавить тренировку";
            AddTraineeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253F));
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(334, 80);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(TraineeTitleLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(84, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 74);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Linen;
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(0, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 30);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TraineeTitleLabel
            // 
            TraineeTitleLabel.Anchor = AnchorStyles.Top;
            TraineeTitleLabel.AutoSize = true;
            TraineeTitleLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TraineeTitleLabel.Location = new Point(79, 0);
            TraineeTitleLabel.Name = "TraineeTitleLabel";
            TraineeTitleLabel.Size = new Size(83, 23);
            TraineeTitleLabel.TabIndex = 0;
            TraineeTitleLabel.Text = "Название";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 74);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += pictureBox2_Paint;
            // 
            // AddTraineeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(334, 600);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "AddTraineeForm";
            Text = "AddTrainee";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label run_up_label;
        private Panel panel1;
        private TextBox timeRun_up_box;
        private Button butMinusRunUp;
        private Button butPlusRunUp;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label AddTraineeLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private TextBox textBox1;
        private Label TraineeTitleLabel;
        private Button butConfirm;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private TextBox work_box;
        private Label work_label;
        private Button butMinusWork;
        private Button butPlusWork;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Button butMinusRelax;
        private Button butPlusRelax;
        private TextBox relaxBox;
        private Label relax_label;
        private PictureBox pictureBox5;
        private Button butMinusRest;
        private Button butPlusRest;
        private Panel panel5;
        private TextBox restBox;
        private Label rest_label;
    }
}