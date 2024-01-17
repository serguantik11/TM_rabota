namespace TM_Simulator.Menu
{
    partial class CopyPage
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
            Final = new Label();
            time = new Label();
            date = new Label();
            back = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            FinalError = new Label();
            NamePage = new Label();
            SuspendLayout();
            // 
            // Final
            // 
            Final.BackColor = Color.White;
            Final.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Final.ForeColor = Color.Lime;
            Final.Location = new Point(221, 249);
            Final.Name = "Final";
            Final.Size = new Size(344, 26);
            Final.TabIndex = 0;
            Final.Text = "Данные скопированы успешно!";
            Final.TextAlign = ContentAlignment.MiddleCenter;
            Final.Visible = false;
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
            // back
            // 
            back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += Back_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(49, 152);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(689, 43);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 5;
            // 
            // FinalError
            // 
            FinalError.BackColor = Color.White;
            FinalError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FinalError.ForeColor = Color.Lime;
            FinalError.Location = new Point(221, 277);
            FinalError.Name = "FinalError";
            FinalError.Size = new Size(344, 26);
            FinalError.TabIndex = 0;
            FinalError.Text = "Ошибка";
            FinalError.TextAlign = ContentAlignment.MiddleCenter;
            FinalError.Visible = false;
            // 
            // NamePage
            // 
            NamePage.BackColor = Color.White;
            NamePage.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            NamePage.Location = new Point(102, 83);
            NamePage.Name = "NamePage";
            NamePage.Size = new Size(577, 37);
            NamePage.TabIndex = 6;
            NamePage.Text = "КОПИРОВАНИЕ ДАННЫХ";
            NamePage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CopyPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.CopyMenuImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(NamePage);
            Controls.Add(progressBar1);
            Controls.Add(back);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(FinalError);
            Controls.Add(Final);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "CopyPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += CopyMenu_FormClosing;
            Load += CopyMenu_Load;
            KeyDown += CopyMenu_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Final;
        private Label time;
        private Label date;
        private Button back;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label FinalError;
        private Label NamePage;
    }
}