namespace TM_Simulator
{
    partial class StatusOfSensorsPage
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
            workingbodiesbutton = new Button();
            sensstatusbutton = new Button();
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // workingbodiesbutton
            // 
            workingbodiesbutton.Location = new Point(55, 140);
            workingbodiesbutton.MaximumSize = new Size(680, 40);
            workingbodiesbutton.MinimumSize = new Size(680, 40);
            workingbodiesbutton.Name = "workingbodiesbutton";
            workingbodiesbutton.Size = new Size(680, 40);
            workingbodiesbutton.TabIndex = 1;
            workingbodiesbutton.Text = "Обороты рабочих органов";
            workingbodiesbutton.UseVisualStyleBackColor = true;
            workingbodiesbutton.Click += workingbodiesbutton_Click;
            // 
            // sensstatusbutton
            // 
            sensstatusbutton.Location = new Point(55, 190);
            sensstatusbutton.MaximumSize = new Size(680, 40);
            sensstatusbutton.MinimumSize = new Size(680, 40);
            sensstatusbutton.Name = "sensstatusbutton";
            sensstatusbutton.Size = new Size(680, 40);
            sensstatusbutton.TabIndex = 2;
            sensstatusbutton.Text = "Состояние датчиков";
            sensstatusbutton.UseVisualStyleBackColor = true;
            sensstatusbutton.Click += sensstatusbutton_Click;
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
            timer1.Tick += timer1_Tick;
            // 
            // StatusOfSensors
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.sensorsstatusmenu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(sensstatusbutton);
            Controls.Add(workingbodiesbutton);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "StatusOfSensors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatusOfSensors";
            FormClosing += StatusOfSensors_FormClosing;
            KeyUp += StatusOfSensors_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button workingbodiesbutton;
        private Button sensstatusbutton;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
    }
}