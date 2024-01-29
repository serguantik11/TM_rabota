namespace TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode
{
    partial class SensorsEngineerModePage
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
            SensorsPicture = new PictureBox();
            SensorsName = new Label();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)SensorsPicture).BeginInit();
            SuspendLayout();
            // 
            // SensorsPicture
            // 
            SensorsPicture.BackgroundImageLayout = ImageLayout.Zoom;
            SensorsPicture.Location = new Point(116, 6);
            SensorsPicture.Name = "SensorsPicture";
            SensorsPicture.Size = new Size(65, 65);
            SensorsPicture.TabIndex = 0;
            SensorsPicture.TabStop = false;
            SensorsPicture.Visible = false;
            // 
            // SensorsName
            // 
            SensorsName.BackColor = Color.Transparent;
            SensorsName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SensorsName.ForeColor = SystemColors.ControlText;
            SensorsName.Location = new Point(187, 6);
            SensorsName.Name = "SensorsName";
            SensorsName.Size = new Size(591, 65);
            SensorsName.TabIndex = 1;
            SensorsName.Text = "---------------------------------------";
            SensorsName.TextAlign = ContentAlignment.MiddleCenter;
            SensorsName.Visible = false;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(992, 12);
            back.Name = "back";
            back.Size = new Size(130, 70);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // SensorsEngineerModePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(back);
            Controls.Add(SensorsName);
            Controls.Add(SensorsPicture);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "SensorsEngineerModePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += SensorsEngineerModePage_FormClosing;
            Load += SensorsEngineerModePage_Load;
            KeyDown += SensorsEngineerModePage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)SensorsPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox SensorsPicture;
        private Label SensorsName;
        private Button back;
    }
}