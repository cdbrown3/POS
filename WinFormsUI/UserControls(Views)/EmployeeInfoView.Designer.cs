namespace WinFormsUI.UserControls_Views_
{
    partial class EmployeeInfoView
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
            LeftDockPanel = new Panel();
            panel2 = new Panel();
            EditCustomerButton = new Button();
            NewOrderButton = new Button();
            ActiveTextBox = new TextBox();
            IDTextBox = new TextBox();
            PositionTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            NameTextBox = new TextBox();
            label5 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            EditEmployeeButton = new Button();
            button1 = new Button();
            LeftDockPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LeftDockPanel
            // 
            LeftDockPanel.Controls.Add(panel2);
            LeftDockPanel.Controls.Add(ActiveTextBox);
            LeftDockPanel.Controls.Add(IDTextBox);
            LeftDockPanel.Controls.Add(PositionTextBox);
            LeftDockPanel.Controls.Add(PhoneTextBox);
            LeftDockPanel.Controls.Add(NameTextBox);
            LeftDockPanel.Controls.Add(label5);
            LeftDockPanel.Controls.Add(label1);
            LeftDockPanel.Controls.Add(richTextBox1);
            LeftDockPanel.Controls.Add(label6);
            LeftDockPanel.Controls.Add(label4);
            LeftDockPanel.Controls.Add(label3);
            LeftDockPanel.Controls.Add(label2);
            LeftDockPanel.Location = new Point(0, 0);
            LeftDockPanel.Name = "LeftDockPanel";
            LeftDockPanel.Size = new Size(265, 481);
            LeftDockPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 232, 233);
            panel2.Controls.Add(EditCustomerButton);
            panel2.Controls.Add(NewOrderButton);
            panel2.Location = new Point(14, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 69);
            panel2.TabIndex = 19;
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
            // 
            // ActiveTextBox
            // 
            ActiveTextBox.BackColor = Color.FromArgb(234, 232, 233);
            ActiveTextBox.BorderStyle = BorderStyle.None;
            ActiveTextBox.Font = new Font("Segoe UI", 18F);
            ActiveTextBox.Location = new Point(109, 227);
            ActiveTextBox.Name = "ActiveTextBox";
            ActiveTextBox.Size = new Size(145, 32);
            ActiveTextBox.TabIndex = 23;
            // 
            // IDTextBox
            // 
            IDTextBox.BackColor = Color.FromArgb(234, 232, 233);
            IDTextBox.BorderStyle = BorderStyle.None;
            IDTextBox.Font = new Font("Segoe UI", 18F);
            IDTextBox.Location = new Point(64, 185);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(145, 32);
            IDTextBox.TabIndex = 22;
            // 
            // PositionTextBox
            // 
            PositionTextBox.BackColor = Color.FromArgb(234, 232, 233);
            PositionTextBox.BorderStyle = BorderStyle.None;
            PositionTextBox.Font = new Font("Segoe UI", 18F);
            PositionTextBox.Location = new Point(117, 142);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(145, 32);
            PositionTextBox.TabIndex = 21;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BackColor = Color.FromArgb(234, 232, 233);
            PhoneTextBox.BorderStyle = BorderStyle.None;
            PhoneTextBox.Font = new Font("Segoe UI", 18F);
            PhoneTextBox.Location = new Point(109, 96);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(145, 32);
            PhoneTextBox.TabIndex = 20;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(234, 232, 233);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 18F);
            NameTextBox.Location = new Point(105, 51);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(145, 32);
            NameTextBox.TabIndex = 19;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 227);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 18;
            label5.Text = "Active:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 142);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 17;
            label1.Text = "Position:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1123, 372);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 185);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 12;
            label6.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 96);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 10;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 37);
            label3.TabIndex = 9;
            label3.Text = "Selected Employee";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 8;
            label2.Text = "Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(EditEmployeeButton);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 60);
            panel1.TabIndex = 20;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.BackColor = Color.FromArgb(129, 84, 54);
            EditEmployeeButton.FlatStyle = FlatStyle.Flat;
            EditEmployeeButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditEmployeeButton.Location = new Point(138, 12);
            EditEmployeeButton.Margin = new Padding(2);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new Size(113, 37);
            EditEmployeeButton.TabIndex = 20;
            EditEmployeeButton.Text = "Edit Employee";
            EditEmployeeButton.UseVisualStyleBackColor = false;
            EditEmployeeButton.Click += EditEmployeeButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(129, 84, 54);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 12);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 19;
            button1.Text = "Archive";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 232, 233);
            Controls.Add(panel1);
            Controls.Add(LeftDockPanel);
            Name = "UserControl6";
            Size = new Size(1284, 561);
            LeftDockPanel.ResumeLayout(false);
            LeftDockPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftDockPanel;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox NameTextBox;
        private TextBox ActiveTextBox;
        private TextBox IDTextBox;
        private TextBox PositionTextBox;
        private TextBox PhoneTextBox;
        private Panel panel2;
        private Button EditCustomerButton;
        private Button NewOrderButton;
        private Panel panel1;
        private Button EditEmployeeButton;
        private Button button1;
    }
}
