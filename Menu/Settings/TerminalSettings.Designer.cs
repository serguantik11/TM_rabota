namespace TM_Simulator.Menu.Settings
{
    partial class TerminalSettings
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
            checkBox = new Button();
            checkStatus = new Label();
            trackBarVolume = new TrackBar();
            trackBarBrightness = new TrackBar();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            back = new Button();
            timeH = new NumericUpDown();
            timeM = new NumericUpDown();
            dateD = new NumericUpDown();
            datem = new NumericUpDown();
            dateY = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateY).BeginInit();
            SuspendLayout();
            // 
            // checkBox
            // 
            checkBox.Location = new Point(504, 185);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(27, 27);
            checkBox.TabIndex = 0;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Click += checkBox_Click;
            // 
            // checkStatus
            // 
            checkStatus.AutoSize = true;
            checkStatus.BackColor = Color.Transparent;
            checkStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkStatus.Location = new Point(537, 182);
            checkStatus.Name = "checkStatus";
            checkStatus.Size = new Size(74, 30);
            checkStatus.TabIndex = 1;
            checkStatus.Text = "Выкл.";
            // 
            // trackBarVolume
            // 
            trackBarVolume.AutoSize = false;
            trackBarVolume.BackColor = Color.White;
            trackBarVolume.Location = new Point(504, 230);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(397, 32);
            trackBarVolume.TabIndex = 2;
            trackBarVolume.TickStyle = TickStyle.TopLeft;
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.AutoSize = false;
            trackBarBrightness.BackColor = Color.White;
            trackBarBrightness.Location = new Point(504, 276);
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(397, 32);
            trackBarBrightness.TabIndex = 2;
            trackBarBrightness.TickStyle = TickStyle.TopLeft;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "русский", "English" });
            comboBox1.Location = new Point(504, 426);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 33);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "День", "Ночь" });
            comboBox2.Location = new Point(504, 471);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 33);
            comboBox2.TabIndex = 3;
            // 
            // time
            // 
            time.BackColor = Color.Transparent;
            time.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(958, -3);
            time.Margin = new Padding(2, 0, 2, 0);
            time.Name = "time";
            time.Size = new Size(129, 52);
            time.TabIndex = 2;
            time.Text = "время";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            date.BackColor = Color.Transparent;
            date.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(932, 42);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(176, 37);
            date.TabIndex = 3;
            date.Text = "дата";
            date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(130, 70);
            back.MinimumSize = new Size(130, 70);
            back.Name = "back";
            back.Size = new Size(130, 70);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // timeH
            // 
            timeH.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            timeH.InterceptArrowKeys = false;
            timeH.Location = new Point(504, 327);
            timeH.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            timeH.Name = "timeH";
            timeH.ReadOnly = true;
            timeH.Size = new Size(47, 35);
            timeH.TabIndex = 11;
            timeH.TextAlign = HorizontalAlignment.Center;
            // 
            // timeM
            // 
            timeM.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            timeM.InterceptArrowKeys = false;
            timeM.Location = new Point(586, 327);
            timeM.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            timeM.Name = "timeM";
            timeM.ReadOnly = true;
            timeM.Size = new Size(47, 35);
            timeM.TabIndex = 11;
            timeM.TextAlign = HorizontalAlignment.Center;
            // 
            // dateD
            // 
            dateD.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateD.InterceptArrowKeys = false;
            dateD.Location = new Point(504, 377);
            dateD.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            dateD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dateD.Name = "dateD";
            dateD.ReadOnly = true;
            dateD.Size = new Size(47, 35);
            dateD.TabIndex = 11;
            dateD.TextAlign = HorizontalAlignment.Center;
            dateD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // datem
            // 
            datem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            datem.InterceptArrowKeys = false;
            datem.Location = new Point(586, 377);
            datem.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            datem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            datem.Name = "datem";
            datem.ReadOnly = true;
            datem.Size = new Size(47, 35);
            datem.TabIndex = 11;
            datem.TextAlign = HorizontalAlignment.Center;
            datem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            datem.ValueChanged += datem_ValueChanged;
            // 
            // dateY
            // 
            dateY.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateY.InterceptArrowKeys = false;
            dateY.Location = new Point(667, 377);
            dateY.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            dateY.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            dateY.Name = "dateY";
            dateY.ReadOnly = true;
            dateY.Size = new Size(88, 35);
            dateY.TabIndex = 11;
            dateY.TextAlign = HorizontalAlignment.Center;
            dateY.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            dateY.ValueChanged += dateY_ValueChanged;
            // 
            // TerminalSettings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.terminalSettings;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(dateY);
            Controls.Add(datem);
            Controls.Add(dateD);
            Controls.Add(timeM);
            Controls.Add(timeH);
            Controls.Add(back);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(trackBarBrightness);
            Controls.Add(trackBarVolume);
            Controls.Add(checkStatus);
            Controls.Add(checkBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "TerminalSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += TerminalSettings_FormClosing;
            Load += TerminalSettings_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeH).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateD).EndInit();
            ((System.ComponentModel.ISupportInitialize)datem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkBox;
        private Label checkStatus;
        private TrackBar trackBarVolume;
        private TrackBar trackBarBrightness;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Button back;
        private NumericUpDown timeH;
        private NumericUpDown timeM;
        private NumericUpDown dateD;
        private NumericUpDown datem;
        private NumericUpDown dateY;
    }
}