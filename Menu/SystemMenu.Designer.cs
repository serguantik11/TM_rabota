namespace TM_Simulator
{
    partial class SystemMenu
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
            statisticdata = new Button();
            help = new Button();
            Settings = new Button();
            kalibratepage = new Button();
            sensorsstatus = new Button();
            copydata = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            time = new Label();
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
            // statisticdata
            // 
            statisticdata.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            statisticdata.Location = new Point(115, 180);
            statisticdata.Margin = new Padding(2);
            statisticdata.MaximumSize = new Size(900, 60);
            statisticdata.MinimumSize = new Size(900, 60);
            statisticdata.Name = "statisticdata";
            statisticdata.Size = new Size(900, 60);
            statisticdata.TabIndex = 1;
            statisticdata.Text = "Статистические данные";
            statisticdata.UseVisualStyleBackColor = true;
            statisticdata.Click += statisticdata_Click;
            // 
            // help
            // 
            help.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            help.Location = new Point(115, 245);
            help.Margin = new Padding(2);
            help.MaximumSize = new Size(900, 60);
            help.MinimumSize = new Size(900, 60);
            help.Name = "help";
            help.Size = new Size(900, 60);
            help.TabIndex = 2;
            help.Text = "Помощь";
            help.UseVisualStyleBackColor = true;
            help.Click += help_Click;
            // 
            // Settings
            // 
            Settings.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Settings.Location = new Point(115, 310);
            Settings.Margin = new Padding(2);
            Settings.MaximumSize = new Size(900, 60);
            Settings.MinimumSize = new Size(900, 60);
            Settings.Name = "Settings";
            Settings.Size = new Size(900, 60);
            Settings.TabIndex = 3;
            Settings.Text = "Настройки";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // kalibratepage
            // 
            kalibratepage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            kalibratepage.Location = new Point(115, 375);
            kalibratepage.Margin = new Padding(2);
            kalibratepage.MaximumSize = new Size(900, 60);
            kalibratepage.MinimumSize = new Size(900, 60);
            kalibratepage.Name = "kalibratepage";
            kalibratepage.Size = new Size(900, 60);
            kalibratepage.TabIndex = 4;
            kalibratepage.Text = "Калибровки";
            kalibratepage.UseVisualStyleBackColor = true;
            kalibratepage.Click += kalibratepage_Click;
            // 
            // sensorsstatus
            // 
            sensorsstatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sensorsstatus.Location = new Point(115, 440);
            sensorsstatus.Margin = new Padding(2);
            sensorsstatus.MaximumSize = new Size(900, 60);
            sensorsstatus.MinimumSize = new Size(900, 60);
            sensorsstatus.Name = "sensorsstatus";
            sensorsstatus.Size = new Size(900, 60);
            sensorsstatus.TabIndex = 5;
            sensorsstatus.Text = "Состояние датчиков";
            sensorsstatus.UseVisualStyleBackColor = true;
            sensorsstatus.Click += sensorsstatus_Click;
            // 
            // copydata
            // 
            copydata.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            copydata.Location = new Point(115, 505);
            copydata.Margin = new Padding(2);
            copydata.MaximumSize = new Size(900, 60);
            copydata.MinimumSize = new Size(900, 60);
            copydata.Name = "copydata";
            copydata.Size = new Size(900, 60);
            copydata.TabIndex = 6;
            copydata.Text = "Копирование данных";
            copydata.UseVisualStyleBackColor = true;
            copydata.Click += Copydata_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
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
            // SystemMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.SystemMenu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 681);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(copydata);
            Controls.Add(sensorsstatus);
            Controls.Add(kalibratepage);
            Controls.Add(Settings);
            Controls.Add(help);
            Controls.Add(statisticdata);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "SystemMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += SystemMenu_FormClosing;
            Load += SystemMenu_Load;
            KeyUp += SystemMenu_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button statisticdata;
        private Button help;
        private Button Settings;
        private Button kalibratepage;
        private Button sensorsstatus;
        private Button copydata;
        private System.Windows.Forms.Timer timer1;
        private Label time;
        private Label date;
    }
}