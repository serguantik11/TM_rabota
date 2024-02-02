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
            panelBtn = new Panel();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(7, 8);
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
            // SensorName
            // 
            SensorName.BackColor = Color.White;
            SensorName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SensorName.Location = new Point(65, 80);
            SensorName.Name = "SensorName";
            SensorName.Size = new Size(1024, 31);
            SensorName.TabIndex = 1;
            SensorName.Text = "       ";
            // 
            // PageName
            // 
            PageName.BackColor = Color.Transparent;
            PageName.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            PageName.ForeColor = Color.Black;
            PageName.Location = new Point(191, 16);
            PageName.Name = "PageName";
            PageName.Size = new Size(735, 49);
            PageName.TabIndex = 2;
            PageName.Text = "СОСТОЯНИЕ ДАТЧИКОВ";
            PageName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EngineerModeBtn
            // 
            EngineerModeBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EngineerModeBtn.ForeColor = SystemColors.ControlText;
            EngineerModeBtn.Location = new Point(993, 8);
            EngineerModeBtn.Name = "EngineerModeBtn";
            EngineerModeBtn.Size = new Size(130, 70);
            EngineerModeBtn.TabIndex = 3;
            EngineerModeBtn.Text = "ENGINEER MODE";
            EngineerModeBtn.UseVisualStyleBackColor = true;
            EngineerModeBtn.Click += EngineerModeBtn_Click;
            // 
            // panelBtn
            // 
            panelBtn.Location = new Point(0, 0);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(1134, 682);
            panelBtn.TabIndex = 4;
            panelBtn.Paint += PanelBtn_Paint;
            // 
            // StatusOfSensorsMode
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(EngineerModeBtn);
            Controls.Add(PageName);
            Controls.Add(SensorName);
            Controls.Add(back);
            Controls.Add(panelBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(1150, 720);
            MinimizeBox = false;
            MinimumSize = new Size(1150, 720);
            Name = "StatusOfSensorsMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += StatusOfSensors_FormClosing;
            Load += StatusOfSensorsMode_Load;
            KeyDown += StatusOfSensors_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Label SensorName;
        private Label PageName;
        private Button EngineerModeBtn;
        private Panel panelBtn;
    }
}