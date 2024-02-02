namespace TM_Simulator
{
    partial class StatisticData
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
            timer1 = new System.Windows.Forms.Timer(components);
            time = new Label();
            date = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(115, 200);
            button1.MaximumSize = new Size(900, 60);
            button1.MinimumSize = new Size(900, 60);
            button1.Name = "button1";
            button1.Size = new Size(900, 60);
            button1.TabIndex = 4;
            button1.Text = "Статистика";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(115, 265);
            button2.MaximumSize = new Size(900, 60);
            button2.MinimumSize = new Size(900, 60);
            button2.Name = "button2";
            button2.Size = new Size(900, 60);
            button2.TabIndex = 5;
            button2.Text = "Аварийная статистика";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(115, 330);
            button3.MaximumSize = new Size(900, 60);
            button3.MinimumSize = new Size(900, 60);
            button3.Name = "button3";
            button3.Size = new Size(900, 60);
            button3.TabIndex = 6;
            button3.Text = "Журнал событий";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(115, 395);
            button4.MaximumSize = new Size(900, 60);
            button4.MinimumSize = new Size(900, 60);
            button4.Name = "button4";
            button4.Size = new Size(900, 60);
            button4.TabIndex = 7;
            button4.Text = "Техническое обслуживание";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(115, 460);
            button5.MaximumSize = new Size(900, 60);
            button5.MinimumSize = new Size(900, 60);
            button5.Name = "button5";
            button5.Size = new Size(900, 60);
            button5.TabIndex = 8;
            button5.Text = "Активные неисправности J1939";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // StatisticData
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.statisticdata;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "StatisticData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += StatisticData_FormClosing;
            Load += StatisticData_Load;
            KeyUp += StatisticData_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private System.Windows.Forms.Timer timer1;
        private Label time;
        private Label date;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}