namespace WinFormsUI
{
    partial class TacoOrderView
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
            FlourCheckBox = new CheckBox();
            CornTortillaCheckBox = new CheckBox();
            Tortilla = new Label();
            ShrimpCheckBox = new CheckBox();
            SteakCheckBox = new CheckBox();
            button1 = new Button();
            ChickenCheckBox = new CheckBox();
            MeatLabel = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(FlourCheckBox);
            panel1.Controls.Add(CornTortillaCheckBox);
            panel1.Controls.Add(Tortilla);
            panel1.Controls.Add(ShrimpCheckBox);
            panel1.Controls.Add(SteakCheckBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ChickenCheckBox);
            panel1.Controls.Add(MeatLabel);
            panel1.Location = new Point(621, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 476);
            panel1.TabIndex = 14;
            // 
            // FlourCheckBox
            // 
            FlourCheckBox.AutoSize = true;
            FlourCheckBox.Font = new Font("Segoe UI", 12F);
            FlourCheckBox.ForeColor = SystemColors.ControlLightLight;
            FlourCheckBox.Location = new Point(169, 152);
            FlourCheckBox.Name = "FlourCheckBox";
            FlourCheckBox.Size = new Size(65, 25);
            FlourCheckBox.TabIndex = 28;
            FlourCheckBox.Text = "Flour";
            FlourCheckBox.UseVisualStyleBackColor = true;
            FlourCheckBox.CheckedChanged += FlourCheckBox_CheckedChanged;
            // 
            // CornTortillaCheckBox
            // 
            CornTortillaCheckBox.AutoSize = true;
            CornTortillaCheckBox.Font = new Font("Segoe UI", 12F);
            CornTortillaCheckBox.ForeColor = SystemColors.ControlLightLight;
            CornTortillaCheckBox.Location = new Point(169, 128);
            CornTortillaCheckBox.Name = "CornTortillaCheckBox";
            CornTortillaCheckBox.Size = new Size(63, 25);
            CornTortillaCheckBox.TabIndex = 27;
            CornTortillaCheckBox.Text = "Corn";
            CornTortillaCheckBox.UseVisualStyleBackColor = true;
            CornTortillaCheckBox.CheckedChanged += CornTortillaCheckBox_CheckedChanged;
            // 
            // Tortilla
            // 
            Tortilla.AutoSize = true;
            Tortilla.Font = new Font("Segoe UI", 18F);
            Tortilla.ForeColor = SystemColors.ControlLightLight;
            Tortilla.Location = new Point(78, 137);
            Tortilla.Name = "Tortilla";
            Tortilla.Size = new Size(85, 32);
            Tortilla.TabIndex = 26;
            Tortilla.Text = "Tortilla";
            // 
            // ShrimpCheckBox
            // 
            ShrimpCheckBox.AutoSize = true;
            ShrimpCheckBox.Font = new Font("Segoe UI", 12F);
            ShrimpCheckBox.ForeColor = SystemColors.ControlLightLight;
            ShrimpCheckBox.Location = new Point(167, 88);
            ShrimpCheckBox.Name = "ShrimpCheckBox";
            ShrimpCheckBox.Size = new Size(80, 25);
            ShrimpCheckBox.TabIndex = 25;
            ShrimpCheckBox.Text = "Shrimp";
            ShrimpCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteakCheckBox
            // 
            SteakCheckBox.AutoSize = true;
            SteakCheckBox.Font = new Font("Segoe UI", 12F);
            SteakCheckBox.ForeColor = SystemColors.ControlLightLight;
            SteakCheckBox.Location = new Point(167, 68);
            SteakCheckBox.Name = "SteakCheckBox";
            SteakCheckBox.Size = new Size(66, 25);
            SteakCheckBox.TabIndex = 24;
            SteakCheckBox.Text = "Steak";
            SteakCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button1.Location = new Point(26, 3);
            button1.Name = "button1";
            button1.Size = new Size(300, 39);
            button1.TabIndex = 22;
            button1.Text = "Tacos";
            button1.UseVisualStyleBackColor = true;
            // 
            // ChickenCheckBox
            // 
            ChickenCheckBox.AutoSize = true;
            ChickenCheckBox.Font = new Font("Segoe UI", 12F);
            ChickenCheckBox.ForeColor = SystemColors.ControlLightLight;
            ChickenCheckBox.Location = new Point(167, 47);
            ChickenCheckBox.Name = "ChickenCheckBox";
            ChickenCheckBox.Size = new Size(84, 25);
            ChickenCheckBox.TabIndex = 23;
            ChickenCheckBox.Text = "Chicken";
            ChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeatLabel
            // 
            MeatLabel.AutoSize = true;
            MeatLabel.Font = new Font("Segoe UI", 18F);
            MeatLabel.ForeColor = SystemColors.ControlLightLight;
            MeatLabel.Location = new Point(78, 54);
            MeatLabel.Name = "MeatLabel";
            MeatLabel.Size = new Size(69, 32);
            MeatLabel.TabIndex = 0;
            MeatLabel.Text = "Meat";
            // 
            // UserControl10
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
            Name = "UserControl10";
            Size = new Size(975, 496);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label MeatLabel;
        private Button button1;
        private CheckBox SteakCheckBox;
        private CheckBox ChickenCheckBox;
        private CheckBox ShrimpCheckBox;
        private CheckBox FlourCheckBox;
        private CheckBox CornTortillaCheckBox;
        private Label Tortilla;
    }
}
