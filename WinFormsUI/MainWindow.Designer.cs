namespace WinFormsUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            MainPanel = new Panel();
            LeftDockPanel = new Panel();
            richTextBox1 = new RichTextBox();
            ButtonsPanel = new Panel();
            ExitButton = new PictureBox();
            LeftDockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitButton).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(234, 232, 233);
            MainPanel.Location = new Point(297, 43);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(975, 496);
            MainPanel.TabIndex = 2;
            // 
            // LeftDockPanel
            // 
            LeftDockPanel.BackColor = Color.FromArgb(234, 232, 233);
            LeftDockPanel.Controls.Add(richTextBox1);
            LeftDockPanel.Location = new Point(0, 0);
            LeftDockPanel.Name = "LeftDockPanel";
            LeftDockPanel.Size = new Size(265, 504);
            LeftDockPanel.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1123, 372);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.FromArgb(234, 232, 233);
            ButtonsPanel.Location = new Point(0, 502);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(265, 60);
            ButtonsPanel.TabIndex = 4;
            // 
            // ExitButton
            // 
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(1237, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(68, 37);
            ExitButton.TabIndex = 5;
            ExitButton.TabStop = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 46);
            ClientSize = new Size(1284, 561);
            Controls.Add(ExitButton);
            Controls.Add(ButtonsPanel);
            Controls.Add(LeftDockPanel);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 600);
            Name = "Form2";
            Text = "Form2";
            LeftDockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExitButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel LeftDockPanel;
        private RichTextBox richTextBox1;
        private Panel ButtonsPanel;
        private PictureBox ExitButton;
    }
}