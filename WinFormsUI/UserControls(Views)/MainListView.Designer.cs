namespace WinFormsUI
{
    partial class MainListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainListView));
            ExitButton = new PictureBox();
            panel1 = new Panel();
            EmployeesLabel = new Label();
            CustomersLabel = new Label();
            SearchTextBox = new TextBox();
            NameTextBox = new TextBox();
            CustomerListBox = new ListBox();
            AddUserButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ExitButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddUserButton).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(1239, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(52, 36);
            ExitButton.TabIndex = 8;
            ExitButton.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 232, 233);
            panel1.Controls.Add(EmployeesLabel);
            panel1.Controls.Add(CustomersLabel);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(CustomerListBox);
            panel1.Controls.Add(AddUserButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 496);
            panel1.TabIndex = 1;
            // 
            // EmployeesLabel
            // 
            EmployeesLabel.AutoSize = true;
            EmployeesLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeesLabel.Location = new Point(211, 4);
            EmployeesLabel.Name = "EmployeesLabel";
            EmployeesLabel.Size = new Size(148, 37);
            EmployeesLabel.TabIndex = 7;
            EmployeesLabel.Text = "Employees";
            EmployeesLabel.Click += EmployeesLabel_Click;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersLabel.Location = new Point(17, 4);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(148, 37);
            CustomersLabel.TabIndex = 6;
            CustomersLabel.Text = "Customers";
            CustomersLabel.Click += CustomersLabel_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 18F);
            SearchTextBox.ForeColor = SystemColors.ScrollBar;
            SearchTextBox.Location = new Point(17, 44);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(148, 39);
            SearchTextBox.TabIndex = 5;
            SearchTextBox.Text = "search";
            SearchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 18F);
            NameTextBox.ForeColor = SystemColors.ScrollBar;
            NameTextBox.Location = new Point(181, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(270, 39);
            NameTextBox.TabIndex = 4;
            NameTextBox.Text = "name";
            NameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerListBox
            // 
            CustomerListBox.BackColor = Color.FromArgb(234, 232, 233);
            CustomerListBox.Font = new Font("Segoe UI", 18F);
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.ItemHeight = 32;
            CustomerListBox.Location = new Point(17, 99);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(434, 356);
            CustomerListBox.TabIndex = 3;
            CustomerListBox.SelectedIndexChanged += CustomerListBox_SelectedIndexChanged;
            // 
            // AddUserButton
            // 
            AddUserButton.Image = (Image)resources.GetObject("AddUserButton.Image");
            AddUserButton.Location = new Point(924, 14);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(48, 43);
            AddUserButton.TabIndex = 1;
            AddUserButton.TabStop = false;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 46);
            Controls.Add(panel1);
            Controls.Add(ExitButton);
            Name = "UserControl2";
            Size = new Size(975, 496);
            ((System.ComponentModel.ISupportInitialize)ExitButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddUserButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ExitButton;
        private Panel panel1;
        private PictureBox AddUserButton;
        private ListBox CustomerListBox;
        private TextBox SearchTextBox;
        private TextBox NameTextBox;
        private Label CustomersLabel;
        private Label EmployeesLabel;
    }
}
