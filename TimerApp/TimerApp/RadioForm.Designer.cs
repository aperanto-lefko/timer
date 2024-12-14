namespace TimerApp
{
    partial class RadioForm
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
            monteCarloBut = new RadioButton();
            europaPlBut = new RadioButton();
            energyBut = new RadioButton();
            hitFmBut = new RadioButton();
            yandexBut = new RadioButton();
            confirmRadioBut = new Button();
            closeRadioBut = new Button();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(monteCarloBut, 0, 0);
            tableLayoutPanel1.Controls.Add(europaPlBut, 0, 1);
            tableLayoutPanel1.Controls.Add(energyBut, 0, 2);
            tableLayoutPanel1.Controls.Add(hitFmBut, 0, 3);
            tableLayoutPanel1.Controls.Add(yandexBut, 0, 4);
            tableLayoutPanel1.Controls.Add(confirmRadioBut, 1, 5);
            tableLayoutPanel1.Controls.Add(closeRadioBut, 0, 5);
            tableLayoutPanel1.Location = new Point(12, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(260, 240);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // monteCarloBut
            // 
            monteCarloBut.AutoSize = true;
            monteCarloBut.Dock = DockStyle.Fill;
            monteCarloBut.Location = new Point(3, 3);
            monteCarloBut.Name = "monteCarloBut";
            monteCarloBut.Size = new Size(209, 34);
            monteCarloBut.TabIndex = 0;
            monteCarloBut.TabStop = true;
            monteCarloBut.Text = "Радио \"Monte Carlo\"";
            monteCarloBut.UseVisualStyleBackColor = true;
            // 
            // europaPlBut
            // 
            europaPlBut.AutoSize = true;
            europaPlBut.Dock = DockStyle.Fill;
            europaPlBut.Location = new Point(3, 43);
            europaPlBut.Name = "europaPlBut";
            europaPlBut.Size = new Size(209, 34);
            europaPlBut.TabIndex = 1;
            europaPlBut.TabStop = true;
            europaPlBut.Text = "Радио \"Europa Plus\"";
            europaPlBut.UseVisualStyleBackColor = true;
            // 
            // energyBut
            // 
            energyBut.AutoSize = true;
            energyBut.Dock = DockStyle.Fill;
            energyBut.Location = new Point(3, 83);
            energyBut.Name = "energyBut";
            energyBut.Size = new Size(209, 34);
            energyBut.TabIndex = 2;
            energyBut.TabStop = true;
            energyBut.Text = "Радио \"Energy\"";
            energyBut.UseVisualStyleBackColor = true;
            // 
            // hitFmBut
            // 
            hitFmBut.AutoSize = true;
            hitFmBut.Dock = DockStyle.Fill;
            hitFmBut.Location = new Point(3, 123);
            hitFmBut.Name = "hitFmBut";
            hitFmBut.Size = new Size(209, 34);
            hitFmBut.TabIndex = 3;
            hitFmBut.TabStop = true;
            hitFmBut.Text = "Радио \"Хит FM\"";
            hitFmBut.UseVisualStyleBackColor = true;
            // 
            // yandexBut
            // 
            yandexBut.AutoSize = true;
            yandexBut.Dock = DockStyle.Fill;
            yandexBut.Location = new Point(3, 163);
            yandexBut.Name = "yandexBut";
            yandexBut.Size = new Size(209, 34);
            yandexBut.TabIndex = 4;
            yandexBut.TabStop = true;
            yandexBut.Text = "Yandex Music";
            yandexBut.UseVisualStyleBackColor = true;
            // 
            // confirmRadioBut
            // 
            confirmRadioBut.BackColor = Color.AntiqueWhite;
            confirmRadioBut.Dock = DockStyle.Fill;
            confirmRadioBut.Location = new Point(218, 203);
            confirmRadioBut.Name = "confirmRadioBut";
            confirmRadioBut.Size = new Size(39, 34);
            confirmRadioBut.TabIndex = 6;
            toolTip1.SetToolTip(confirmRadioBut, "Подтвердить выбор");
            confirmRadioBut.UseVisualStyleBackColor = false;
            confirmRadioBut.Click += confirmRadioBut_Click;
            confirmRadioBut.Paint += confirmRadioBut_Paint;
            // 
            // closeRadioBut
            // 
            closeRadioBut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeRadioBut.BackColor = Color.AntiqueWhite;
            closeRadioBut.Location = new Point(172, 203);
            closeRadioBut.Name = "closeRadioBut";
            closeRadioBut.Size = new Size(40, 34);
            closeRadioBut.TabIndex = 5;
            toolTip1.SetToolTip(closeRadioBut, "Закрыть");
            closeRadioBut.UseVisualStyleBackColor = false;
            closeRadioBut.Click += closeRadioBut_Click;
            closeRadioBut.Paint += closeRadioBut_Paint;
            // 
            // RadioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(270, 239);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "RadioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radio";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton monteCarloBut;
        private RadioButton europaPlBut;
        private RadioButton energyBut;
        private RadioButton hitFmBut;
        private RadioButton yandexBut;
        private Button confirmRadioBut;
        private Button closeRadioBut;
        private ToolTip toolTip1;
    }
}