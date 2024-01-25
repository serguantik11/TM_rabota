namespace TM_Simulator.Menu.CopyMenu
{
    partial class CopyMenu
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
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            FuelConsumption = new Button();
            EventLog = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += Back_Click;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(608, -4);
            time.Margin = new Padding(2, 0, 2, 0);
            time.Name = "time";
            time.Size = new Size(110, 41);
            time.TabIndex = 2;
            time.Text = "время";
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(600, 32);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(53, 25);
            date.TabIndex = 3;
            date.Text = "дата";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 78);
            label1.Name = "label1";
            label1.Size = new Size(356, 37);
            label1.TabIndex = 3;
            label1.Text = "КОПИРОВАНИЕ ДАННЫХ";
            // 
            // FuelConsumption
            // 
            FuelConsumption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FuelConsumption.Location = new Point(30, 130);
            FuelConsumption.Name = "FuelConsumption";
            FuelConsumption.Size = new Size(720, 40);
            FuelConsumption.TabIndex = 4;
            FuelConsumption.Text = "Расход топлива";
            FuelConsumption.UseVisualStyleBackColor = true;
            FuelConsumption.Click += FuelConsumption_Click;
            // 
            // EventLog
            // 
            EventLog.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EventLog.Location = new Point(30, 182);
            EventLog.Name = "EventLog";
            EventLog.Size = new Size(720, 40);
            EventLog.TabIndex = 5;
            EventLog.Text = "Журнал событий";
            EventLog.UseVisualStyleBackColor = true;
            EventLog.Click += EventLog_Click;
            // 
            // CopyMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.CopyMenuImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(EventLog);
            Controls.Add(FuelConsumption);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "CopyMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += CopyMenu_FormClosing;
            Load += CopyMenu_Load;
            KeyDown += CopyMenu_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button FuelConsumption;
        private Button EventLog;
    }
}