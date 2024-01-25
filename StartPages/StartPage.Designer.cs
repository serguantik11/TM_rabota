namespace TM_Simulator
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.start;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1134, 681);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2);
            MaximumSize = new Size(1150, 720);
            MinimumSize = new Size(1150, 720);
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TM_Simulator";
            FormClosing += StartPage_FormClosing;
            Load += StartPage_Load;
            Click += StartPage_Click;
            KeyUp += StartPage_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}