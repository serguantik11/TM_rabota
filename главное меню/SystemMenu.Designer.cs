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
            back = new Button();
            statisticdata = new Button();
            help = new Button();
            Settings = new Button();
            kalibratepage = new Button();
            sensorsstatus = new Button();
            copydata = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(12, 12);
            back.MaximumSize = new Size(120, 50);
            back.MinimumSize = new Size(120, 50);
            back.Name = "back";
            back.Size = new Size(120, 50);
            back.TabIndex = 0;
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // statisticdata
            // 
            statisticdata.Location = new Point(25, 142);
            statisticdata.MaximumSize = new Size(850, 50);
            statisticdata.MinimumSize = new Size(850, 50);
            statisticdata.Name = "statisticdata";
            statisticdata.Size = new Size(850, 50);
            statisticdata.TabIndex = 1;
            statisticdata.Text = "Статистические данные";
            statisticdata.UseVisualStyleBackColor = true;
            statisticdata.Click += statisticdata_Click;
            // 
            // help
            // 
            help.Location = new Point(25, 198);
            help.MaximumSize = new Size(850, 50);
            help.MinimumSize = new Size(850, 50);
            help.Name = "help";
            help.Size = new Size(850, 50);
            help.TabIndex = 2;
            help.Text = "Помощь";
            help.UseVisualStyleBackColor = true;
            help.Click += help_Click;
            // 
            // Settings
            // 
            Settings.Location = new Point(25, 253);
            Settings.MaximumSize = new Size(850, 50);
            Settings.MinimumSize = new Size(850, 50);
            Settings.Name = "Settings";
            Settings.Size = new Size(850, 50);
            Settings.TabIndex = 3;
            Settings.Text = "Настройки";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // kalibratepage
            // 
            kalibratepage.Location = new Point(25, 307);
            kalibratepage.MaximumSize = new Size(850, 50);
            kalibratepage.MinimumSize = new Size(850, 50);
            kalibratepage.Name = "kalibratepage";
            kalibratepage.Size = new Size(850, 50);
            kalibratepage.TabIndex = 4;
            kalibratepage.Text = "Калибровки";
            kalibratepage.UseVisualStyleBackColor = true;
            kalibratepage.Click += kalibratepage_Click;
            // 
            // sensorsstatus
            // 
            sensorsstatus.Location = new Point(25, 360);
            sensorsstatus.MaximumSize = new Size(850, 50);
            sensorsstatus.MinimumSize = new Size(850, 50);
            sensorsstatus.Name = "sensorsstatus";
            sensorsstatus.Size = new Size(850, 50);
            sensorsstatus.TabIndex = 5;
            sensorsstatus.Text = "Состояние датчиков";
            sensorsstatus.UseVisualStyleBackColor = true;
            // 
            // copydata
            // 
            copydata.Location = new Point(25, 415);
            copydata.MaximumSize = new Size(850, 50);
            copydata.MinimumSize = new Size(850, 50);
            copydata.Name = "copydata";
            copydata.Size = new Size(850, 50);
            copydata.TabIndex = 6;
            copydata.Text = "Копирование данных";
            copydata.UseVisualStyleBackColor = true;
            // 
            // SystemMenu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.SystemMenu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(copydata);
            Controls.Add(sensorsstatus);
            Controls.Add(kalibratepage);
            Controls.Add(Settings);
            Controls.Add(help);
            Controls.Add(statisticdata);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "SystemMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemMenu";
            FormClosing += SystemMenu_FormClosing;
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
    }
}