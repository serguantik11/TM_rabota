namespace TM_Simulator.Menu.Settings
{
    partial class OperatingMode
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
            modeBox = new ComboBox();
            cultureBox = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            l0 = new Label();
            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();
            l5 = new Label();
            l6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            NameEnter = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            DownText = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            SuspendLayout();
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // modeBox
            // 
            modeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            modeBox.FormattingEnabled = true;
            modeBox.Items.AddRange(new object[] { "Свои", "Рекомендуемые", "Ручной" });
            modeBox.Location = new Point(15, 190);
            modeBox.Name = "modeBox";
            modeBox.Size = new Size(196, 28);
            modeBox.TabIndex = 4;
            modeBox.SelectedIndexChanged += ModeBox_SelectedIndexChanged;
            // 
            // cultureBox
            // 
            cultureBox.DropDownHeight = 85;
            cultureBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cultureBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cultureBox.FormattingEnabled = true;
            cultureBox.IntegralHeight = false;
            cultureBox.Items.AddRange(new object[] { "пшеница", "овес", "люцерна", "гречиха", "кукуруза", "ячмень", "рожь", "клевер", "рапс", "соя", "нут", "подсолнух" });
            cultureBox.Location = new Point(15, 271);
            cultureBox.Name = "cultureBox";
            cultureBox.Size = new Size(196, 28);
            cultureBox.TabIndex = 5;
            cultureBox.SelectedIndexChanged += CultureBox_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "по времени", "по площади" });
            comboBox3.Location = new Point(16, 328);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(195, 28);
            comboBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(425, 135);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(425, 168);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(425, 201);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 9;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 233);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 10;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(425, 265);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 11;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(425, 304);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 12;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(425, 337);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 13;
            label7.Text = "0";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l0
            // 
            l0.BackColor = Color.White;
            l0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l0.Location = new Point(600, 135);
            l0.Name = "l0";
            l0.Size = new Size(51, 20);
            l0.TabIndex = 7;
            l0.Text = "725";
            l0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l1
            // 
            l1.BackColor = Color.White;
            l1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l1.Location = new Point(600, 168);
            l1.Name = "l1";
            l1.Size = new Size(51, 20);
            l1.TabIndex = 8;
            l1.Text = "5";
            l1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l2
            // 
            l2.BackColor = Color.White;
            l2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l2.Location = new Point(600, 201);
            l2.Name = "l2";
            l2.Size = new Size(51, 20);
            l2.TabIndex = 9;
            l2.Text = "725";
            l2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l3
            // 
            l3.BackColor = Color.White;
            l3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l3.Location = new Point(600, 233);
            l3.Name = "l3";
            l3.Size = new Size(51, 20);
            l3.TabIndex = 10;
            l3.Text = "12";
            l3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l4
            // 
            l4.BackColor = Color.White;
            l4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l4.Location = new Point(600, 265);
            l4.Name = "l4";
            l4.Size = new Size(51, 20);
            l4.TabIndex = 11;
            l4.Text = "8";
            l4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l5
            // 
            l5.BackColor = Color.White;
            l5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l5.Location = new Point(600, 304);
            l5.Name = "l5";
            l5.Size = new Size(51, 20);
            l5.TabIndex = 12;
            l5.Text = "2";
            l5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l6
            // 
            l6.BackColor = Color.White;
            l6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l6.Location = new Point(600, 337);
            l6.Name = "l6";
            l6.Size = new Size(51, 20);
            l6.TabIndex = 13;
            l6.Text = "2";
            l6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(483, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 27);
            textBox1.TabIndex = 14;
            textBox1.Tag = "0";
            textBox1.Text = "0498";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += AllTextBoxEnter;
            textBox1.Leave += AllTextBoxLeave;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(483, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 27);
            textBox2.TabIndex = 14;
            textBox2.Tag = "1";
            textBox2.Text = "0005";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Enter += AllTextBoxEnter;
            textBox2.Leave += AllTextBoxLeave;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(483, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(69, 27);
            textBox3.TabIndex = 14;
            textBox3.Tag = "2";
            textBox3.Text = "0498";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Enter += AllTextBoxEnter;
            textBox3.Leave += AllTextBoxLeave;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(483, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(69, 27);
            textBox4.TabIndex = 14;
            textBox4.Tag = "3";
            textBox4.Text = "0012";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Enter += AllTextBoxEnter;
            textBox4.Leave += AllTextBoxLeave;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(483, 262);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(69, 27);
            textBox5.TabIndex = 14;
            textBox5.Tag = "4";
            textBox5.Text = "0008";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Enter += AllTextBoxEnter;
            textBox5.Leave += AllTextBoxLeave;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(483, 300);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(69, 27);
            textBox6.TabIndex = 14;
            textBox6.Tag = "5";
            textBox6.Text = "0002";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.Enter += AllTextBoxEnter;
            textBox6.Leave += AllTextBoxLeave;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(483, 334);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(69, 27);
            textBox7.TabIndex = 14;
            textBox7.Tag = "6";
            textBox7.Text = "0002";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.Enter += AllTextBoxEnter;
            textBox7.Leave += AllTextBoxLeave;
            // 
            // NameEnter
            // 
            NameEnter.BackColor = Color.Transparent;
            NameEnter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NameEnter.ForeColor = Color.DodgerBlue;
            NameEnter.Location = new Point(338, 382);
            NameEnter.Name = "NameEnter";
            NameEnter.Size = new Size(435, 22);
            NameEnter.TabIndex = 15;
            NameEnter.Text = "                  ";
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(713, 135);
            label16.Name = "label16";
            label16.Size = new Size(55, 20);
            label16.TabIndex = 7;
            label16.Text = "ждите";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(713, 168);
            label17.Name = "label17";
            label17.Size = new Size(55, 20);
            label17.TabIndex = 8;
            label17.Text = "ждите";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(713, 201);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 9;
            label18.Text = "ждите";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(713, 233);
            label19.Name = "label19";
            label19.Size = new Size(55, 20);
            label19.TabIndex = 10;
            label19.Text = "ждите";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = Color.White;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(713, 265);
            label20.Name = "label20";
            label20.Size = new Size(55, 20);
            label20.TabIndex = 11;
            label20.Text = "ждите";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(713, 304);
            label21.Name = "label21";
            label21.Size = new Size(55, 20);
            label21.TabIndex = 12;
            label21.Text = "ОК";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(713, 337);
            label22.Name = "label22";
            label22.Size = new Size(55, 20);
            label22.TabIndex = 13;
            label22.Text = "ОК";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DownText
            // 
            DownText.BackColor = Color.Transparent;
            DownText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DownText.Location = new Point(4, 364);
            DownText.Name = "DownText";
            DownText.Size = new Size(773, 34);
            DownText.TabIndex = 16;
            DownText.Text = "Для СТАРТА режима АВТОМАТИЧЕСКОЙ НАСТРОЙКИ рабочих органов на заданную культуру, необходимо поднять обороты двигателя до номинальных и включить МОЛОТИЛКУ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(247, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(247, 339);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "label8";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(247, 161);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(247, 196);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(254, 231);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(250, 265);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 22;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // OperatingMode
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.operatingMode;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 471);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(NameEnter);
            Controls.Add(DownText);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label22);
            Controls.Add(l6);
            Controls.Add(label21);
            Controls.Add(l5);
            Controls.Add(label7);
            Controls.Add(label20);
            Controls.Add(l4);
            Controls.Add(label6);
            Controls.Add(label19);
            Controls.Add(l3);
            Controls.Add(label5);
            Controls.Add(label18);
            Controls.Add(l2);
            Controls.Add(label4);
            Controls.Add(label17);
            Controls.Add(l1);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(l0);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(cultureBox);
            Controls.Add(modeBox);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(800, 510);
            MinimumSize = new Size(800, 510);
            Name = "OperatingMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OperatingMode";
            FormClosing += OperatingMode_FormClosing;
            Load += OperatingMode_Load;
            KeyDown += OperatingMode_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private ComboBox modeBox;
        private ComboBox cultureBox;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label l0;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l5;
        private Label l6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label NameEnter;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label DownText;
        private CheckBox checkBox1;
        private Label label8;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}