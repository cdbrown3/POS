namespace WinFormsUI
{
    partial class HamburgerOrderView
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            HamburgerButton = new Button();
            ConfirmButton = new Button();
            OrderLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            QTYUpDown = new NumericUpDown();
            ConfimOrderItemButton = new Button();
            OnionChheckBox = new CheckBox();
            PickelsCheckBox = new CheckBox();
            TomatoCheckBox = new CheckBox();
            CheeseCheckBox = new CheckBox();
            PattyCountLabel = new Label();
            PattyCountUpDown = new NumericUpDown();
            NoBunCheckBox = new CheckBox();
            button1 = new Button();
            BunCheckBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QTYUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PattyCountUpDown).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 209);
            button5.Name = "button5";
            button5.Size = new Size(553, 46);
            button5.TabIndex = 20;
            button5.Text = "Fries";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 157);
            button4.Name = "button4";
            button4.Size = new Size(553, 46);
            button4.TabIndex = 19;
            button4.Text = "Wings";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 105);
            button3.Name = "button3";
            button3.Size = new Size(553, 46);
            button3.TabIndex = 18;
            button3.Text = "Tacos";
            button3.UseVisualStyleBackColor = true;
            // 
            // HamburgerButton
            // 
            HamburgerButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HamburgerButton.Location = new Point(3, 53);
            HamburgerButton.Name = "HamburgerButton";
            HamburgerButton.Size = new Size(553, 46);
            HamburgerButton.TabIndex = 17;
            HamburgerButton.Text = "Hamburger";
            HamburgerButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(3, 452);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(591, 30);
            ConfirmButton.TabIndex = 16;
            ConfirmButton.Text = "Confirm And Pay";
            ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderLabel.Location = new Point(0, 0);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(93, 40);
            OrderLabel.TabIndex = 15;
            OrderLabel.Text = "Order";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 30, 46);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(QTYUpDown);
            panel1.Controls.Add(ConfimOrderItemButton);
            panel1.Controls.Add(OnionChheckBox);
            panel1.Controls.Add(PickelsCheckBox);
            panel1.Controls.Add(TomatoCheckBox);
            panel1.Controls.Add(CheeseCheckBox);
            panel1.Controls.Add(PattyCountLabel);
            panel1.Controls.Add(PattyCountUpDown);
            panel1.Controls.Add(NoBunCheckBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BunCheckBox);
            panel1.Location = new Point(621, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 476);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 334);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 30;
            label1.Text = "QTY:";
            // 
            // QTYUpDown
            // 
            QTYUpDown.BackColor = Color.FromArgb(28, 30, 46);
            QTYUpDown.BorderStyle = BorderStyle.None;
            QTYUpDown.Font = new Font("Segoe UI", 15F);
            QTYUpDown.ForeColor = SystemColors.ButtonHighlight;
            QTYUpDown.Location = new Point(75, 335);
            QTYUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            QTYUpDown.Name = "QTYUpDown";
            QTYUpDown.Size = new Size(163, 30);
            QTYUpDown.TabIndex = 29;
            // 
            // ConfimOrderItemButton
            // 
            ConfimOrderItemButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfimOrderItemButton.Location = new Point(33, 427);
            ConfimOrderItemButton.Name = "ConfimOrderItemButton";
            ConfimOrderItemButton.Size = new Size(285, 46);
            ConfimOrderItemButton.TabIndex = 21;
            ConfimOrderItemButton.Text = "Confirm";
            ConfimOrderItemButton.UseVisualStyleBackColor = true;
            ConfimOrderItemButton.Click += ConfimOrderItemButton_Click;
            // 
            // OnionChheckBox
            // 
            OnionChheckBox.AutoSize = true;
            OnionChheckBox.Font = new Font("Segoe UI", 15F);
            OnionChheckBox.ForeColor = SystemColors.ButtonHighlight;
            OnionChheckBox.Location = new Point(18, 279);
            OnionChheckBox.Name = "OnionChheckBox";
            OnionChheckBox.Size = new Size(85, 32);
            OnionChheckBox.TabIndex = 28;
            OnionChheckBox.Text = "Onion";
            OnionChheckBox.UseVisualStyleBackColor = true;
            // 
            // PickelsCheckBox
            // 
            PickelsCheckBox.AutoSize = true;
            PickelsCheckBox.Font = new Font("Segoe UI", 15F);
            PickelsCheckBox.ForeColor = SystemColors.ButtonHighlight;
            PickelsCheckBox.Location = new Point(18, 241);
            PickelsCheckBox.Name = "PickelsCheckBox";
            PickelsCheckBox.Size = new Size(89, 32);
            PickelsCheckBox.TabIndex = 27;
            PickelsCheckBox.Text = "Pickles";
            PickelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TomatoCheckBox
            // 
            TomatoCheckBox.AutoSize = true;
            TomatoCheckBox.Font = new Font("Segoe UI", 15F);
            TomatoCheckBox.ForeColor = SystemColors.ButtonHighlight;
            TomatoCheckBox.Location = new Point(18, 203);
            TomatoCheckBox.Name = "TomatoCheckBox";
            TomatoCheckBox.Size = new Size(97, 32);
            TomatoCheckBox.TabIndex = 26;
            TomatoCheckBox.Text = "Tomato";
            TomatoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheeseCheckBox
            // 
            CheeseCheckBox.AutoSize = true;
            CheeseCheckBox.Font = new Font("Segoe UI", 15F);
            CheeseCheckBox.ForeColor = SystemColors.ButtonHighlight;
            CheeseCheckBox.Location = new Point(18, 165);
            CheeseCheckBox.Name = "CheeseCheckBox";
            CheeseCheckBox.Size = new Size(92, 32);
            CheeseCheckBox.TabIndex = 25;
            CheeseCheckBox.Text = "Cheese";
            CheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // PattyCountLabel
            // 
            PattyCountLabel.AutoSize = true;
            PattyCountLabel.Font = new Font("Segoe UI", 15F);
            PattyCountLabel.ForeColor = SystemColors.ButtonHighlight;
            PattyCountLabel.Location = new Point(18, 122);
            PattyCountLabel.Name = "PattyCountLabel";
            PattyCountLabel.Size = new Size(118, 28);
            PattyCountLabel.TabIndex = 24;
            PattyCountLabel.Text = "Patty Count:";
            // 
            // PattyCountUpDown
            // 
            PattyCountUpDown.BackColor = Color.FromArgb(28, 30, 46);
            PattyCountUpDown.BorderStyle = BorderStyle.None;
            PattyCountUpDown.Font = new Font("Segoe UI", 15F);
            PattyCountUpDown.ForeColor = SystemColors.ButtonHighlight;
            PattyCountUpDown.Location = new Point(142, 122);
            PattyCountUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            PattyCountUpDown.Name = "PattyCountUpDown";
            PattyCountUpDown.Size = new Size(163, 30);
            PattyCountUpDown.TabIndex = 23;
            PattyCountUpDown.ValueChanged += PattyCountUpDown_ValueChanged;
            // 
            // NoBunCheckBox
            // 
            NoBunCheckBox.AutoSize = true;
            NoBunCheckBox.Font = new Font("Segoe UI", 15F);
            NoBunCheckBox.ForeColor = SystemColors.ButtonHighlight;
            NoBunCheckBox.Location = new Point(18, 86);
            NoBunCheckBox.Name = "NoBunCheckBox";
            NoBunCheckBox.Size = new Size(96, 32);
            NoBunCheckBox.TabIndex = 22;
            NoBunCheckBox.Text = "No Bun";
            NoBunCheckBox.UseVisualStyleBackColor = true;
            NoBunCheckBox.CheckedChanged += NoBunCheckBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button1.Location = new Point(18, 3);
            button1.Name = "button1";
            button1.Size = new Size(300, 39);
            button1.TabIndex = 21;
            button1.Text = "Hamburger";
            button1.UseVisualStyleBackColor = true;
            // 
            // BunCheckBox
            // 
            BunCheckBox.AutoSize = true;
            BunCheckBox.Font = new Font("Segoe UI", 15F);
            BunCheckBox.ForeColor = SystemColors.ButtonHighlight;
            BunCheckBox.Location = new Point(18, 48);
            BunCheckBox.Name = "BunCheckBox";
            BunCheckBox.Size = new Size(64, 32);
            BunCheckBox.TabIndex = 0;
            BunCheckBox.Text = "Bun";
            BunCheckBox.UseVisualStyleBackColor = true;
            BunCheckBox.CheckedChanged += BunCheckBox_CheckedChanged;
            // 
            // HamburgerOrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(HamburgerButton);
            Controls.Add(ConfirmButton);
            Controls.Add(OrderLabel);
            Controls.Add(panel1);
            Name = "HamburgerOrderView";
            Size = new Size(975, 496);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QTYUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PattyCountUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button HamburgerButton;
        private Button ConfirmButton;
        private Label OrderLabel;
        private Panel panel1;
        private Label PattyCountLabel;
        private NumericUpDown PattyCountUpDown;
        private CheckBox NoBunCheckBox;
        private Button button1;
        private CheckBox BunCheckBox;
        private CheckBox OnionChheckBox;
        private CheckBox PickelsCheckBox;
        private CheckBox TomatoCheckBox;
        private CheckBox CheeseCheckBox;
        private Button ConfimOrderItemButton;
        private Label label1;
        private NumericUpDown QTYUpDown;
    }
}
