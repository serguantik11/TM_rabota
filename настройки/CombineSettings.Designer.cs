namespace TM_Simulator
{
    partial class CombineSettings
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(12, 12);
            back.Name = "back";
            back.Size = new Size(120, 50);
            back.TabIndex = 0;
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "обычный", "понижающий" });
            comboBox1.Location = new Point(12, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 1;
            // 
            // CombineSettings
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.combinesettings;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 543);
            Controls.Add(comboBox1);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(920, 590);
            MinimumSize = new Size(920, 590);
            Name = "CombineSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "combset";
            FormClosing += combset_FormClosing;
            Load += combset_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private ComboBox comboBox1;
    }
}