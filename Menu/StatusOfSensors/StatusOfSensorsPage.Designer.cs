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
            // workingbodiesbutton
            // 
            workingbodiesbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            workingbodiesbutton.Location = new Point(115, 210);
            workingbodiesbutton.MaximumSize = new Size(900, 60);
            workingbodiesbutton.MinimumSize = new Size(900, 60);
            workingbodiesbutton.Name = "workingbodiesbutton";
            workingbodiesbutton.Size = new Size(900, 60);
            workingbodiesbutton.TabIndex = 1;
            workingbodiesbutton.Text = "Обороты рабочих органов";
            workingbodiesbutton.UseVisualStyleBackColor = true;
            workingbodiesbutton.Click += workingbodiesbutton_Click;
            // 
            // sensstatusbutton
            // 
            sensstatusbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sensstatusbutton.Location = new Point(115, 280);
            sensstatusbutton.MaximumSize = new Size(900, 60);
            sensstatusbutton.MinimumSize = new Size(900, 60);
            sensstatusbutton.Name = "sensstatusbutton";
            sensstatusbutton.Size = new Size(900, 60);
            sensstatusbutton.TabIndex = 2;
            sensstatusbutton.Text = "Состояние датчиков";
            sensstatusbutton.UseVisualStyleBackColor = true;
            sensstatusbutton.Click += sensstatusbutton_Click;
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
            // StatusOfSensorsPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.sensorsstatusmenu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(sensstatusbutton);
            Controls.Add(workingbodiesbutton);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "StatusOfSensorsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += StatusOfSensors_FormClosing;
            Load += StatusOfSensorsPage_Load;
            KeyUp += StatusOfSensors_KeyUp;
            ResumeLayout(false);
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