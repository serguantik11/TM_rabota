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
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
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
            // button1
            // 
            button1.Location = new Point(55, 130);
            button1.MaximumSize = new Size(680, 40);
            button1.MinimumSize = new Size(680, 40);
            button1.Name = "button1";
            button1.Size = new Size(680, 40);
            button1.TabIndex = 4;
            button1.Text = "Статистика";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 175);
            button2.MaximumSize = new Size(680, 40);
            button2.MinimumSize = new Size(680, 40);
            button2.Name = "button2";
            button2.Size = new Size(680, 40);
            button2.TabIndex = 5;
            button2.Text = "Аварийная статистика";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(55, 220);
            button3.MaximumSize = new Size(680, 40);
            button3.MinimumSize = new Size(680, 40);
            button3.Name = "button3";
            button3.Size = new Size(680, 40);
            button3.TabIndex = 6;
            button3.Text = "Журнал событий";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(55, 265);
            button4.MaximumSize = new Size(680, 40);
            button4.MinimumSize = new Size(680, 40);
            button4.Name = "button4";
            button4.Size = new Size(680, 40);
            button4.TabIndex = 7;
            button4.Text = "Техническое обслуживание";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(55, 310);
            button5.MaximumSize = new Size(680, 40);
            button5.MinimumSize = new Size(680, 40);
            button5.Name = "button5";
            button5.Size = new Size(680, 40);
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
            ClientSize = new Size(784, 471);
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
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "StatisticData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticData";
            FormClosing += StatisticData_FormClosing;
            Load += StatisticData_Load;
            KeyUp += StatisticData_KeyUp;
            ResumeLayout(false);
            PerformLayout();
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