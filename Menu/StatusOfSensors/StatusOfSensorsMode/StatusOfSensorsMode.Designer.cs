namespace TM_Simulator
{
    partial class StatusOfSensorsMode
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
            SensorName = new Label();
            PageName = new Label();
            EngineerModeBtn = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(677, 11);
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
            // SensorName
            // 
            SensorName.AutoSize = true;
            SensorName.BackColor = Color.White;
            SensorName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SensorName.Location = new Point(40, 32);
            SensorName.Name = "SensorName";
            SensorName.Size = new Size(37, 20);
            SensorName.TabIndex = 1;
            SensorName.Text = "       ";
            // 
            // PageName
            // 
            PageName.BackColor = Color.Transparent;
            PageName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PageName.ForeColor = Color.Black;
            PageName.Location = new Point(12, -9);
            PageName.Name = "PageName";
            PageName.Size = new Size(659, 45);
            PageName.TabIndex = 2;
            PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ";
            PageName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EngineerModeBtn
            // 
            EngineerModeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EngineerModeBtn.Location = new Point(676, 56);
            EngineerModeBtn.Name = "EngineerModeBtn";
            EngineerModeBtn.Size = new Size(106, 53);
            EngineerModeBtn.TabIndex = 3;
            EngineerModeBtn.Text = "ENGINEER MODE";
            EngineerModeBtn.UseVisualStyleBackColor = true;
            EngineerModeBtn.Click += EngineerModeBtn_Click;
            // 
            // StatusOfSensorsMode
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(EngineerModeBtn);
            Controls.Add(PageName);
            Controls.Add(SensorName);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(800, 510);
            MinimizeBox = false;
            MinimumSize = new Size(800, 510);
            Name = "StatusOfSensorsMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += StatusOfSensors_FormClosing;
            Load += StatusOfSensorsMode_Load;
            KeyDown += StatusOfSensors_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label SensorName;
        private Label PageName;
        private Button EngineerModeBtn;
    }
}