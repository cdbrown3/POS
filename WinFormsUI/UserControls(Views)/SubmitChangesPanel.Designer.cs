namespace WinFormsUI
{
    partial class SubmitChangesPanel
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
            panel2 = new Panel();
            SubmitChangesButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(SubmitChangesButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 60);
            panel2.TabIndex = 18;
            // 
            // SubmitChangesButton
            // 
            SubmitChangesButton.BackColor = Color.FromArgb(129, 84, 54);
            SubmitChangesButton.FlatStyle = FlatStyle.Flat;
            SubmitChangesButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SubmitChangesButton.Location = new Point(12, 12);
            SubmitChangesButton.Margin = new Padding(2);
            SubmitChangesButton.Name = "SubmitChangesButton";
            SubmitChangesButton.Size = new Size(239, 37);
            SubmitChangesButton.TabIndex = 20;
            SubmitChangesButton.Text = "Submit Changes";
            SubmitChangesButton.UseVisualStyleBackColor = false;
            SubmitChangesButton.Click += SumbitChangesButton_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Location = new Point(50, 80);
            Name = "UserControl3";
            Size = new Size(265, 60);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button SubmitChangesButton;
    }
}
