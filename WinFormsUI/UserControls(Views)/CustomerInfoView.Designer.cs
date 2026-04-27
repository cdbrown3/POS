namespace WinFormsUI
{
    partial class CustomerInfoView
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
            IDTextBox = new TextBox();
            NotesTextBox = new RichTextBox();
            OrderHistoryTextBox = new TextBox();
            richTextBox1 = new RichTextBox();
            PhoneTextBox = new TextBox();
            label6 = new Label();
            NameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            EditCustomerButton = new Button();
            button2 = new Button();
            LeftDockPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LeftDockPanel
            // 
            LeftDockPanel.Controls.Add(IDTextBox);
            LeftDockPanel.Controls.Add(NotesTextBox);
            LeftDockPanel.Controls.Add(OrderHistoryTextBox);
            LeftDockPanel.Controls.Add(richTextBox1);
            LeftDockPanel.Controls.Add(PhoneTextBox);
            LeftDockPanel.Controls.Add(label6);
            LeftDockPanel.Controls.Add(NameTextBox);
            LeftDockPanel.Controls.Add(label5);
            LeftDockPanel.Controls.Add(label4);
            LeftDockPanel.Controls.Add(label3);
            LeftDockPanel.Controls.Add(label2);
            LeftDockPanel.Controls.Add(label7);
            LeftDockPanel.Controls.Add(label8);
            LeftDockPanel.Location = new Point(0, 0);
            LeftDockPanel.Name = "LeftDockPanel";
            LeftDockPanel.Size = new Size(265, 481);
            LeftDockPanel.TabIndex = 2;
            // 
            // IDTextBox
            // 
            IDTextBox.BackColor = Color.FromArgb(234, 232, 233);
            IDTextBox.BorderStyle = BorderStyle.None;
            IDTextBox.Font = new Font("Segoe UI", 18F);
            IDTextBox.Location = new Point(56, 239);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(145, 32);
            IDTextBox.TabIndex = 28;
            // 
            // NotesTextBox
            // 
            NotesTextBox.BackColor = Color.FromArgb(234, 232, 233);
            NotesTextBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NotesTextBox.Location = new Point(8, 299);
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(238, 169);
            NotesTextBox.TabIndex = 16;
            NotesTextBox.Text = "Notes: ";
            // 
            // OrderHistoryTextBox
            // 
            OrderHistoryTextBox.BackColor = Color.FromArgb(234, 232, 233);
            OrderHistoryTextBox.BorderStyle = BorderStyle.None;
            OrderHistoryTextBox.Font = new Font("Segoe UI", 18F);
            OrderHistoryTextBox.Location = new Point(107, 175);
            OrderHistoryTextBox.Name = "OrderHistoryTextBox";
            OrderHistoryTextBox.ReadOnly = true;
            OrderHistoryTextBox.Size = new Size(145, 32);
            OrderHistoryTextBox.TabIndex = 26;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1123, 372);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BackColor = Color.FromArgb(234, 232, 233);
            PhoneTextBox.BorderStyle = BorderStyle.None;
            PhoneTextBox.Font = new Font("Segoe UI", 18F);
            PhoneTextBox.Location = new Point(101, 100);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.ReadOnly = true;
            PhoneTextBox.Size = new Size(145, 32);
            PhoneTextBox.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 239);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 12;
            label6.Text = "ID:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(234, 232, 233);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 18F);
            NameTextBox.Location = new Point(97, 54);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(145, 32);
            NameTextBox.TabIndex = 24;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.KeyPress += NameTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 150);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 11;
            label5.Text = "Order";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 102);
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
            label3.Size = new Size(257, 37);
            label3.TabIndex = 9;
            label3.Text = "Selected Customer";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 175);
            label7.Name = "label7";
            label7.Size = new Size(93, 32);
            label7.TabIndex = 13;
            label7.Text = "History";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 198);
            label8.Name = "label8";
            label8.Size = new Size(80, 32);
            label8.TabIndex = 14;
            label8.Text = "Count";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 232, 233);
            panel1.Controls.Add(EditCustomerButton);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 60);
            panel1.TabIndex = 20;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(129, 84, 54);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(13, 12);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(102, 37);
            button2.TabIndex = 19;
            button2.Text = "New Order";
            button2.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 232, 233);
            Controls.Add(panel1);
            Controls.Add(LeftDockPanel);
            Name = "UserControl1";
            Size = new Size(1284, 561);
            LeftDockPanel.ResumeLayout(false);
            LeftDockPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftDockPanel;
        private RichTextBox NotesTextBox;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private TextBox IDTextBox;
        private TextBox OrderHistoryTextBox;
        private TextBox PhoneTextBox;
        private TextBox NameTextBox;
        private Panel panel1;
        private Button EditCustomerButton;
        private Button button2;
    }
}
