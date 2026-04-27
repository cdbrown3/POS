namespace WinFormsUI.UserControls_Views_
{
    partial class ManagerMethodPanel
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
            EditEmployeeButton2 = new Button();
            NewOrderButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(EditEmployeeButton2);
            panel2.Controls.Add(NewOrderButton);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 60);
            panel2.TabIndex = 19;
            // 
            // EditEmployeeButton2
            // 
            EditEmployeeButton2.BackColor = Color.FromArgb(129, 84, 54);
            EditEmployeeButton2.FlatStyle = FlatStyle.Flat;
            EditEmployeeButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditEmployeeButton2.Location = new Point(138, 12);
            EditEmployeeButton2.Margin = new Padding(2);
            EditEmployeeButton2.Name = "EditEmployeeButton2";
            EditEmployeeButton2.Size = new Size(113, 37);
            EditEmployeeButton2.TabIndex = 20;
            EditEmployeeButton2.Text = "Edit Employee";
            EditEmployeeButton2.UseVisualStyleBackColor = false;
            EditEmployeeButton2.Click += EditEmployeeButton2_Click;
            // 
            // NewOrderButton
            // 
            NewOrderButton.BackColor = Color.FromArgb(129, 84, 54);
            NewOrderButton.FlatStyle = FlatStyle.Flat;
            NewOrderButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewOrderButton.Location = new Point(13, 12);
            NewOrderButton.Margin = new Padding(2);
            NewOrderButton.Name = "NewOrderButton";
            NewOrderButton.Size = new Size(102, 37);
            NewOrderButton.TabIndex = 19;
            NewOrderButton.Text = "Archive";
            NewOrderButton.UseVisualStyleBackColor = false;
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UserControl5";
            Size = new Size(271, 67);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button EditEmployeeButton2;
        private Button NewOrderButton;
    }
}
