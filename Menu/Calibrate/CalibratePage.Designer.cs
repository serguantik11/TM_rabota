namespace TM_Simulator
{
    partial class CalibratePage
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            back.Click += backmenu_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 135);
            button1.Name = "button1";
            button1.Size = new Size(730, 40);
            button1.TabIndex = 1;
            button1.Text = "Зазор подбарабанья";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 183);
            button2.Name = "button2";
            button2.Size = new Size(730, 40);
            button2.TabIndex = 2;
            button2.Text = "Нижние решета";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(25, 229);
            button3.Name = "button3";
            button3.Size = new Size(730, 40);
            button3.TabIndex = 3;
            button3.Text = "Верхние решета";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // CalibratePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.calibratepage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "CalibratePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += CalibratePage_FormClosing;
            Load += CalibratePage_Load;
            KeyUp += CalibratePage_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
    }
}