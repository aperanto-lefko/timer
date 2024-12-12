namespace TimerApp
{
    partial class MusicForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            addMusicBut = new Button();
            closeBut = new Button();
            plListTimeLab = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pauseBut = new Button();
            playBut = new Button();
            trackLab = new Label();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            playListLab = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(addMusicBut, 0, 0);
            tableLayoutPanel1.Controls.Add(closeBut, 2, 0);
            tableLayoutPanel1.Controls.Add(plListTimeLab, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(580, 55);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // addMusicBut
            // 
            addMusicBut.BackColor = Color.AntiqueWhite;
            addMusicBut.Dock = DockStyle.Fill;
            addMusicBut.Location = new Point(3, 3);
            addMusicBut.Name = "addMusicBut";
            addMusicBut.Size = new Size(54, 49);
            addMusicBut.TabIndex = 0;
            toolTip1.SetToolTip(addMusicBut, "Добавить файлы для воспроизведения");
            addMusicBut.UseVisualStyleBackColor = false;
            addMusicBut.Click += addMusicBut_Click;
            addMusicBut.Paint += addMusicBut_Paint;
            // 
            // closeBut
            // 
            closeBut.BackColor = Color.AntiqueWhite;
            closeBut.Dock = DockStyle.Fill;
            closeBut.Location = new Point(523, 3);
            closeBut.Name = "closeBut";
            closeBut.Size = new Size(54, 49);
            closeBut.TabIndex = 1;
            toolTip1.SetToolTip(closeBut, "Закрыть");
            closeBut.UseVisualStyleBackColor = false;
            closeBut.Click += closeBut_Click;
            closeBut.Paint += closeBut_Paint;
            // 
            // plListTimeLab
            // 
            plListTimeLab.Anchor = AnchorStyles.Right;
            plListTimeLab.AutoSize = true;
            plListTimeLab.Location = new Point(517, 16);
            plListTimeLab.Name = "plListTimeLab";
            plListTimeLab.Size = new Size(0, 23);
            plListTimeLab.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Controls.Add(pauseBut, 1, 0);
            tableLayoutPanel2.Controls.Add(playBut, 2, 0);
            tableLayoutPanel2.Controls.Add(trackLab, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 202);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(580, 55);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // pauseBut
            // 
            pauseBut.BackColor = Color.AntiqueWhite;
            pauseBut.Dock = DockStyle.Fill;
            pauseBut.Location = new Point(463, 3);
            pauseBut.Name = "pauseBut";
            pauseBut.Size = new Size(54, 49);
            pauseBut.TabIndex = 2;
            toolTip1.SetToolTip(pauseBut, "Пауза");
            pauseBut.UseVisualStyleBackColor = false;
            pauseBut.Click += pauseBut_Click;
            pauseBut.Paint += pauseBut_Paint;
            // 
            // playBut
            // 
            playBut.BackColor = Color.AntiqueWhite;
            playBut.Dock = DockStyle.Fill;
            playBut.Location = new Point(523, 3);
            playBut.Name = "playBut";
            playBut.Size = new Size(54, 49);
            playBut.TabIndex = 3;
            toolTip1.SetToolTip(playBut, "Вопроизведение");
            playBut.UseVisualStyleBackColor = false;
            playBut.Click += playBut_Click;
            playBut.Paint += playBut_Paint;
            // 
            // trackLab
            // 
            trackLab.Anchor = AnchorStyles.Left;
            trackLab.AutoSize = true;
            trackLab.Location = new Point(3, 16);
            trackLab.Name = "trackLab";
            trackLab.Size = new Size(0, 23);
            trackLab.TabIndex = 4;
            trackLab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(playListLab, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 55);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(580, 147);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // playListLab
            // 
            playListLab.AutoSize = true;
            playListLab.Location = new Point(3, 0);
            playListLab.Name = "playListLab";
            playListLab.Size = new Size(0, 23);
            playListLab.TabIndex = 0;
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(580, 257);
            ControlBox = false;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MusicForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button addMusicBut;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolTip toolTip1;
        private Button closeBut;
        private Button pauseBut;
        private Button playBut;
        private TableLayoutPanel tableLayoutPanel3;
        private Label playListLab;
        private Label trackLab;
        private Label plListTimeLab;
    }
}