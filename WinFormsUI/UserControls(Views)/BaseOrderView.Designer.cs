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
            ConfirmOrderItemButton = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ConfirmButton = new Button();
            OrderLabel = new Label();
            OrderTextBox = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 30, 46);
            panel1.Controls.Add(ConfirmOrderItemButton);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(621, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 476);
            panel1.TabIndex = 7;
            // 
            // ConfirmOrderItemButton
            // 
            ConfirmOrderItemButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmOrderItemButton.Location = new Point(0, 443);
            ConfirmOrderItemButton.Name = "ConfirmOrderItemButton";
            ConfirmOrderItemButton.Size = new Size(338, 30);
            ConfirmOrderItemButton.TabIndex = 16;
            ConfirmOrderItemButton.Text = "Confirm";
            ConfirmOrderItemButton.UseVisualStyleBackColor = true;
            ConfirmOrderItemButton.Click += ConfirmOrderItemButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(28, 30, 46);
            numericUpDown1.Font = new Font("Segoe UI", 40F);
            numericUpDown1.ForeColor = SystemColors.Window;
            numericUpDown1.Location = new Point(89, 213);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(159, 78);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(100, 138);
            label1.Name = "label1";
            label1.Size = new Size(128, 72);
            label1.TabIndex = 2;
            label1.Text = "QTY";
            label1.Visible = false;
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
            ConfirmButton.Click += ConfirmButton_Click;
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
            // OrderTextBox
            // 
            OrderTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            OrderTextBox.Location = new Point(3, 337);
            OrderTextBox.Name = "OrderTextBox";
            OrderTextBox.Size = new Size(569, 109);
            OrderTextBox.TabIndex = 14;
            OrderTextBox.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(569, 278);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // BaseOrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(OrderTextBox);
            Controls.Add(ConfirmButton);
            Controls.Add(OrderLabel);
            Controls.Add(panel1);
            Name = "BaseOrderView";
            Size = new Size(975, 496);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ConfirmButton;
        private Label OrderLabel;
        private RichTextBox OrderTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button ConfirmOrderItemButton;
    }
}
