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
            comboBox1.DropDownHeight = 102;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "выкл.", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            comboBox1.Location = new Point(344, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 38);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownHeight = 102;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.Items.AddRange(new object[] { "выкл.", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105" });
            comboBox2.Location = new Point(344, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(137, 38);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.DropDownHeight = 102;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.IntegralHeight = false;
            comboBox3.Items.AddRange(new object[] { "Резистивный", "Резестивный Stage V", "Резистивный Cummins", "Электронный" });
            comboBox3.Location = new Point(560, 201);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(343, 38);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            // 
            // SystemSettings2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.settings2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(back);
            Controls.Add(date);
            Controls.Add(time);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "SystemSettings2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += SystemSettings2_FormClosing;
            Load += SystemSettings2_Load;
            KeyDown += SystemSettings2_KeyDown;
            ResumeLayout(false);
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