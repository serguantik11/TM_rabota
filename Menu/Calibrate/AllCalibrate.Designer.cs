namespace TM_Simulator.Menu.Calibrate
{
    partial class AllCalibrate
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
            time = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            savemin = new Button();
            savemax = new Button();
            saveAll = new Button();
            minvalue = new Label();
            maxvalue = new Label();
            currentvaluecalibratepage = new Label();
            minus = new Button();
            plus = new Button();
            namepage = new Label();
            SuspendLayout();
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
            back.Click += back_Click;
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // savemin
            // 
            savemin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            savemin.Location = new Point(20, 270);
            savemin.Name = "savemin";
            savemin.Size = new Size(360, 40);
            savemin.TabIndex = 3;
            savemin.Text = "Запомнить как минимум";
            savemin.UseVisualStyleBackColor = true;
            savemin.Click += savemin_Click;
            // 
            // savemax
            // 
            savemax.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            savemax.Location = new Point(400, 270);
            savemax.Name = "savemax";
            savemax.Size = new Size(360, 40);
            savemax.TabIndex = 4;
            savemax.Text = "Запомнить как максимум";
            savemax.UseVisualStyleBackColor = true;
            savemax.Click += savemax_Click;
            // 
            // saveAll
            // 
            saveAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveAll.Location = new Point(20, 360);
            saveAll.Name = "saveAll";
            saveAll.Size = new Size(740, 40);
            saveAll.TabIndex = 5;
            saveAll.Text = "Сохранить калибровочные значения";
            saveAll.UseVisualStyleBackColor = true;
            saveAll.Click += saveAll_Click;
            // 
            // minvalue
            // 
            minvalue.AutoSize = true;
            minvalue.BackColor = Color.Transparent;
            minvalue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            minvalue.Location = new Point(482, 145);
            minvalue.Name = "minvalue";
            minvalue.Size = new Size(54, 21);
            minvalue.TabIndex = 6;
            minvalue.Text = "label3";
            // 
            // maxvalue
            // 
            maxvalue.AutoSize = true;
            maxvalue.BackColor = Color.Transparent;
            maxvalue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maxvalue.Location = new Point(482, 176);
            maxvalue.Name = "maxvalue";
            maxvalue.Size = new Size(54, 21);
            maxvalue.TabIndex = 7;
            maxvalue.Text = "label4";
            // 
            // currentvaluecalibratepage
            // 
            currentvaluecalibratepage.AutoSize = true;
            currentvaluecalibratepage.BackColor = Color.Transparent;
            currentvaluecalibratepage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            currentvaluecalibratepage.Location = new Point(487, 232);
            currentvaluecalibratepage.Name = "currentvaluecalibratepage";
            currentvaluecalibratepage.Size = new Size(54, 21);
            currentvaluecalibratepage.TabIndex = 8;
            currentvaluecalibratepage.Text = "label5";
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            minus.Location = new Point(437, 226);
            minus.Name = "minus";
            minus.Size = new Size(26, 27);
            minus.TabIndex = 9;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            plus.Location = new Point(565, 226);
            plus.Name = "plus";
            plus.Size = new Size(27, 27);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // namepage
            // 
            namepage.AutoSize = true;
            namepage.BackColor = Color.Transparent;
            namepage.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            namepage.Location = new Point(227, 70);
            namepage.Name = "namepage";
            namepage.Size = new Size(333, 37);
            namepage.TabIndex = 11;
            namepage.Text = "ЗАЗОР ПОДБАРАБАНЬЯ";
            // 
            // AllCalibrate
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.drumminggap;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(namepage);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(currentvaluecalibratepage);
            Controls.Add(maxvalue);
            Controls.Add(minvalue);
            Controls.Add(saveAll);
            Controls.Add(savemax);
            Controls.Add(savemin);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "AllCalibrate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += AllCalibrate_FormClosing;
            Load += AllCalibrate_Load;
            KeyUp += AllCalibrate_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Button savemin;
        private Button savemax;
        private Button saveAll;
        private Label minvalue;
        private Label maxvalue;
        private Label currentvaluecalibratepage;
        private Button minus;
        private Button plus;
        private Label namepage;
    }
}