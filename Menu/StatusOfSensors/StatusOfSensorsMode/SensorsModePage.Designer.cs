namespace TM_Simulator.Menu.StatusOfSensors.StatusOfSensorsMode
{
    partial class SensorsModePage
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
            buttonOfControl = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(10, 420);
            back.MaximumSize = new Size(375, 35);
            back.MinimumSize = new Size(375, 35);
            back.Name = "back";
            back.Size = new Size(375, 35);
            back.TabIndex = 0;
            back.Text = "ESC. НАЗАД";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // buttonOfControl
            // 
            buttonOfControl.Location = new Point(400, 420);
            buttonOfControl.MaximumSize = new Size(375, 35);
            buttonOfControl.MinimumSize = new Size(375, 35);
            buttonOfControl.Name = "buttonOfControl";
            buttonOfControl.Size = new Size(375, 35);
            buttonOfControl.TabIndex = 1;
            buttonOfControl.Text = " ";
            buttonOfControl.UseVisualStyleBackColor = true;
            buttonOfControl.Click += buttonOfControl_Click;
            // 
            // SensorsModePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(buttonOfControl);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "SensorsModePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += SensorsMode_FormClosing;
            Load += SensorsMode_Load;
            KeyUp += SensorsMode_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button buttonOfControl;
    }
}