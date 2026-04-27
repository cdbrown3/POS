using POS.Backend;

namespace WinFormsUI
{
    partial class MainLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginWindow));
            EmployeeView_button = new Button();
            PasswordTextBox = new TextBox();
            ManagerViewButton = new Button();
            SuspendLayout();
            // 
            // EmployeeView_button
            // 
            EmployeeView_button.BackColor = Color.FromArgb(129, 84, 54);
            EmployeeView_button.FlatStyle = FlatStyle.Flat;
            EmployeeView_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmployeeView_button.Location = new Point(523, 281);
            EmployeeView_button.Margin = new Padding(2);
            EmployeeView_button.Name = "EmployeeView_button";
            EmployeeView_button.Size = new Size(102, 37);
            EmployeeView_button.TabIndex = 0;
            EmployeeView_button.Text = "Employee";
            EmployeeView_button.UseVisualStyleBackColor = false;
            EmployeeView_button.Click += EmployeeViewButton_click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(523, 227);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(239, 39);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Text = "Password";
            PasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ManagerViewButton
            // 
            ManagerViewButton.BackColor = Color.FromArgb(129, 84, 54);
            ManagerViewButton.FlatStyle = FlatStyle.Flat;
            ManagerViewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ManagerViewButton.Location = new Point(660, 281);
            ManagerViewButton.Margin = new Padding(2);
            ManagerViewButton.Name = "ManagerViewButton";
            ManagerViewButton.Size = new Size(102, 37);
            ManagerViewButton.TabIndex = 2;
            ManagerViewButton.Text = "Manager";
            ManagerViewButton.UseVisualStyleBackColor = false;
            ManagerViewButton.Click += ManagerViewButton_Click;
            // 
            // MainLoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 46);
            ClientSize = new Size(1284, 561);
            Controls.Add(ManagerViewButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmployeeView_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1300, 600);
            Name = "MainLoginWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmployeeView_button;
        private TextBox PasswordTextBox;
        private Button ManagerViewButton;
    }
}
