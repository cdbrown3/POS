namespace WinFormsUI
{
    partial class OrderCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel15 = new Panel();
            listBox1 = new ListBox();
            OrderNumButton = new Button();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(28, 30, 46);
            panel15.Controls.Add(listBox1);
            panel15.Controls.Add(OrderNumButton);
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(232, 223);
            panel15.TabIndex = 52;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(28, 30, 46);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 150);
            listBox1.TabIndex = 1;
            // 
            // OrderNumButton
            // 
            OrderNumButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            OrderNumButton.Location = new Point(3, 3);
            OrderNumButton.Name = "OrderNumButton";
            OrderNumButton.Size = new Size(226, 47);
            OrderNumButton.TabIndex = 0;
            OrderNumButton.Text = "Order Number:\r\n";
            OrderNumButton.UseVisualStyleBackColor = true;
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel15);
            Name = "OrderCard";
            Size = new Size(232, 223);
            panel15.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private ListBox listBox1;
        private Button OrderNumButton;
    }
}
