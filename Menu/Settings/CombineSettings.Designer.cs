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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.Items.AddRange(new object[] { "обычный", "понижающий" });
            comboBox1.Location = new Point(11, 135);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CombineSettings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.combinesettings;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            Controls.Add(comboBox1);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "CombineSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += combset_FormClosing;
            Load += combset_Load;
            KeyUp += CombineSettings_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private ComboBox comboBox1;
    }
}