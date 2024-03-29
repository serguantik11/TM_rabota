﻿namespace TM_Simulator.Menu.Statistics
{
    partial class TO
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
            buttonETO = new Button();
            buttonTO1 = new Button();
            buttonTO2 = new Button();
            buttonzero1 = new Button();
            buttonzero2 = new Button();
            buttonzero3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            PageName = new Label();
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
            // buttonETO
            // 
            buttonETO.BackgroundImage = Properties.Resources.TObook;
            buttonETO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonETO.Location = new Point(753, 219);
            buttonETO.Name = "buttonETO";
            buttonETO.Size = new Size(90, 90);
            buttonETO.TabIndex = 1;
            buttonETO.UseVisualStyleBackColor = true;
            buttonETO.Click += buttonETO_Click;
            // 
            // buttonTO1
            // 
            buttonTO1.BackgroundImage = Properties.Resources.TObook;
            buttonTO1.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTO1.Location = new Point(753, 334);
            buttonTO1.Name = "buttonTO1";
            buttonTO1.Size = new Size(90, 90);
            buttonTO1.TabIndex = 2;
            buttonTO1.UseVisualStyleBackColor = true;
            buttonTO1.Click += buttonTO1_Click;
            // 
            // buttonTO2
            // 
            buttonTO2.BackgroundImage = Properties.Resources.TObook;
            buttonTO2.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTO2.Location = new Point(753, 453);
            buttonTO2.Name = "buttonTO2";
            buttonTO2.Size = new Size(90, 90);
            buttonTO2.TabIndex = 3;
            buttonTO2.UseVisualStyleBackColor = true;
            buttonTO2.Click += buttonTO2_Click;
            // 
            // buttonzero1
            // 
            buttonzero1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonzero1.Location = new Point(958, 214);
            buttonzero1.Name = "buttonzero1";
            buttonzero1.Size = new Size(140, 90);
            buttonzero1.TabIndex = 4;
            buttonzero1.Text = "Сбросить";
            buttonzero1.UseVisualStyleBackColor = true;
            buttonzero1.Click += buttonzero1_Click;
            // 
            // buttonzero2
            // 
            buttonzero2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonzero2.Location = new Point(958, 329);
            buttonzero2.Name = "buttonzero2";
            buttonzero2.Size = new Size(140, 90);
            buttonzero2.TabIndex = 5;
            buttonzero2.Text = "Сбросить";
            buttonzero2.UseVisualStyleBackColor = true;
            buttonzero2.Click += buttonzero2_Click;
            // 
            // buttonzero3
            // 
            buttonzero3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonzero3.Location = new Point(958, 453);
            buttonzero3.Name = "buttonzero3";
            buttonzero3.Size = new Size(140, 90);
            buttonzero3.TabIndex = 6;
            buttonzero3.Text = "Сбросить";
            buttonzero3.UseVisualStyleBackColor = true;
            buttonzero3.Click += buttonzero3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(524, 248);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 7;
            label1.Text = "  6 ч.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(521, 361);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 8;
            label2.Text = " 48 ч.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(524, 482);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 9;
            label3.Text = "123 ч.";
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
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(2, 95);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1132, 588);
            textBox1.TabIndex = 10;
            textBox1.Visible = false;
            // 
            // PageName
            // 
            PageName.BackColor = Color.Transparent;
            PageName.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            PageName.Location = new Point(205, 16);
            PageName.Margin = new Padding(0);
            PageName.Name = "PageName";
            PageName.Size = new Size(683, 56);
            PageName.TabIndex = 11;
            PageName.Text = "ТЕХНИЧЕСКОЕ ОБСЛУЖИВАНИЕ";
            PageName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TO
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.TO;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(PageName);
            Controls.Add(textBox1);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonzero3);
            Controls.Add(buttonzero2);
            Controls.Add(buttonzero1);
            Controls.Add(buttonTO2);
            Controls.Add(buttonTO1);
            Controls.Add(buttonETO);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "TO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += TO_FormClosing;
            Load += TO_Load;
            KeyUp += TO_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button buttonETO;
        private Button buttonTO1;
        private Button buttonTO2;
        private Button buttonzero1;
        private Button buttonzero2;
        private Button buttonzero3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label PageName;
    }
}