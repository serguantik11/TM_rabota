﻿namespace TM_Simulator
{
    partial class StatisticData
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
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += backmenu_Click;
            // 
            // StatisticData
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.statisticdata;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(723, 441);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(739, 480);
            MinimumSize = new Size(739, 480);
            Name = "StatisticData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticData";
            FormClosing += StatisticData_FormClosing;
            KeyUp += StatisticData_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}