namespace TM_Simulator.Menu.Settings
{
    partial class SystemSettings
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
            combineType = new ComboBox();
            harvesterType = new ComboBox();
            engineType = new ComboBox();
            fuelSensor = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            DefaultSettingsbutton = new Button();
            button2 = new Button();
            button3 = new Button();
            ChangePassword1 = new Button();
            ChangePassword2 = new Button();
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
            // combineType
            // 
            combineType.DropDownHeight = 102;
            combineType.DropDownStyle = ComboBoxStyle.DropDownList;
            combineType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            combineType.FormattingEnabled = true;
            combineType.IntegralHeight = false;
            combineType.ItemHeight = 25;
            combineType.Items.AddRange(new object[] { "тест", "GS10 2011", "GS12 2011", "GS812 2011", "GS812c", "GS812 коп", "GS812 STG", "GS812 STG коп", "GS12 STG", "GS12 Cummins", "GS4118", "GS3219", "GH-200" });
            combineType.Location = new Point(23, 206);
            combineType.MaxDropDownItems = 7;
            combineType.MaxLength = 7;
            combineType.Name = "combineType";
            combineType.Size = new Size(230, 33);
            combineType.TabIndex = 4;
            combineType.SelectedIndexChanged += CombineType_SelectedIndexChanged;
            // 
            // harvesterType
            // 
            harvesterType.DropDownHeight = 102;
            harvesterType.DropDownStyle = ComboBoxStyle.DropDownList;
            harvesterType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            harvesterType.FormattingEnabled = true;
            harvesterType.IntegralHeight = false;
            harvesterType.ItemHeight = 25;
            harvesterType.Items.AddRange(new object[] { "1.0 метров", "1.1 метров", "1.2 метров", "1.3 метров", "1.4 метров", "1.5 метров", "1.6 метров", "1.7 метров", "1.8 метров", "1.9 метров", "2.0 метров", "2.1 метров", "2.2 метров", "2.3 метров", "2.4 метров", "2.5 метров", "2.6 метров", "2.6 метров", "2.7 метров", "2.8 метров", "2.9 метров", "3.0 метров", "3.1 метров", "3.2 метров", "3.3 метров", "3.4 метров", "3.5 метров", "3.6 метров", "3.7 метров", "3.8 метров", "3.9 метров", "4.0 метров", "4.1 метров", "4.2 метров", "4.3 метров", "4.4 метров", "4.5 метров", "4.6 метров", "4.7 метров", "4.8 метров", "4.9 метров", "5.0 метров", "5.1 метров", "5.2 метров", "5.3 метров", "5.4 метров", "5.5 метров", "5.6 метров", "5.7 метров", "5.8 метров", "5.9 метров", "6.0 метров", "6.1 метров", "6.2 метров", "6.3 метров", "6.4 метров", "6.5 метров", "6.6 метров", "6.7 метров", "6.8 метров", "6.9 метров", "7.0 метров", "7.1 метров", "7.2 метров", "7.3 метров", "7.4 метров", "7.5 метров", "7.6 метров", "7.7 метров", "7.8 метров", "6.9 метров", "7.0 метров", "7.1 метров", "7.2 метров", "7.3 метров", "7.4 метров", "7.5 метров", "7.6 метров", "7.7 метров", "7.8 метров", "7.9 метров", "8.0 метров", "8.1 метров", "8.2 метров", "8.3 метров", "8.4 метров", "8.5 метров", "8.6 метров", "8.7 метров", "8.8 метров", "8.9 метров", "9.0 метров", "9.1 метров", "9.2 метров", "9.3 метров", "9.4 метров", "9.5 метров", "9.6 метров", "9.7 метров", "9.8 метров", "10.9 метров", "10.0 метров", "10.1 метров", "10.2 метров", "10.3 метров", "10.4 метров", "10.5 метров", "10.6 метров", "10.7 метров", "10.8 метров", "10.9 метров", "11.0 метров", "11.1 метров", "11.2 метров", "11.3 метров", "11.4 метров", "11.5 метров", "11.6 метров", "11.7 метров", "11.8 метров", "11.9 метров", "12.0 метров" });
            harvesterType.Location = new Point(22, 297);
            harvesterType.MaxLength = 7;
            harvesterType.Name = "harvesterType";
            harvesterType.Size = new Size(231, 33);
            harvesterType.TabIndex = 5;
            harvesterType.SelectedIndexChanged += HarvesterType_SelectedIndexChanged;
            // 
            // engineType
            // 
            engineType.DropDownHeight = 102;
            engineType.DropDownStyle = ComboBoxStyle.DropDownList;
            engineType.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            engineType.FormattingEnabled = true;
            engineType.IntegralHeight = false;
            engineType.Items.AddRange(new object[] { "Без электронного управления", "С электронным управлением", "Stage 5" });
            engineType.Location = new Point(559, 203);
            engineType.MaxLength = 7;
            engineType.Name = "engineType";
            engineType.Size = new Size(462, 33);
            engineType.TabIndex = 6;
            engineType.SelectedIndexChanged += EngineType_SelectedIndexChanged;
            // 
            // fuelSensor
            // 
            fuelSensor.DropDownHeight = 102;
            fuelSensor.DropDownStyle = ComboBoxStyle.DropDownList;
            fuelSensor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fuelSensor.FormattingEnabled = true;
            fuelSensor.IntegralHeight = false;
            fuelSensor.Items.AddRange(new object[] { "Резистивный", "Емкостной" });
            fuelSensor.Location = new Point(559, 375);
            fuelSensor.MaxLength = 7;
            fuelSensor.Name = "fuelSensor";
            fuelSensor.Size = new Size(462, 33);
            fuelSensor.TabIndex = 7;
            fuelSensor.SelectedIndexChanged += FuelSensor_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(368, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 33);
            textBox1.TabIndex = 8;
            textBox1.Text = "0000";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(368, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 33);
            textBox2.TabIndex = 9;
            textBox2.Text = "010";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(368, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 33);
            textBox3.TabIndex = 10;
            textBox3.Text = "060";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(368, 445);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 33);
            textBox4.TabIndex = 11;
            textBox4.Text = "240";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(89, 445);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(96, 33);
            textBox5.TabIndex = 12;
            textBox5.Text = "0864";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(921, 250);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 33);
            textBox6.TabIndex = 13;
            textBox6.Text = "0459";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(921, 292);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 33);
            textBox7.TabIndex = 14;
            textBox7.Text = "0880";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // DefaultSettingsbutton
            // 
            DefaultSettingsbutton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DefaultSettingsbutton.Location = new Point(559, 433);
            DefaultSettingsbutton.Name = "DefaultSettingsbutton";
            DefaultSettingsbutton.Size = new Size(462, 45);
            DefaultSettingsbutton.TabIndex = 15;
            DefaultSettingsbutton.Text = "Сброс до заводских установок";
            DefaultSettingsbutton.UseVisualStyleBackColor = true;
            DefaultSettingsbutton.Click += DefaultSettingsbutton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(19, 521);
            button2.Name = "button2";
            button2.Size = new Size(301, 45);
            button2.TabIndex = 16;
            button2.Text = "Сброс суммарных значений";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(326, 521);
            button3.Name = "button3";
            button3.Size = new Size(326, 45);
            button3.TabIndex = 17;
            button3.Text = "Сброс аварийной статистики";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ChangePassword1
            // 
            ChangePassword1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ChangePassword1.Location = new Point(658, 521);
            ChangePassword1.Name = "ChangePassword1";
            ChangePassword1.Size = new Size(225, 45);
            ChangePassword1.TabIndex = 18;
            ChangePassword1.Text = "Смена пароля 1";
            ChangePassword1.UseVisualStyleBackColor = true;
            ChangePassword1.Click += ChangePassword1_Click;
            // 
            // ChangePassword2
            // 
            ChangePassword2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ChangePassword2.Location = new Point(889, 521);
            ChangePassword2.Name = "ChangePassword2";
            ChangePassword2.Size = new Size(225, 45);
            ChangePassword2.TabIndex = 19;
            ChangePassword2.Text = "Смена пароля 2";
            ChangePassword2.UseVisualStyleBackColor = true;
            ChangePassword2.Click += ChangePassword2_Click;
            // 
            // SystemSettings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.systemsettings;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(ChangePassword2);
            Controls.Add(ChangePassword1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DefaultSettingsbutton);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(fuelSensor);
            Controls.Add(engineType);
            Controls.Add(harvesterType);
            Controls.Add(combineType);
            Controls.Add(date);
            Controls.Add(time);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "SystemSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += SystemSettings_FormClosing;
            Load += SystemSettings_Load;
            KeyDown += SystemSettings_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label time;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private ComboBox combineType;
        private ComboBox harvesterType;
        private ComboBox engineType;
        private ComboBox fuelSensor;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button DefaultSettingsbutton;
        private Button button2;
        private Button button3;
        private Button ChangePassword1;
        private Button ChangePassword2;
    }
}