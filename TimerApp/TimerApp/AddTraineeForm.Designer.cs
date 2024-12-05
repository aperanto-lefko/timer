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
            label1 = new Label();
            butMinus = new Button();
            butPlus = new Button();
            butConfirm = new Button();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Controls.Add(butMinus, 1, 1);
            tableLayoutPanel1.Controls.Add(butPlus, 3, 1);
            tableLayoutPanel1.Controls.Add(butConfirm, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(334, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(timeRun_up_box);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(169, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 68);
            panel1.TabIndex = 2;
            // 
            // timeRun_up_box
            // 
            timeRun_up_box.BackColor = Color.Linen;
            timeRun_up_box.Dock = DockStyle.Bottom;
            timeRun_up_box.Location = new Point(0, 45);
            timeRun_up_box.Name = "timeRun_up_box";
            timeRun_up_box.Size = new Size(77, 23);
            timeRun_up_box.TabIndex = 1;
            timeRun_up_box.KeyPress += timeRun_up_box_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 0;
            label1.Text = "Подготовка";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butMinus
            // 
            butMinus.BackColor = Color.AntiqueWhite;
            butMinus.Dock = DockStyle.Fill;
            butMinus.ForeColor = SystemColors.ControlText;
            butMinus.Location = new Point(86, 158);
            butMinus.Name = "butMinus";
            butMinus.Size = new Size(77, 68);
            butMinus.TabIndex = 3;
            butMinus.UseVisualStyleBackColor = false;
            butMinus.Click += butMinus_Click;
            butMinus.Paint += butMinus_Paint;
            // 
            // butPlus
            // 
            butPlus.BackColor = Color.AntiqueWhite;
            butPlus.Dock = DockStyle.Fill;
            butPlus.Location = new Point(252, 158);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(79, 68);
            butPlus.TabIndex = 4;
            butPlus.UseVisualStyleBackColor = false;
            butPlus.Click += butPlus_Click;
            butPlus.Paint += butPlus_Paint;
            // 
            // butConfirm
            // 
            butConfirm.BackColor = Color.AntiqueWhite;
            butConfirm.Dock = DockStyle.Fill;
            butConfirm.Location = new Point(252, 488);
            butConfirm.Name = "butConfirm";
            butConfirm.Size = new Size(79, 70);
            butConfirm.TabIndex = 5;
            butConfirm.UseVisualStyleBackColor = false;
            butConfirm.Click += butConfirm_Click;
            // 
            // AddTraineeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(334, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "AddTraineeForm";
            Text = "AddTrainee";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private TextBox timeRun_up_box;
        private Button butMinus;
        private Button butPlus;
        private Button butConfirm;
    }
}