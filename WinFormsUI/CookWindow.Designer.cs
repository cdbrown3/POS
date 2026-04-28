namespace WinFormsUI
{
    partial class CookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookWindow));
            ButtonsPanel = new Panel();
            MainPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            OrdersLabel = new Label();
            ExitButton = new PictureBox();
            ButtonPanel = new Panel();
            CancelOrderButton = new Button();
            CompleteOrderButton = new Button();
            LeftDockPanel = new Panel();
            NotesTextBox = new RichTextBox();
            richTextBox2 = new RichTextBox();
            PhoneTextBox = new TextBox();
            NameTextBox = new TextBox();
            label4 = new Label();
            SelectedOrderLabel = new Label();
            label2 = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitButton).BeginInit();
            ButtonPanel.SuspendLayout();
            LeftDockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.FromArgb(234, 232, 233);
            ButtonsPanel.Location = new Point(9, 835);
            ButtonsPanel.Margin = new Padding(4, 5, 4, 5);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(379, 100);
            ButtonsPanel.TabIndex = 7;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(234, 232, 233);
            MainPanel.Controls.Add(flowLayoutPanel1);
            MainPanel.Controls.Add(OrdersLabel);
            MainPanel.Location = new Point(433, 70);
            MainPanel.Margin = new Padding(4, 5, 4, 5);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1393, 827);
            MainPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(23, 87);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1224, 658);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersLabel.Location = new Point(31, 15);
            OrdersLabel.Margin = new Padding(4, 0, 4, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(159, 60);
            OrdersLabel.TabIndex = 9;
            OrdersLabel.Text = "Orders";
            // 
            // ExitButton
            // 
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(1771, -2);
            ExitButton.Margin = new Padding(4, 5, 4, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(97, 62);
            ExitButton.TabIndex = 8;
            ExitButton.TabStop = false;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.FromArgb(234, 232, 233);
            ButtonPanel.Controls.Add(CancelOrderButton);
            ButtonPanel.Controls.Add(CompleteOrderButton);
            ButtonPanel.Location = new Point(9, 835);
            ButtonPanel.Margin = new Padding(4, 5, 4, 5);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(379, 100);
            ButtonPanel.TabIndex = 22;
            // 
            // CancelOrderButton
            // 
            CancelOrderButton.BackColor = Color.FromArgb(129, 84, 54);
            CancelOrderButton.FlatStyle = FlatStyle.Flat;
            CancelOrderButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CancelOrderButton.Location = new Point(201, 10);
            CancelOrderButton.Name = "CancelOrderButton";
            CancelOrderButton.Size = new Size(157, 80);
            CancelOrderButton.TabIndex = 20;
            CancelOrderButton.Text = "Cancel\r\nOrder";
            CancelOrderButton.UseVisualStyleBackColor = false;
            // 
            // CompleteOrderButton
            // 
            CompleteOrderButton.BackColor = Color.FromArgb(129, 84, 54);
            CompleteOrderButton.FlatStyle = FlatStyle.Flat;
            CompleteOrderButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CompleteOrderButton.Location = new Point(19, 10);
            CompleteOrderButton.Name = "CompleteOrderButton";
            CompleteOrderButton.Size = new Size(151, 80);
            CompleteOrderButton.TabIndex = 19;
            CompleteOrderButton.Text = "Complete Order";
            CompleteOrderButton.UseVisualStyleBackColor = false;
            CompleteOrderButton.Click += CompleteOrderButton_Click;
            // 
            // LeftDockPanel
            // 
            LeftDockPanel.BackColor = Color.FromArgb(234, 232, 233);
            LeftDockPanel.Controls.Add(NotesTextBox);
            LeftDockPanel.Controls.Add(richTextBox2);
            LeftDockPanel.Controls.Add(PhoneTextBox);
            LeftDockPanel.Controls.Add(NameTextBox);
            LeftDockPanel.Controls.Add(label4);
            LeftDockPanel.Controls.Add(SelectedOrderLabel);
            LeftDockPanel.Controls.Add(label2);
            LeftDockPanel.Location = new Point(9, 35);
            LeftDockPanel.Margin = new Padding(4, 5, 4, 5);
            LeftDockPanel.Name = "LeftDockPanel";
            LeftDockPanel.Size = new Size(379, 802);
            LeftDockPanel.TabIndex = 22;
            // 
            // NotesTextBox
            // 
            NotesTextBox.BackColor = Color.FromArgb(234, 232, 233);
            NotesTextBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NotesTextBox.Location = new Point(19, 285);
            NotesTextBox.Margin = new Padding(4, 5, 4, 5);
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(338, 279);
            NotesTextBox.TabIndex = 16;
            NotesTextBox.Text = "  Special Instructions";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(1604, 620);
            richTextBox2.Margin = new Padding(4, 5, 4, 5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(141, 157);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BackColor = Color.FromArgb(234, 232, 233);
            PhoneTextBox.BorderStyle = BorderStyle.None;
            PhoneTextBox.Font = new Font("Segoe UI", 18F);
            PhoneTextBox.Location = new Point(144, 167);
            PhoneTextBox.Margin = new Padding(4, 5, 4, 5);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.ReadOnly = true;
            PhoneTextBox.Size = new Size(207, 48);
            PhoneTextBox.TabIndex = 25;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(234, 232, 233);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 18F);
            NameTextBox.Location = new Point(139, 90);
            NameTextBox.Margin = new Padding(4, 5, 4, 5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(207, 48);
            NameTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 48);
            label4.TabIndex = 10;
            label4.Text = "Items";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectedOrderLabel.Location = new Point(9, 12);
            SelectedOrderLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(307, 55);
            SelectedOrderLabel.TabIndex = 9;
            SelectedOrderLabel.Text = "Selected Order";
            SelectedOrderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 48);
            label2.TabIndex = 8;
            label2.Text = "Item";
            // 
            // CookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 46);
            ClientSize = new Size(1834, 935);
            Controls.Add(LeftDockPanel);
            Controls.Add(ButtonPanel);
            Controls.Add(ExitButton);
            Controls.Add(ButtonsPanel);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CookWindow";
            Text = "CookWindow";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitButton).EndInit();
            ButtonPanel.ResumeLayout(false);
            LeftDockPanel.ResumeLayout(false);
            LeftDockPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonsPanel;
        private Panel MainPanel;
        private PictureBox ExitButton;
        private Label OrdersLabel;
        private Panel ButtonPanel;
        private Button CancelOrderButton;
        private Button CompleteOrderButton;
        private Panel LeftDockPanel;
        private RichTextBox NotesTextBox;
        private RichTextBox richTextBox2;
        private TextBox PhoneTextBox;
        private TextBox NameTextBox;
        private Label label4;
        private Label SelectedOrderLabel;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}