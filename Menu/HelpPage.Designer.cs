namespace TM_Simulator
{
    partial class HelpPage
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
            pictureBox = new PictureBox();
            label1 = new Label();
            page = new Label();
            buttonUp = new Button();
            buttonDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(13, 4);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(130, 70);
            back.MinimumSize = new Size(130, 70);
            back.Name = "back";
            back.Size = new Size(130, 70);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += backmenu_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Image = Properties.Resources.help1;
            pictureBox.Location = new Point(-5, 76);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1112, 612);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.MouseWheel += pictureBox_MouseWheel;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(339, 9);
            label1.Name = "label1";
            label1.Size = new Size(464, 64);
            label1.TabIndex = 3;
            label1.Text = "ПОМОЩЬ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page
            // 
            page.AutoSize = true;
            page.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            page.Location = new Point(1020, 29);
            page.Name = "page";
            page.Size = new Size(85, 25);
            page.TabIndex = 4;
            page.Text = "Стр. 1/6";
            // 
            // buttonUp
            // 
            buttonUp.BackgroundImage = Properties.Resources.buttonUp;
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Cursor = Cursors.PanNorth;
            buttonUp.Location = new Point(1099, 80);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 5;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.BackgroundImage = Properties.Resources.buttonDown;
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Cursor = Cursors.PanSouth;
            buttonDown.Location = new Point(1099, 645);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 6;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // HelpPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScrollMargin = new Size(0, 500);
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(page);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "HelpPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += HelpPage_FormClosing;
            KeyUp += HelpPage_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private PictureBox pictureBox;
        private Label label1;
        private Label page;
        private Button buttonUp;
        private Button buttonDown;
    }
}