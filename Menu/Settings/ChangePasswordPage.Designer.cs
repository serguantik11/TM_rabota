namespace TM_Simulator.Menu.Settings
{
    partial class ChangePasswordPage
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
            label1 = new Label();
            label2 = new Label();
            CancelBtn = new Button();
            SaveBtn = new Button();
            oldPassword = new TextBox();
            newPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите старый пароль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 131);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите новый пароль";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(12, 220);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 35);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(146, 220);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(125, 35);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // oldPassword
            // 
            oldPassword.BackColor = Color.White;
            oldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            oldPassword.Location = new Point(92, 72);
            oldPassword.MaxLength = 4;
            oldPassword.Name = "oldPassword";
            oldPassword.Size = new Size(100, 29);
            oldPassword.TabIndex = 4;
            oldPassword.Text = "0000";
            oldPassword.TextAlign = HorizontalAlignment.Center;
            oldPassword.KeyPress += oldPassword_KeyPress;
            // 
            // newPassword
            // 
            newPassword.BackColor = Color.White;
            newPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newPassword.Location = new Point(92, 169);
            newPassword.MaxLength = 4;
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(100, 29);
            newPassword.TabIndex = 5;
            newPassword.Text = "0000";
            newPassword.TextAlign = HorizontalAlignment.Center;
            newPassword.KeyPress += newPassword_KeyPress;
            // 
            // ChangePasswordPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(284, 261);
            ControlBox = false;
            Controls.Add(newPassword);
            Controls.Add(oldPassword);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "ChangePasswordPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                Смена пароля 1";
            Load += ChangePasswordPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CancelBtn;
        private Button SaveBtn;
        private TextBox oldPassword;
        private TextBox newPassword;
    }
}