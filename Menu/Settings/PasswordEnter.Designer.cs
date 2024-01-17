namespace TM_Simulator.Menu.Settings
{
    partial class PasswordEnter
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
            PasswordField = new TextBox();
            CancelBtn = new Button();
            OkBtn = new Button();
            SuspendLayout();
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(87, 25);
            PasswordField.MaxLength = 4;
            PasswordField.Multiline = true;
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(105, 31);
            PasswordField.TabIndex = 0;
            PasswordField.Text = "0000";
            PasswordField.TextAlign = HorizontalAlignment.Center;
            PasswordField.KeyPress += PasswordField_KeyPress;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.Location = new Point(12, 77);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(115, 35);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "ОТМЕНА";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // OkBtn
            // 
            OkBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OkBtn.Location = new Point(152, 77);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(115, 35);
            OkBtn.TabIndex = 2;
            OkBtn.Text = "ОК";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // PasswordEnter
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(279, 122);
            ControlBox = false;
            Controls.Add(OkBtn);
            Controls.Add(CancelBtn);
            Controls.Add(PasswordField);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "PasswordEnter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                         Введите пароль";
            Load += PasswordEnter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordField;
        private Button CancelBtn;
        private Button OkBtn;
    }
}