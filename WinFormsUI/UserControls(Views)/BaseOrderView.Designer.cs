namespace WinFormsUI
{
    partial class BaseOrderView
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            TacosButton = new Button();
            HamburgerButton = new Button();
            ConfirmButton = new Button();
            OrderLabel = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 30, 46);
            panel1.Location = new Point(621, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 476);
            panel1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 209);
            button5.Name = "button5";
            button5.Size = new Size(553, 46);
            button5.TabIndex = 13;
            button5.Text = "Fries";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 157);
            button4.Name = "button4";
            button4.Size = new Size(553, 46);
            button4.TabIndex = 12;
            button4.Text = "Wings";
            button4.UseVisualStyleBackColor = true;
            // 
            // TacosButton
            // 
            TacosButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TacosButton.Location = new Point(3, 105);
            TacosButton.Name = "TacosButton";
            TacosButton.Size = new Size(553, 46);
            TacosButton.TabIndex = 11;
            TacosButton.Text = "Tacos";
            TacosButton.UseVisualStyleBackColor = true;
            TacosButton.Click += TacosButton_Click;
            // 
            // HamburgerButton
            // 
            HamburgerButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HamburgerButton.Location = new Point(3, 53);
            HamburgerButton.Name = "HamburgerButton";
            HamburgerButton.Size = new Size(553, 46);
            HamburgerButton.TabIndex = 10;
            HamburgerButton.Text = "Hamburger";
            HamburgerButton.UseVisualStyleBackColor = true;
            HamburgerButton.Click += HamburgerButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(3, 452);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(591, 30);
            ConfirmButton.TabIndex = 9;
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
            OrderLabel.TabIndex = 8;
            OrderLabel.Text = "Order";
            // 
            // UserControl8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(TacosButton);
            Controls.Add(HamburgerButton);
            Controls.Add(ConfirmButton);
            Controls.Add(OrderLabel);
            Controls.Add(panel1);
            Name = "UserControl8";
            Size = new Size(975, 496);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button TacosButton;
        private Button HamburgerButton;
        private Button ConfirmButton;
        private Label OrderLabel;
    }
}
