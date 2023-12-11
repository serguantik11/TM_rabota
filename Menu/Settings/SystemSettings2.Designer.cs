namespace TM_Simulator.Menu.Settings
{
    partial class SystemSettings2
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
            time = new Label();
            date = new Label();
            back = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(624, -4);
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
            date.Location = new Point(616, 32);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(53, 25);
            date.TabIndex = 3;
            date.Text = "дата";
            // 
            // back
            // 
            back.Location = new Point(10, 10);
            back.Margin = new Padding(2);
            back.MaximumSize = new Size(96, 40);
            back.MinimumSize = new Size(96, 40);
            back.Name = "back";
            back.Size = new Size(96, 40);
            back.TabIndex = 0;
            back.Text = "назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "выкл.", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            comboBox1.Location = new Point(236, 173);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "выкл.", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105" });
            comboBox2.Location = new Point(236, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(97, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Резистивный", "Резестивный Stage V", "Резистивный Cummins", "Электронный" });
            comboBox3.Location = new Point(364, 139);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(234, 28);
            comboBox3.TabIndex = 6;
            // 
            // SystemSettings2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.settings2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(back);
            Controls.Add(date);
            Controls.Add(time);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "SystemSettings2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemSettings2";
            FormClosing += SystemSettings2_FormClosing;
            Load += SystemSettings2_Load;
            KeyDown += SystemSettings2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label time;
        private Label date;
        private Button back;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}