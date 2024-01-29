namespace TM_Simulator
{
    partial class Settings
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
            back = new Button();
            combinesettings = new Button();
            systemsettings2 = new Button();
            terminalsettings = new Button();
            operatingmode = new Button();
            systemsettings = new Button();
            time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            date = new Label();
            SuspendLayout();
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
            // combinesettings
            // 
            combinesettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            combinesettings.Location = new Point(55, 315);
            combinesettings.Margin = new Padding(2);
            combinesettings.MaximumSize = new Size(680, 40);
            combinesettings.MinimumSize = new Size(680, 40);
            combinesettings.Name = "combinesettings";
            combinesettings.Size = new Size(680, 40);
            combinesettings.TabIndex = 1;
            combinesettings.Text = "Настройки комбайна";
            combinesettings.UseVisualStyleBackColor = true;
            combinesettings.Click += combinesettings_Click;
            // 
            // systemsettings2
            // 
            systemsettings2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            systemsettings2.Location = new Point(55, 270);
            systemsettings2.Margin = new Padding(2);
            systemsettings2.MaximumSize = new Size(680, 40);
            systemsettings2.MinimumSize = new Size(680, 40);
            systemsettings2.Name = "systemsettings2";
            systemsettings2.Size = new Size(680, 40);
            systemsettings2.TabIndex = 1;
            systemsettings2.Text = "Настройки системы 2";
            systemsettings2.UseVisualStyleBackColor = true;
            systemsettings2.Click += systemsettings2_Click;
            // 
            // terminalsettings
            // 
            terminalsettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            terminalsettings.Location = new Point(55, 225);
            terminalsettings.Margin = new Padding(2);
            terminalsettings.MaximumSize = new Size(680, 40);
            terminalsettings.Name = "terminalsettings";
            terminalsettings.Size = new Size(680, 40);
            terminalsettings.TabIndex = 1;
            terminalsettings.Text = "Настройки терминала";
            terminalsettings.UseVisualStyleBackColor = true;
            terminalsettings.Click += terminalsettings_Click;
            // 
            // operatingmode
            // 
            operatingmode.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            operatingmode.Location = new Point(55, 180);
            operatingmode.Margin = new Padding(2);
            operatingmode.MaximumSize = new Size(680, 40);
            operatingmode.MinimumSize = new Size(680, 40);
            operatingmode.Name = "operatingmode";
            operatingmode.Size = new Size(680, 40);
            operatingmode.TabIndex = 1;
            operatingmode.Text = "Режим работы";
            operatingmode.UseVisualStyleBackColor = true;
            operatingmode.Click += Operatingmode_Click;
            // 
            // systemsettings
            // 
            systemsettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            systemsettings.Location = new Point(55, 135);
            systemsettings.Margin = new Padding(2);
            systemsettings.MaximumSize = new Size(680, 40);
            systemsettings.MinimumSize = new Size(680, 40);
            systemsettings.Name = "systemsettings";
            systemsettings.Size = new Size(680, 40);
            systemsettings.TabIndex = 1;
            systemsettings.Text = "Настройки системы";
            systemsettings.UseVisualStyleBackColor = true;
            systemsettings.Click += systemsettings_Click;
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
            timer1.Tick += timer1_Tick;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(systemsettings);
            Controls.Add(operatingmode);
            Controls.Add(terminalsettings);
            Controls.Add(systemsettings2);
            Controls.Add(combinesettings);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += Settings_FormClosing;
            Load += Form3_Load;
            KeyUp += Settings_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button combinesettings;
        private Button systemsettings2;
        private Button terminalsettings;
        private Button operatingmode;
        private Button systemsettings;
        private Label time;
        private System.Windows.Forms.Timer timer1;
        private Label date;
    }
}