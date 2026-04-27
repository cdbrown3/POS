namespace WinFormsUI
{
    partial class EmployeeMethodPanel
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
            panel1 = new Panel();
            EditCustomerButton = new Button();
            NewOrderButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(205, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 60);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 232, 233);
            panel1.Controls.Add(EditCustomerButton);
            panel1.Controls.Add(NewOrderButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 60);
            panel1.TabIndex = 21;
            // 
            // EditCustomerButton
            // 
            EditCustomerButton.BackColor = Color.FromArgb(129, 84, 54);
            EditCustomerButton.FlatStyle = FlatStyle.Flat;
            EditCustomerButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EditCustomerButton.Location = new Point(138, 12);
            EditCustomerButton.Margin = new Padding(2);
            EditCustomerButton.Name = "EditCustomerButton";
            EditCustomerButton.Size = new Size(113, 37);
            EditCustomerButton.TabIndex = 20;
            EditCustomerButton.Text = "Edit Customer";
            EditCustomerButton.UseVisualStyleBackColor = false;
            EditCustomerButton.Click += EditCustomerButton_Click;
            // 
            // NewOrderButton
            // 
            NewOrderButton.BackColor = Color.FromArgb(129, 84, 54);
            NewOrderButton.FlatStyle = FlatStyle.Flat;
            NewOrderButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            NewOrderButton.Location = new Point(13, 12);
            NewOrderButton.Margin = new Padding(2);
            NewOrderButton.Name = "NewOrderButton";
            NewOrderButton.Size = new Size(102, 37);
            NewOrderButton.TabIndex = 19;
            NewOrderButton.Text = "New Order";
            NewOrderButton.UseVisualStyleBackColor = false;
            NewOrderButton.Click += NewOrderButton_Click;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControl4";
            Size = new Size(264, 59);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button EditCustomerButton;
        private Button NewOrderButton;
    }
}
