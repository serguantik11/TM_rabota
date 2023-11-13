namespace TM_Simulator
{
    partial class Settings
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
            combinesettings = new Button();
            systemsettings2 = new Button();
            terminalsettings = new Button();
            operatingmode = new Button();
            systemsettings = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2, 2, 2, 2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
            back.TabIndex = 0;
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // combinesettings
            // 
            combinesettings.Location = new Point(20, 298);
            combinesettings.Margin = new Padding(2, 2, 2, 2);
            combinesettings.MaximumSize = new Size(680, 40);
            combinesettings.MinimumSize = new Size(680, 40);
            combinesettings.Name = "combinesettings";
            combinesettings.Size = new Size(680, 40);
            combinesettings.TabIndex = 1;
            combinesettings.Text = "Настройки комбайна";
            combinesettings.UseVisualStyleBackColor = true;
            combinesettings.Click += combinesettings_Click;
            // 
            // systemsettings2
            // 
            systemsettings2.Location = new Point(20, 255);
            systemsettings2.Margin = new Padding(2, 2, 2, 2);
            systemsettings2.MaximumSize = new Size(680, 40);
            systemsettings2.MinimumSize = new Size(680, 40);
            systemsettings2.Name = "systemsettings2";
            systemsettings2.Size = new Size(680, 40);
            systemsettings2.TabIndex = 1;
            systemsettings2.Text = "Настройки системы 2";
            systemsettings2.UseVisualStyleBackColor = true;
            // 
            // terminalsettings
            // 
            terminalsettings.Location = new Point(20, 213);
            terminalsettings.Margin = new Padding(2, 2, 2, 2);
            terminalsettings.MaximumSize = new Size(680, 40);
            terminalsettings.Name = "terminalsettings";
            terminalsettings.Size = new Size(680, 40);
            terminalsettings.TabIndex = 1;
            terminalsettings.Text = "Настройки терминала";
            terminalsettings.UseVisualStyleBackColor = true;
            // 
            // operatingmode
            // 
            operatingmode.Location = new Point(20, 170);
            operatingmode.Margin = new Padding(2, 2, 2, 2);
            operatingmode.MaximumSize = new Size(680, 40);
            operatingmode.MinimumSize = new Size(680, 40);
            operatingmode.Name = "operatingmode";
            operatingmode.Size = new Size(680, 40);
            operatingmode.TabIndex = 1;
            operatingmode.Text = "Режим работы";
            operatingmode.UseVisualStyleBackColor = true;
            // 
            // systemsettings
            // 
            systemsettings.Location = new Point(20, 127);
            systemsettings.Margin = new Padding(2, 2, 2, 2);
            systemsettings.MaximumSize = new Size(680, 40);
            systemsettings.MinimumSize = new Size(680, 40);
            systemsettings.Name = "systemsettings";
            systemsettings.Size = new Size(680, 40);
            systemsettings.TabIndex = 1;
            systemsettings.Text = "Настройки системы";
            systemsettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(574, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 2;
            label1.Text = "время";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 3;
            label2.Text = "дата";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(723, 441);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(systemsettings);
            Controls.Add(operatingmode);
            Controls.Add(terminalsettings);
            Controls.Add(systemsettings2);
            Controls.Add(combinesettings);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(739, 480);
            MinimumSize = new Size(739, 480);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosing += Settings_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button combinesettings;
        private Button systemsettings2;
        private Button terminalsettings;
        private Button operatingmode;
        private Button systemsettings;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}