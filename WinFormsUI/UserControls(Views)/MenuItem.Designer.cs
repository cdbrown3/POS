namespace WinFormsUI
{
    partial class MenuItem
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
            MenuItemButton = new Button();
            SuspendLayout();
            // 
            // MenuItemButton
            // 
            MenuItemButton.Font = new Font("Segoe UI", 18F);
            MenuItemButton.Location = new Point(0, 3);
            MenuItemButton.Name = "MenuItemButton";
            MenuItemButton.Size = new Size(544, 46);
            MenuItemButton.TabIndex = 0;
            MenuItemButton.Text = "1";
            MenuItemButton.UseVisualStyleBackColor = true;
            MenuItemButton.Click += MenuItemButton_Click;
            // 
            // MenuItem
            // 
            Controls.Add(MenuItemButton);
            Name = "MenuItem";
            Size = new Size(550, 52);
            ResumeLayout(false);
        }

        #endregion

        private Button MenuItem2;
        private Button MenuItemButton;
    }
}
