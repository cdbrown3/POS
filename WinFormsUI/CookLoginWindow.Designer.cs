namespace WinFormsUI
{
    partial class CookLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookLoginWindow));
            PasswordTextBox = new TextBox();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(523, 227);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(239, 39);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.Text = "Password";
            PasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.FromArgb(129, 84, 54);
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SignInButton.Location = new Point(523, 271);
            SignInButton.Margin = new Padding(2);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(239, 32);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // CookLoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 46);
            ClientSize = new Size(1284, 561);
            Controls.Add(SignInButton);
            Controls.Add(PasswordTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 600);
            Name = "CookLoginWindow";
            Text = "CookLoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordTextBox;
        private Button SignInButton;
    }
}