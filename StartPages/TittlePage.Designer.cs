namespace TM_Simulator
{
    partial class TittlePage
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
            menu = new Button();
            tittletimer = new System.Windows.Forms.Timer(components);
            time = new Label();
            date = new Label();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menu.Location = new Point(509, 11);
            menu.Margin = new Padding(2);
            menu.Name = "menu";
            menu.Size = new Size(130, 62);
            menu.TabIndex = 1;
            menu.Text = "меню";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // tittletimer
            // 
            tittletimer.Enabled = true;
            tittletimer.Tick += timer1_Tick;
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
            // TittlePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.MainScreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "TittlePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += Form2_FormClosing;
            Load += TittlePage_Load;
            Click += TittlePage_Click;
            KeyUp += TittlePage_KeyUp;
            ResumeLayout(false);
        }

        #endregion
        private Button menu;
        private Label time;
        private Label date;
        public System.Windows.Forms.Timer tittletimer;
    }
}