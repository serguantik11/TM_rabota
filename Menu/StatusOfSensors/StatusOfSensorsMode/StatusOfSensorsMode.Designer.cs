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
            SuspendLayout();
            // 
            // back
            // 
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
            SensorName.BackColor = Color.Transparent;
            SensorName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SensorName.Location = new Point(38, 32);
            SensorName.Name = "SensorName";
            SensorName.Size = new Size(37, 20);
            SensorName.TabIndex = 1;
            SensorName.Text = "       ";
            // 
            // StatusOfSensorsMode
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.sensorstatus;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
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
            Text = "StatusOfSensors";
            FormClosing += StatusOfSensors_FormClosing;
            Load += StatusOfSensorsMode_Load;
            KeyUp += StatusOfSensors_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label SensorName;
    }
}