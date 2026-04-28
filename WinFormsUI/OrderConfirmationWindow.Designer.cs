namespace WinFormsUI
{
    partial class OrderConfirmationWindow
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
            CloseButton = new Button();
            TotalTextBox = new TextBox();
            OrderNumTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 48);
            label1.TabIndex = 0;
            label1.Text = "Total: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(252, 48);
            label2.TabIndex = 1;
            label2.Text = "OrderNumber:";
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Segoe UI", 18F);
            CloseButton.Location = new Point(5, 121);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(580, 60);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "CLOSE";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // TotalTextBox
            // 
            TotalTextBox.BackColor = Color.FromArgb(234, 232, 233);
            TotalTextBox.BorderStyle = BorderStyle.None;
            TotalTextBox.Font = new Font("Segoe UI", 18F);
            TotalTextBox.Location = new Point(117, 12);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(350, 48);
            TotalTextBox.TabIndex = 3;
            // 
            // OrderNumTextBox
            // 
            OrderNumTextBox.BackColor = Color.FromArgb(234, 232, 233);
            OrderNumTextBox.BorderStyle = BorderStyle.None;
            OrderNumTextBox.Font = new Font("Segoe UI", 18F);
            OrderNumTextBox.Location = new Point(270, 57);
            OrderNumTextBox.Name = "OrderNumTextBox";
            OrderNumTextBox.Size = new Size(197, 48);
            OrderNumTextBox.TabIndex = 4;
            // 
            // OrderConfirmationWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 232, 233);
            ClientSize = new Size(587, 196);
            Controls.Add(OrderNumTextBox);
            Controls.Add(TotalTextBox);
            Controls.Add(CloseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderConfirmationWindow";
            Text = "OrderConfirmationWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CloseButton;
        private TextBox TotalTextBox;
        private TextBox OrderNumTextBox;
    }
}