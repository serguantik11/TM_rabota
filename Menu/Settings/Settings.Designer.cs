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
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
            back.TabIndex = 0;
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // combinesettings
            // 
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
            systemsettings2.Location = new Point(55, 270);
            systemsettings2.Margin = new Padding(2);
            systemsettings2.MaximumSize = new Size(680, 40);
            systemsettings2.MinimumSize = new Size(680, 40);
            systemsettings2.Name = "systemsettings2";
            systemsettings2.Size = new Size(680, 40);
            systemsettings2.TabIndex = 1;
            systemsettings2.Text = "Настройки системы 2";
            systemsettings2.UseVisualStyleBackColor = true;
            // 
            // terminalsettings
            // 
            terminalsettings.Location = new Point(55, 225);
            terminalsettings.Margin = new Padding(2);
            terminalsettings.MaximumSize = new Size(680, 40);
            terminalsettings.Name = "terminalsettings";
            terminalsettings.Size = new Size(680, 40);
            terminalsettings.TabIndex = 1;
            terminalsettings.Text = "Настройки терминала";
            terminalsettings.UseVisualStyleBackColor = true;
            // 
            // operatingmode
            // 
            operatingmode.Location = new Point(55, 180);
            operatingmode.Margin = new Padding(2);
            operatingmode.MaximumSize = new Size(680, 40);
            operatingmode.MinimumSize = new Size(680, 40);
            operatingmode.Name = "operatingmode";
            operatingmode.Size = new Size(680, 40);
            operatingmode.TabIndex = 1;
            operatingmode.Text = "Режим работы";
            operatingmode.UseVisualStyleBackColor = true;
            // 
            // systemsettings
            // 
            systemsettings.Location = new Point(55, 135);
            systemsettings.Margin = new Padding(2);
            systemsettings.MaximumSize = new Size(680, 40);
            systemsettings.MinimumSize = new Size(680, 40);
            systemsettings.Name = "systemsettings";
            systemsettings.Size = new Size(680, 40);
            systemsettings.TabIndex = 1;
            systemsettings.Text = "Настройки системы";
            systemsettings.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(624, -4);
            time.Margin = new Padding(2, 0, 2, 0);
            time.Name = "time";
            time.Size = new Size(110, 41);
            time.TabIndex = 2;
            time.Text = "время";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(616, 32);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(53, 25);
            date.TabIndex = 3;
            date.Text = "дата";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
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
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
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