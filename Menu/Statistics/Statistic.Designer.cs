﻿namespace TM_Simulator
{
    partial class Statistic
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
            zerostatus = new Button();
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label21 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(10, 10);
            back.MaximumSize = new Size(130, 70);
            back.MinimumSize = new Size(130, 70);
            back.Name = "back";
            back.Size = new Size(130, 70);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // zerostatus
            // 
            zerostatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            zerostatus.Location = new Point(732, 518);
            zerostatus.MaximumSize = new Size(355, 40);
            zerostatus.MinimumSize = new Size(355, 40);
            zerostatus.Name = "zerostatus";
            zerostatus.Size = new Size(355, 40);
            zerostatus.TabIndex = 1;
            zerostatus.Text = "Обнулить текущие показатели";
            zerostatus.UseVisualStyleBackColor = true;
            zerostatus.Click += zerostatus_Click;
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
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(964, 275);
            label22.Name = "label22";
            label22.Size = new Size(60, 40);
            label22.TabIndex = 4;
            label22.Text = "10";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(964, 332);
            label23.Name = "label23";
            label23.Size = new Size(60, 40);
            label23.TabIndex = 4;
            label23.Text = "10";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(964, 387);
            label24.Name = "label24";
            label24.Size = new Size(60, 40);
            label24.TabIndex = 4;
            label24.Text = "10";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(964, 219);
            label21.Name = "label21";
            label21.Size = new Size(60, 40);
            label21.TabIndex = 4;
            label21.Text = "10";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(825, 387);
            label14.Name = "label14";
            label14.Size = new Size(60, 40);
            label14.TabIndex = 5;
            label14.Text = "10";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(825, 332);
            label13.Name = "label13";
            label13.Size = new Size(60, 40);
            label13.TabIndex = 6;
            label13.Text = "10";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(825, 219);
            label11.Name = "label11";
            label11.Size = new Size(60, 40);
            label11.TabIndex = 7;
            label11.Text = "10";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(825, 275);
            label12.Name = "label12";
            label12.Size = new Size(60, 40);
            label12.TabIndex = 8;
            label12.Text = "10";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.statistic;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(zerostatus);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += Statistic_FormClosing;
            Load += Statistic_Load;
            KeyUp += Statistic_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Button zerostatus;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label21;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label12;
    }
}